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

        public Form1() {

            InitializeComponent();

            backGround_pictureBox.Controls.Add(spaceShip_pictureBox);
            backGround_pictureBox.Controls.Add(rocket1_pictureBox);
            backGround_pictureBox.Controls.Add(rocket2_pictureBox);
            backGround_pictureBox.Controls.Add(rocket3_pictureBox);
            backGround_pictureBox.Controls.Add(leftShip_pictureBox);
            backGround_pictureBox.Controls.Add(rightShip_pictureBox);
            backGround_pictureBox.Controls.Add(darkShip1_pictureBox);
            backGround_pictureBox.Controls.Add(darkShip2_pictureBox);

            Mp3Player.open_file(soundtrack_file);
        }

        private void start_ButtonClick(object sender, EventArgs e) {

            Mp3Player.play();
        }

        private void easy_ButtonClick(object sender, EventArgs e)
        {
            backGround_pictureBox.Image = global::PlaneTrial.Properties.Resources.blue_sky;
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
