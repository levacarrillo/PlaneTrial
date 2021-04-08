using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Form1() {

            InitializeComponent();

            Mp3Player.open_file(soundtrack_file);
        }

        private void start_ButtonClick(object sender, EventArgs e) {

            Mp3Player.play();
        }

        private void easy_ButtonClick(object sender, EventArgs e)
        {
            KeyDown += new KeyEventHandler(Form1_KeyDown);

            backGround_pictureBox.Image = global::PlaneTrial.Properties.Resources.blue_sky;
            spaceShip_pictureBox.Visible = true;
            rocket1_pictureBox.Visible = true;
            rocket2_pictureBox.Visible = true;
            rocket3_pictureBox.Visible = true;
        }
        
        private void normal_ButtonClick(object sender, EventArgs e)
        {
            backGround_pictureBox.Image = global::PlaneTrial.Properties.Resources.night_sky;
        }

        private void hard_ButtonClick(object sender, EventArgs e)
        {
            backGround_pictureBox.Image = global::PlaneTrial.Properties.Resources.blood_sky;
        }
        private void pause_ButtonClick(object sender, EventArgs e) {

            Mp3Player.stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int move_increment = 8;
            spaceShipPosition_X = spaceShip_pictureBox.Location.X;
            spaceShipPosition_Y = spaceShip_pictureBox.Location.Y;

            int lassersShipPosition_X = spaceShipPosition_X + 43;
            int lassersShipPosition_Y = spaceShipPosition_Y - 50;

            switch (e.KeyCode)
            {
                case Keys.Right: spaceShipPosition_X += move_increment; break;
                case Keys.Left:  spaceShipPosition_X -= move_increment; break;
                case Keys.Up:    spaceShipPosition_Y -= move_increment; break;
                case Keys.Down:  spaceShipPosition_Y += move_increment; break;
                case Keys.Space: twoLassers_pictureBox.Visible = true;  break;
                default: Debug.WriteLine("Key not useful"); break;
            }

            Debug.WriteLine("key pressed: " + e.KeyCode + " | type: " + e.KeyCode.GetType());
            spaceShip_pictureBox.Location = new System.Drawing.Point(spaceShipPosition_X, spaceShipPosition_Y);
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
