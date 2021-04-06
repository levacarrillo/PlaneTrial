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
        private string soundtrack_path = Path.Combine( Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName,
                                                       "Fatboy_Slim_-_Acid_8000.mp3");
        public Form1() {

            InitializeComponent();

            Mp3Player.open_file(soundtrack_path);
        }

        private void start_ButtonClick(object sender, EventArgs e) {

            Mp3Player.play();
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
        public static void open_file(string File)
        {

            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
            Debug.WriteLine("Sound track path->" + File);
        }

        public static void play()
        {

            string command = "Play MediaFile";
            mciSendString(command, null, 0, 0);
            Debug.WriteLine("Playing soundtrack");
        }
        public static void stop()
        {

            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
            Debug.WriteLine("Stopping soundtrack");
        }
    }
}
