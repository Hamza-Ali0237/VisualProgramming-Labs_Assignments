using System.Media;

namespace PuzzleGame
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
        Random rnd = new Random();

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPic = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(-1, -1);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(122, 100);
            this.btnPic.TabIndex = 0;
            this.btnPic.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(-1, 117);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(122, 102);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(127, 117);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(122, 102);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn3
            // 
            this.btn3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(255, 117);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(122, 102);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(383, 117);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(122, 102);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(-1, 225);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(122, 102);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(127, 225);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(122, 102);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(255, 225);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(122, 102);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(383, 225);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(122, 102);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(-1, 333);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(122, 102);
            this.btn9.TabIndex = 9;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(127, 333);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(122, 102);
            this.btn10.TabIndex = 10;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(255, 333);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(122, 102);
            this.btn11.TabIndex = 11;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(383, 333);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(122, 102);
            this.btn12.TabIndex = 12;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(-1, 441);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(122, 102);
            this.btn13.TabIndex = 13;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn14
            // 
            this.btn14.Location = new System.Drawing.Point(127, 441);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(122, 102);
            this.btn14.TabIndex = 14;
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(255, 441);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(122, 102);
            this.btn15.TabIndex = 15;
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // btn16
            // 
            this.btn16.Location = new System.Drawing.Point(383, 441);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(122, 102);
            this.btn16.TabIndex = 16;
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Click += new System.EventHandler(this.btnEvery_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(127, -1);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(378, 100);
            this.button18.TabIndex = 17;
            this.button18.Text = "GUESS PICTURE THREE TIMES FROM PUZZLE\r\n(Attempts Allowed) = 3)\r\n";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(506, 550);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btn16);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn14);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnPic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPic;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn13;
        private Button btn14;
        private Button btn15;
        private Button btn16;
        private Button button18;
    }
}