using System.ComponentModel;

namespace Tic_tac_game
{
    partial class BoardMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.select_char = new System.Windows.Forms.Label();
            this.null_char = new System.Windows.Forms.Button();
            this.cross_char = new System.Windows.Forms.Button();
            this.select_board = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_1 = new System.Windows.Forms.RadioButton();
            this.radio_2 = new System.Windows.Forms.RadioButton();
            this.radio_3 = new System.Windows.Forms.RadioButton();
            this.begin_game = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select_char
            // 
            this.select_char.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_char.Location = new System.Drawing.Point(70, 41);
            this.select_char.Name = "select_char";
            this.select_char.Size = new System.Drawing.Size(212, 54);
            this.select_char.TabIndex = 0;
            this.select_char.Text = "Select Character";
            this.select_char.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // null_char
            // 
            this.null_char.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.null_char.Location = new System.Drawing.Point(70, 98);
            this.null_char.Name = "null_char";
            this.null_char.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.null_char.Size = new System.Drawing.Size(133, 128);
            this.null_char.TabIndex = 1;
            this.null_char.Text = "O";
            this.null_char.UseVisualStyleBackColor = true;
            this.null_char.Click += new System.EventHandler(this.null_char_Click);
            // 
            // cross_char
            // 
            this.cross_char.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross_char.Location = new System.Drawing.Point(269, 98);
            this.cross_char.Name = "cross_char";
            this.cross_char.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cross_char.Size = new System.Drawing.Size(138, 128);
            this.cross_char.TabIndex = 2;
            this.cross_char.Text = "X";
            this.cross_char.UseVisualStyleBackColor = true;
            this.cross_char.Click += new System.EventHandler(this.cross_char_Click);
            // 
            // select_board
            // 
            this.select_board.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_board.Location = new System.Drawing.Point(70, 248);
            this.select_board.Name = "select_board";
            this.select_board.Size = new System.Drawing.Size(212, 40);
            this.select_board.TabIndex = 3;
            this.select_board.Text = "Select Table";
            this.select_board.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(70, 314);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 25);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "3x3";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(211, 314);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 25);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "4x4";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(352, 314);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 25);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(70, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radio_1
            // 
            this.radio_1.Location = new System.Drawing.Point(70, 317);
            this.radio_1.Name = "radio_1";
            this.radio_1.Size = new System.Drawing.Size(113, 33);
            this.radio_1.TabIndex = 4;
            this.radio_1.TabStop = true;
            this.radio_1.Text = "3x3";
            this.radio_1.UseVisualStyleBackColor = true;
            this.radio_1.CheckedChanged += new System.EventHandler(this.radio_1_CheckedChanged);
            // 
            // radio_2
            // 
            this.radio_2.Location = new System.Drawing.Point(212, 321);
            this.radio_2.Name = "radio_2";
            this.radio_2.Size = new System.Drawing.Size(59, 24);
            this.radio_2.TabIndex = 5;
            this.radio_2.TabStop = true;
            this.radio_2.Text = "4x4";
            this.radio_2.UseVisualStyleBackColor = true;
            this.radio_2.CheckedChanged += new System.EventHandler(this.radio_2_CheckedChanged);
            // 
            // radio_3
            // 
            this.radio_3.Location = new System.Drawing.Point(352, 323);
            this.radio_3.Name = "radio_3";
            this.radio_3.Size = new System.Drawing.Size(70, 21);
            this.radio_3.TabIndex = 6;
            this.radio_3.TabStop = true;
            this.radio_3.Text = "5x5";
            this.radio_3.UseVisualStyleBackColor = true;
            this.radio_3.CheckedChanged += new System.EventHandler(this.radio_3_CheckedChanged);
            // 
            // begin_game
            // 
            this.begin_game.Location = new System.Drawing.Point(70, 384);
            this.begin_game.Name = "begin_game";
            this.begin_game.Size = new System.Drawing.Size(336, 58);
            this.begin_game.TabIndex = 7;
            this.begin_game.Text = "Begin Game";
            this.begin_game.UseVisualStyleBackColor = true;
            this.begin_game.Click += new System.EventHandler(this.begin_game_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(69, 459);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(337, 58);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // BoardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 578);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.begin_game);
            this.Controls.Add(this.radio_3);
            this.Controls.Add(this.radio_2);
            this.Controls.Add(this.radio_1);
            this.Controls.Add(this.select_board);
            this.Controls.Add(this.cross_char);
            this.Controls.Add(this.null_char);
            this.Controls.Add(this.select_char);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "BoardMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button begin_game;
        private System.Windows.Forms.Button back_button;

        private System.Windows.Forms.RadioButton radio_1;
        private System.Windows.Forms.RadioButton radio_2;
        private System.Windows.Forms.RadioButton radio_3;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label select_board;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;

        private System.Windows.Forms.Button null_char;
        private System.Windows.Forms.Button cross_char;

        private System.Windows.Forms.Label select_char;

        #endregion
    }
}