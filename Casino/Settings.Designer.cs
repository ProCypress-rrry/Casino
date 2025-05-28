namespace Casino
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            volumeMeter1 = new NAudio.Gui.VolumeMeter();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // volumeMeter1
            // 
            volumeMeter1.Amplitude = 0F;
            volumeMeter1.Location = new Point(36, 34);
            volumeMeter1.MaxDb = 18F;
            volumeMeter1.MinDb = -60F;
            volumeMeter1.Name = "volumeMeter1";
            volumeMeter1.Size = new Size(207, 34);
            volumeMeter1.TabIndex = 0;
            volumeMeter1.Text = "volumeMeter1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 95);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 1;
            label1.Text = "Volume:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 95);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(572, 12);
            button1.Name = "button1";
            button1.Size = new Size(216, 63);
            button1.TabIndex = 3;
            button1.Text = "Go back to Main menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(volumeMeter1);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}