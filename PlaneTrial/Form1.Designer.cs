
namespace PlaneTrial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.start_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.level_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.easy_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.normal_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.hard_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.instructions_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.pause_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_Button,
            this.level_Button,
            this.instructions_Button,
            this.pause_Button,
            this.exit_Button});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // start_Button
            // 
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(54, 24);
            this.start_Button.Text = "Start";
            this.start_Button.Click += new System.EventHandler(this.start_ButtonClick);
            // 
            // level_Button
            // 
            this.level_Button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easy_Button,
            this.normal_Button,
            this.hard_Button});
            this.level_Button.Name = "level_Button";
            this.level_Button.Size = new System.Drawing.Size(57, 24);
            this.level_Button.Text = "Level";
            // 
            // easy_Button
            // 
            this.easy_Button.Name = "easy_Button";
            this.easy_Button.Size = new System.Drawing.Size(142, 26);
            this.easy_Button.Text = "Easy";
            this.easy_Button.Click += new System.EventHandler(this.easy_ButtonClick);
            // 
            // normal_Button
            // 
            this.normal_Button.Name = "normal_Button";
            this.normal_Button.Size = new System.Drawing.Size(142, 26);
            this.normal_Button.Text = "Normal";
            this.normal_Button.Click += new System.EventHandler(this.normal_ButtonClick);
            // 
            // hard_Button
            // 
            this.hard_Button.Name = "hard_Button";
            this.hard_Button.Size = new System.Drawing.Size(142, 26);
            this.hard_Button.Text = "Hard";
            this.hard_Button.Click += new System.EventHandler(this.hard_ButtonClick);
            // 
            // instructions_Button
            // 
            this.instructions_Button.Name = "instructions_Button";
            this.instructions_Button.Size = new System.Drawing.Size(98, 24);
            this.instructions_Button.Text = "Instructions";
            // 
            // pause_Button
            // 
            this.pause_Button.Name = "pause_Button";
            this.pause_Button.Size = new System.Drawing.Size(60, 24);
            this.pause_Button.Text = "Pause";
            this.pause_Button.Click += new System.EventHandler(this.pause_ButtonClick);
            // 
            // exit_Button
            // 
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(47, 24);
            this.exit_Button.Text = "Exit";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PlaneTrial.Properties.Resources.intro_sky;
            this.pictureBox.Location = new System.Drawing.Point(12, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(776, 481);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem start_Button;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem level_Button;
        private System.Windows.Forms.ToolStripMenuItem instructions_Button;
        private System.Windows.Forms.ToolStripMenuItem pause_Button;
        private System.Windows.Forms.ToolStripMenuItem exit_Button;
        private System.Windows.Forms.ToolStripMenuItem easy_Button;
        private System.Windows.Forms.ToolStripMenuItem normal_Button;
        private System.Windows.Forms.ToolStripMenuItem hard_Button;
    }
}

