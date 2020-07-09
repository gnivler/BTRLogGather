namespace BTRLogGather
{
    partial class Form1
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
            this.Gather = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.Gather.Location = new System.Drawing.Point(12, 12);
            this.Gather.Name = "Gather";
            this.Gather.Size = new System.Drawing.Size(169, 28);
            this.Gather.TabIndex = 0;
            this.Gather.Text = "Gather";
            this.Gather.UseVisualStyleBackColor = true;
            this.Gather.Click += new System.EventHandler(this.Gather_Click);
            this.Show.Location = new System.Drawing.Point(191, 12);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(169, 28);
            this.Show.TabIndex = 0;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            this.Play.Location = new System.Drawing.Point(12, 46);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(348, 28);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 87);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Gather);
            this.Name = "Form1";
            this.Text = "BTRLogGather 1.0";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Gather;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Show;

        #endregion
    }
}
