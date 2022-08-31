
namespace yoketoruvs22
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
            this.components = new System.ComponentModel.Container();
            this.titlelabel = new System.Windows.Forms.Label();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.leftlabel = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.clearlabel = new System.Windows.Forms.Label();
            this.titlebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TempLabel = new System.Windows.Forms.Label();
            this.Keylabel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hantei = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.titlelabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.titlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.titlelabel.Location = new System.Drawing.Point(154, 75);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(310, 71);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "よけとる2022";
            // 
            // copyrightlabel
            // 
            this.copyrightlabel.AutoSize = true;
            this.copyrightlabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyrightlabel.Location = new System.Drawing.Point(184, 413);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(257, 28);
            this.copyrightlabel.TabIndex = 2;
            this.copyrightlabel.Text = "Copyright © 2022 大嶋柊哉";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timelabel.Location = new System.Drawing.Point(12, 9);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(93, 28);
            this.timelabel.TabIndex = 3;
            this.timelabel.Text = "TIME 100";
            // 
            // leftlabel
            // 
            this.leftlabel.AutoSize = true;
            this.leftlabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftlabel.Location = new System.Drawing.Point(518, 9);
            this.leftlabel.Name = "leftlabel";
            this.leftlabel.Size = new System.Drawing.Size(94, 28);
            this.leftlabel.TabIndex = 4;
            this.leftlabel.Text = "★の数:10";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Location = new System.Drawing.Point(239, 185);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(119, 28);
            this.scorelabel.TabIndex = 5;
            this.scorelabel.Text = "HighScore 0";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(218, 289);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(177, 68);
            this.startbutton.TabIndex = 6;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.AutoSize = true;
            this.gameoverlabel.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameoverlabel.ForeColor = System.Drawing.Color.Navy;
            this.gameoverlabel.Location = new System.Drawing.Point(119, 175);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(415, 89);
            this.gameoverlabel.TabIndex = 7;
            this.gameoverlabel.Text = "GAME OVER";
            // 
            // clearlabel
            // 
            this.clearlabel.AutoSize = true;
            this.clearlabel.BackColor = System.Drawing.Color.Transparent;
            this.clearlabel.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearlabel.ForeColor = System.Drawing.Color.Red;
            this.clearlabel.Location = new System.Drawing.Point(175, 75);
            this.clearlabel.Name = "clearlabel";
            this.clearlabel.Size = new System.Drawing.Size(275, 89);
            this.clearlabel.TabIndex = 8;
            this.clearlabel.Text = "CLEAR!!";
            // 
            // titlebutton
            // 
            this.titlebutton.Location = new System.Drawing.Point(218, 289);
            this.titlebutton.Name = "titlebutton";
            this.titlebutton.Size = new System.Drawing.Size(179, 68);
            this.titlebutton.TabIndex = 9;
            this.titlebutton.Text = "タイトルへ";
            this.titlebutton.UseVisualStyleBackColor = true;
            this.titlebutton.Click += new System.EventHandler(this.titlebutton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.BackColor = System.Drawing.Color.Transparent;
            this.TempLabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TempLabel.Location = new System.Drawing.Point(64, 114);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(44, 37);
            this.TempLabel.TabIndex = 10;
            this.TempLabel.Text = "★";
            this.TempLabel.Visible = false;
            // 
            // Keylabel
            // 
            this.Keylabel.AutoSize = true;
            this.Keylabel.Location = new System.Drawing.Point(445, 369);
            this.Keylabel.Name = "Keylabel";
            this.Keylabel.Size = new System.Drawing.Size(167, 32);
            this.Keylabel.TabIndex = 11;
            this.Keylabel.Text = "キー操作(WASD)";
            this.Keylabel.UseVisualStyleBackColor = true;
            this.Keylabel.CheckedChanged += new System.EventHandler(this.Keylabel_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "プレイ時Escapeでタイトルに戻ります";
            // 
            // hantei
            // 
            this.hantei.AutoSize = true;
            this.hantei.BackColor = System.Drawing.Color.Transparent;
            this.hantei.Location = new System.Drawing.Point(109, 369);
            this.hantei.Name = "hantei";
            this.hantei.Size = new System.Drawing.Size(22, 28);
            this.hantei.TabIndex = 13;
            this.hantei.Text = "・";
            this.hantei.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Keylabel);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.titlebutton);
            this.Controls.Add(this.clearlabel);
            this.Controls.Add(this.gameoverlabel);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.leftlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.hantei);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "よけとる2022";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label copyrightlabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label leftlabel;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.Label clearlabel;
        private System.Windows.Forms.Button titlebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.CheckBox Keylabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hantei;
    }
}

