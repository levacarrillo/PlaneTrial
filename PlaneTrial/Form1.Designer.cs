
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
            this.start = new System.Windows.Forms.ToolStripMenuItem();
            this.difficult = new System.Windows.Forms.ToolStripMenuItem();
            this.easy = new System.Windows.Forms.ToolStripMenuItem();
            this.middle = new System.Windows.Forms.ToolStripMenuItem();
            this.hard = new System.Windows.Forms.ToolStripMenuItem();
            this.instructions = new System.Windows.Forms.ToolStripMenuItem();
            this.pause = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start,
            this.difficult,
            this.instructions,
            this.pause,
            this.exit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // start
            // 
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(54, 24);
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.start_ButtonClick);
            // 
            // difficult
            // 
            this.difficult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easy,
            this.middle,
            this.hard});
            this.difficult.Name = "difficult";
            this.difficult.Size = new System.Drawing.Size(76, 24);
            this.difficult.Text = "Difficult";
            // 
            // easy
            // 
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(139, 26);
            this.easy.Text = "Easy";
            // 
            // middle
            // 
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(139, 26);
            this.middle.Text = "Middle";
            // 
            // hard
            // 
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(139, 26);
            this.hard.Text = "Hard";
            // 
            // instructions
            // 
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(98, 24);
            this.instructions.Text = "Instructions";
            // 
            // pause
            // 
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(60, 24);
            this.pause.Text = "Pause";
            this.pause.Click += new System.EventHandler(this.pause_ButtonClick);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(47, 24);
            this.exit.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem start;
        private System.Windows.Forms.ToolStripMenuItem difficult;
        private System.Windows.Forms.ToolStripMenuItem instructions;
        private System.Windows.Forms.ToolStripMenuItem pause;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem easy;
        private System.Windows.Forms.ToolStripMenuItem middle;
        private System.Windows.Forms.ToolStripMenuItem hard;
    }
}

