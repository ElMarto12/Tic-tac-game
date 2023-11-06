namespace Tic_tac_game
{
    partial class MainMenu
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
            this.main_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.quit_buttton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.main_label.Location = new System.Drawing.Point(146, 70);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(190, 48);
            this.main_label.TabIndex = 0;
            this.main_label.Text = "Tic-Tac Game";
            this.main_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(120, 159);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(260, 79);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start Game";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // quit_buttton
            // 
            this.quit_buttton.Location = new System.Drawing.Point(118, 290);
            this.quit_buttton.Name = "quit_buttton";
            this.quit_buttton.Size = new System.Drawing.Size(261, 79);
            this.quit_buttton.TabIndex = 2;
            this.quit_buttton.Text = "Quit";
            this.quit_buttton.UseVisualStyleBackColor = true;
            this.quit_buttton.Click += new System.EventHandler(this.quit_buttton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 466);
            this.Controls.Add(this.quit_buttton);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.main_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button quit_buttton;

        private System.Windows.Forms.Label main_label;

        #endregion
    }
}