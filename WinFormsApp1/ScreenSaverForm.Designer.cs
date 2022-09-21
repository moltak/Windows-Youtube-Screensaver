namespace WinFormsApp1
{
    partial class ScreenSaverForm
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
            this.components = new System.ComponentModel.Container();
            this.textLabel = new System.Windows.Forms.TextBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.Black;
            this.textLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLabel.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.textLabel.Location = new System.Drawing.Point(312, 198);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(159, 54);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Demo";
            this.textLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textLabel;
        private System.Windows.Forms.Timer moveTimer;
    }
}