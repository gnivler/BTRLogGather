namespace BTRLogGather
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gatherButton = new System.Windows.Forms.Button();
            this.showOutputButton = new System.Windows.Forms.Button();
            this.playGameButton = new System.Windows.Forms.Button();
            this.detailedLogsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // gatherButton
            // 
            this.gatherButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gatherButton.Location = new System.Drawing.Point(12, 12);
            this.gatherButton.Name = "gatherButton";
            this.gatherButton.Size = new System.Drawing.Size(131, 28);
            this.gatherButton.TabIndex = 0;
            this.gatherButton.Text = "Gather Logs";
            this.gatherButton.UseVisualStyleBackColor = true;
            this.gatherButton.Click += new System.EventHandler(this.Gather_Click);
            // 
            // showOutputButton
            // 
            this.showOutputButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.showOutputButton.Location = new System.Drawing.Point(282, 12);
            this.showOutputButton.Name = "showOutputButton";
            this.showOutputButton.Size = new System.Drawing.Size(78, 28);
            this.showOutputButton.TabIndex = 2;
            this.showOutputButton.Text = "Show Logs";
            this.showOutputButton.UseVisualStyleBackColor = true;
            this.showOutputButton.Click += new System.EventHandler(this.Show_Click);
            // 
            // playGameButton
            // 
            this.playGameButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.playGameButton.Location = new System.Drawing.Point(12, 46);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(348, 28);
            this.playGameButton.TabIndex = 3;
            this.playGameButton.Text = "Play BattleTech";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.Play_Click);
            // 
            // detailedLogsCheckBox
            // 
            this.detailedLogsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.detailedLogsCheckBox.Checked = true;
            this.detailedLogsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailedLogsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.detailedLogsCheckBox.Location = new System.Drawing.Point(149, 16);
            this.detailedLogsCheckBox.Name = "detailedLogsCheckBox";
            this.detailedLogsCheckBox.Size = new System.Drawing.Size(118, 22);
            this.detailedLogsCheckBox.TabIndex = 4;
            this.detailedLogsCheckBox.Text = "Detailed logs";
            this.detailedLogsCheckBox.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(781, 383);
            this.Controls.Add(this.detailedLogsCheckBox);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.showOutputButton);
            this.Controls.Add(this.gatherButton);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(388, 126);
            this.Name = "Main";
            this.Text = "BTRLogGather 1.0.2";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox detailedLogsCheckBox;
        private System.Windows.Forms.Button gatherButton;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button showOutputButton;

        #endregion
    }
}
