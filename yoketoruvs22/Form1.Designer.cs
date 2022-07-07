
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.leftlabel = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.BackColor = System.Drawing.SystemColors.Window;
            this.titlelabel.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titlelabel.Location = new System.Drawing.Point(154, 75);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(317, 72);
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
            this.leftlabel.Text = "★の数:20";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Location = new System.Drawing.Point(239, 185);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(146, 28);
            this.scorelabel.TabIndex = 5;
            this.scorelabel.Text = "High Score 100";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(244, 273);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(136, 68);
            this.startbutton.TabIndex = 6;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.leftlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.titlelabel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "★の数:20";
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
    }
}

