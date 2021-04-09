using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;


namespace PlaneTrial
{
    public partial class Form1 : Form
    {
        private static string resources_path = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName + "\\Resources";
        private static string soundtrack_file = resources_path + "\\" + "Fatboy_Slim_-_Acid_8000.mp3";

        private static int spaceShipPos_X;
        private static int spaceShipPos_Y;

        private static int lassersPos_X;
        private static int lassersPos_Y;

        private static string level = "easy";

        private static int ship_increment   = 13;
        private static int rocket_increment =  4;
        private static int lasser_increment = 15;
        private static int darkShip_increment  = 1;
        private static int shipEnemy_increment = 2;

        private static int bGroundLimit_X;
        private static int bGroundLimit_Y;
        private static int rocket_start_pos = -125;
        private static int leftShip_start_pos  = 830;
        private static int rightShip_start_pos = -90;
        private static int darkShip_start_pos  = 549;


        public Form1() {

            InitializeComponent();

            spaceShipPos_X = spaceShip.Location.X;
            spaceShipPos_Y = spaceShip.Location.Y;
            bGroundLimit_X = backGround.Width;
            bGroundLimit_Y = backGround.Height;
            Mp3Player.open_file(soundtrack_file);
        }

        private void start_ButtonClick(object sender, EventArgs e) {
            timer.Start();
            Mp3Player.play();
        }

        private void easy_ButtonClick(object sender, EventArgs e)
        {
            KeyDown += new KeyEventHandler(Form1_KeyDown);

            level = "easy";
            backGround.Image = global::PlaneTrial.Properties.Resources.blue_sky;
            spaceShip.Visible = true;
            rocket1.Visible = true;
            rocket2.Visible = true;
            rocket3.Visible = true;

        }
        private void normal_ButtonClick(object sender, EventArgs e)
        {
            level = "normal";
            backGround.Image = global::PlaneTrial.Properties.Resources.night_sky;
           
            leftShip.Visible = true;
            rightShip.Visible = true;

            darkShip1.Visible = false;
            darkShip1.Visible = false;
        }

        private void hard_ButtonClick(object sender, EventArgs e)
        {
            level = "hard";
            backGround.Image = global::PlaneTrial.Properties.Resources.blood_sky;

            leftShip.Visible = true;
            rightShip.Visible = true;

            darkShip1.Visible = true;
            darkShip2.Visible = true;
        }

        private void pause_ButtonClick(object sender, EventArgs e) {

            timer.Stop();
            Mp3Player.stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: 
                    if(spaceShipPos_X < bGroundLimit_X - 130) spaceShipPos_X += ship_increment; 
                    break;
                case Keys.Left:  
                    if(spaceShipPos_X > 5) spaceShipPos_X -= ship_increment; 
                    break;
                case Keys.Up:    
                    if(spaceShipPos_Y > 10) spaceShipPos_Y -= ship_increment; 
                    break;
                case Keys.Down:  
                    if(spaceShipPos_Y < bGroundLimit_Y - 100) spaceShipPos_Y += ship_increment; 
                    break;
                case Keys.Space: 
                    lassersPos_X = spaceShipPos_X + 43;
                    lassersPos_Y = spaceShipPos_Y - 50;
                    twoLassers.Visible = true;
                    set_position(ref twoLassers, lassersPos_X, lassersPos_Y);
                    break;
                default: Debug.WriteLine("Key not useful"); break;
            }

            set_position(ref spaceShip, spaceShipPos_X, spaceShipPos_Y);
        }
        private void timer1_Tick(object sender, EventArgs e) {
            move_components();

            if(rocket1.Bounds.IntersectsWith(twoLassers.Bounds)) vanish(ref rocket1);
            if(rocket2.Bounds.IntersectsWith(twoLassers.Bounds)) vanish(ref rocket2);
            if(rocket3.Bounds.IntersectsWith(twoLassers.Bounds)) vanish(ref rocket3);

            if(leftShip.Bounds.IntersectsWith(twoLassers.Bounds)) vanish(ref leftShip);
            if (rightShip.Bounds.IntersectsWith(twoLassers.Bounds)) vanish(ref rightShip);

            if(darkShip1.Bounds.IntersectsWith(twoLassers.Bounds)) vanish(ref darkShip1);
            if (darkShip2.Bounds.IntersectsWith(twoLassers.Bounds)) vanish(ref darkShip2);
        }
        private void vanish(ref System.Windows.Forms.PictureBox image) {
            image.Visible = false;
        }
        private void set_position(ref System.Windows.Forms.PictureBox image, int x, int y) {
            image.Location = new System.Drawing.Point(x, y);
        }

        private void move_components() {
            set_position(ref rocket1, 300, rocket1.Location.Y + rocket_increment);
            set_position(ref rocket2, 500, rocket2.Location.Y + rocket_increment);
            set_position(ref rocket3, 600, rocket3.Location.Y + rocket_increment);

            if(rocket1.Location.Y >= bGroundLimit_Y) {
                set_position(ref rocket1, 300, rocket_start_pos);
                rocket1.Visible = true;
            } 
                
            if(rocket2.Location.Y >= bGroundLimit_Y) {
                set_position(ref rocket2, 300, rocket_start_pos);
                rocket2.Visible = true;
            }

            if (rocket3.Location.Y >= bGroundLimit_Y) {
                set_position(ref rocket3, 300, rocket_start_pos);
                rocket3.Visible = true;
            }
            if (level == "normal" || level == "hard")
            {
                set_position(ref leftShip, leftShip.Location.X - shipEnemy_increment, 320);
                set_position(ref rightShip, rightShip.Location.X + shipEnemy_increment, 320);


                if (leftShip.Location.X <= -87) {
                    set_position(ref leftShip, leftShip_start_pos, 320);
                    leftShip.Visible = true;
                }
                if (rightShip.Location.X >= bGroundLimit_X) {
                    set_position(ref rightShip, rightShip_start_pos, 320);
                    rightShip.Visible = true;
                } 
                    
            }

            if (level == "hard")
            {
                set_position(ref darkShip1, 250, darkShip1.Location.Y - darkShip_increment);
                set_position(ref darkShip2, 550, darkShip2.Location.Y - darkShip_increment);

                if (darkShip1.Location.Y <= -121) {
                    set_position(ref darkShip1, 250, darkShip_start_pos);
                    darkShip1.Visible = true;
                }
                if (darkShip2.Location.Y <= -121) {
                    set_position(ref darkShip2, 550, darkShip_start_pos);
                    darkShip2.Visible = true;
                }
            }

            if (lassersPos_Y > -200)
            {
                lassersPos_Y = lassersPos_Y - lasser_increment;
                set_position(ref twoLassers, lassersPos_X, lassersPos_Y);
            }
        }
    }

    public class Mp3Player
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString,
                                                   int uReturnLength, int hwdCallBack);
        public static void open_file(string File) {

            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
            Debug.WriteLine("Sound track path->" + File);
        }

        public static void play() {

            string command = "Play MediaFile";
            mciSendString(command, null, 0, 0);
            Debug.WriteLine("Playing soundtrack");
        }
        public static void stop() {

            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
            Debug.WriteLine("Stopping soundtrack");
        }
    }
}
