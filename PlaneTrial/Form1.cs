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

        private static int spaceShipPosition_X;
        private static int spaceShipPosition_Y;

        private static int lassersShipPosition_X;
        private static int lassersShipPosition_Y;

        private static string level = "easy";

        private static int ship_increment   = 2;
        private static int rocket_increment = 4;
        private static int lasser_increment = 8;
        private static int darkShip_increment = 1;

        private static int backGroundSize_X;
        private static int backGroundSize_Y;
        private static int rocket_start_pos = -125;
        private static int left_ship_start_pos = 830;
        private static int right_ship_start_pos = -90;
        private static int dark_ship_start_pos = 549;

        public Form1() {

            InitializeComponent();

            spaceShipPosition_X = spaceShip_pictureBox.Location.X;
            spaceShipPosition_Y = spaceShip_pictureBox.Location.Y;
            backGroundSize_X = backGround_pictureBox.Width;
            backGroundSize_Y = backGround_pictureBox.Height;
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
            backGround_pictureBox.Image = global::PlaneTrial.Properties.Resources.blue_sky;
            spaceShip_pictureBox.Visible = true;
            rocket1_pictureBox.Visible = true;
            rocket2_pictureBox.Visible = true;
            rocket3_pictureBox.Visible = true;

        }
        
        private void normal_ButtonClick(object sender, EventArgs e)
        {
            level = "normal";
            backGround_pictureBox.Image = global::PlaneTrial.Properties.Resources.night_sky;
           
            leftShip_pictureBox.Visible = true;
            rightShip_pictureBox.Visible = true;

            darkShip1_pictureBox.Visible = false;
            darkShip1_pictureBox.Visible = false;
        }

        private void hard_ButtonClick(object sender, EventArgs e)
        {
            level = "hard";
            backGround_pictureBox.Image = global::PlaneTrial.Properties.Resources.blood_sky;

            leftShip_pictureBox.Visible = true;
            rightShip_pictureBox.Visible = true;

            darkShip1_pictureBox.Visible = true;
            darkShip2_pictureBox.Visible = true;
        }

        private void pause_ButtonClick(object sender, EventArgs e) {

            timer.Stop();
            Mp3Player.stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: spaceShipPosition_X += lasser_increment; break;
                case Keys.Left:  spaceShipPosition_X -= lasser_increment; break;
                case Keys.Up:    spaceShipPosition_Y -= lasser_increment; break;
                case Keys.Down:  spaceShipPosition_Y += lasser_increment; break;
                case Keys.Space: 
                    lassersShipPosition_X = spaceShipPosition_X + 43;
                    lassersShipPosition_Y = spaceShipPosition_Y - 50;
                    twoLassers_pictureBox.Location = new System.Drawing.Point(lassersShipPosition_X, lassersShipPosition_Y);
                    twoLassers_pictureBox.Visible = true;
                    break;
                default: Debug.WriteLine("Key not useful"); break;
            }

            spaceShip_pictureBox.Location = new System.Drawing.Point(spaceShipPosition_X, spaceShipPosition_Y);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            rocket1_pictureBox.Location = new System.Drawing.Point(300, rocket1_pictureBox.Location.Y + rocket_increment);
            rocket2_pictureBox.Location = new System.Drawing.Point(500, rocket2_pictureBox.Location.Y + rocket_increment);
            rocket3_pictureBox.Location = new System.Drawing.Point(600, rocket3_pictureBox.Location.Y + rocket_increment);

            if (rocket1_pictureBox.Location.Y >= backGroundSize_Y)
                rocket1_pictureBox.Location = new System.Drawing.Point(300, rocket_start_pos);
            
            if (rocket2_pictureBox.Location.Y >= backGroundSize_Y)
                rocket2_pictureBox.Location = new System.Drawing.Point(300, rocket_start_pos);

            if (rocket3_pictureBox.Location.Y >= backGroundSize_Y)
                rocket3_pictureBox.Location = new System.Drawing.Point(300, rocket_start_pos);

            if (level == "normal" || level == "hard") {
                leftShip_pictureBox.Location  = new System.Drawing.Point(leftShip_pictureBox.Location.X - ship_increment, 320);
                rightShip_pictureBox.Location = new System.Drawing.Point(rightShip_pictureBox.Location.X + ship_increment, 320);

                if (leftShip_pictureBox.Location.X <= -87)
                    leftShip_pictureBox.Location = new System.Drawing.Point(left_ship_start_pos, 320);
                if (rightShip_pictureBox.Location.X >= backGroundSize_X)
                    rightShip_pictureBox.Location = new System.Drawing.Point(right_ship_start_pos, 320); 
            }

            if (level == "hard") {
                darkShip1_pictureBox.Location = new System.Drawing.Point(250, darkShip1_pictureBox.Location.Y - darkShip_increment);
                darkShip2_pictureBox.Location = new System.Drawing.Point(550, darkShip2_pictureBox.Location.Y - darkShip_increment);

                if (darkShip1_pictureBox.Location.Y <= -121)
                    darkShip1_pictureBox.Location = new System.Drawing.Point(250, dark_ship_start_pos);
                if (darkShip2_pictureBox.Location.Y <= -121)
                    darkShip2_pictureBox.Location = new System.Drawing.Point(550, dark_ship_start_pos);
            }

            int lasser_increment = 15;
            lassersShipPosition_Y = lassersShipPosition_Y - lasser_increment;

            twoLassers_pictureBox.Location = new System.Drawing.Point(lassersShipPosition_X, lassersShipPosition_Y);
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
