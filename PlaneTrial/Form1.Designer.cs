﻿
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
            this.backGround_pictureBox = new System.Windows.Forms.PictureBox();
            this.spaceShip_pictureBox = new System.Windows.Forms.PictureBox();
            this.rocket1_pictureBox = new System.Windows.Forms.PictureBox();
            this.rocket2_pictureBox = new System.Windows.Forms.PictureBox();
            this.rocket3_pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backGround_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceShip_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket1_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket3_pictureBox)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(839, 28);
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
            // backGround_pictureBox
            // 
            this.backGround_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.backGround_pictureBox.Image = global::PlaneTrial.Properties.Resources.intro_sky;
            this.backGround_pictureBox.Location = new System.Drawing.Point(12, 31);
            this.backGround_pictureBox.Name = "backGround_pictureBox";
            this.backGround_pictureBox.Size = new System.Drawing.Size(815, 546);
            this.backGround_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backGround_pictureBox.TabIndex = 1;
            this.backGround_pictureBox.TabStop = false;
            this.backGround_pictureBox.Click += new System.EventHandler(this.backGround_pictureBox_Click);
            // 
            // spaceShip_pictureBox
            // 
            this.spaceShip_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.spaceShip_pictureBox.Image = global::PlaneTrial.Properties.Resources.Tynker_SpaceShip;
            this.spaceShip_pictureBox.Location = new System.Drawing.Point(379, 396);
            this.spaceShip_pictureBox.Name = "spaceShip_pictureBox";
            this.spaceShip_pictureBox.Size = new System.Drawing.Size(121, 81);
            this.spaceShip_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceShip_pictureBox.TabIndex = 2;
            this.spaceShip_pictureBox.TabStop = false;
            // 
            // rocket1_pictureBox
            // 
            this.rocket1_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.rocket1_pictureBox.Image = global::PlaneTrial.Properties.Resources.rocket;
            this.rocket1_pictureBox.Location = new System.Drawing.Point(334, 31);
            this.rocket1_pictureBox.Name = "rocket1_pictureBox";
            this.rocket1_pictureBox.Size = new System.Drawing.Size(42, 121);
            this.rocket1_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket1_pictureBox.TabIndex = 3;
            this.rocket1_pictureBox.TabStop = false;
            // 
            // rocket2_pictureBox
            // 
            this.rocket2_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.rocket2_pictureBox.Image = global::PlaneTrial.Properties.Resources.rocket;
            this.rocket2_pictureBox.Location = new System.Drawing.Point(395, 31);
            this.rocket2_pictureBox.Name = "rocket2_pictureBox";
            this.rocket2_pictureBox.Size = new System.Drawing.Size(42, 121);
            this.rocket2_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket2_pictureBox.TabIndex = 4;
            this.rocket2_pictureBox.TabStop = false;
            this.rocket2_pictureBox.Click += new System.EventHandler(this.rocket2_pictureBox_Click);
            // 
            // rocket3_pictureBox
            // 
            this.rocket3_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.rocket3_pictureBox.Image = global::PlaneTrial.Properties.Resources.rocket;
            this.rocket3_pictureBox.Location = new System.Drawing.Point(458, 31);
            this.rocket3_pictureBox.Name = "rocket3_pictureBox";
            this.rocket3_pictureBox.Size = new System.Drawing.Size(42, 121);
            this.rocket3_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket3_pictureBox.TabIndex = 5;
            this.rocket3_pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 589);
            this.Controls.Add(this.rocket3_pictureBox);
            this.Controls.Add(this.rocket2_pictureBox);
            this.Controls.Add(this.rocket1_pictureBox);
            this.Controls.Add(this.spaceShip_pictureBox);
            this.Controls.Add(this.backGround_pictureBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backGround_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceShip_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket1_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket3_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem start_Button;
        private System.Windows.Forms.PictureBox backGround_pictureBox;
        private System.Windows.Forms.ToolStripMenuItem level_Button;
        private System.Windows.Forms.ToolStripMenuItem instructions_Button;
        private System.Windows.Forms.ToolStripMenuItem pause_Button;
        private System.Windows.Forms.ToolStripMenuItem exit_Button;
        private System.Windows.Forms.ToolStripMenuItem easy_Button;
        private System.Windows.Forms.ToolStripMenuItem normal_Button;
        private System.Windows.Forms.ToolStripMenuItem hard_Button;
        private System.Windows.Forms.PictureBox spaceShip_pictureBox;
        private System.Windows.Forms.PictureBox rocket1_pictureBox;
        private System.Windows.Forms.PictureBox rocket2_pictureBox;
        private System.Windows.Forms.PictureBox rocket3_pictureBox;
    }
}

