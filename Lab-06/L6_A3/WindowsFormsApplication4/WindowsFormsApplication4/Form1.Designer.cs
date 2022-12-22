namespace WindowsFormsApplication4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Large = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Small = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Onions = new System.Windows.Forms.CheckBox();
            this.Tomatoes = new System.Windows.Forms.CheckBox();
            this.Mushroom = new System.Windows.Forms.CheckBox();
            this.ExtraCheese = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Thick = new System.Windows.Forms.RadioButton();
            this.Thin = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EatOut = new System.Windows.Forms.RadioButton();
            this.EatIn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Build pizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Large);
            this.groupBox1.Controls.Add(this.Medium);
            this.groupBox1.Controls.Add(this.Small);
            this.groupBox1.Location = new System.Drawing.Point(9, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 228);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Large
            // 
            this.Large.AutoSize = true;
            this.Large.Location = new System.Drawing.Point(21, 138);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(52, 17);
            this.Large.TabIndex = 6;
            this.Large.TabStop = true;
            this.Large.Text = "Large";
            this.Large.UseVisualStyleBackColor = true;
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(21, 89);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(62, 17);
            this.Medium.TabIndex = 5;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            // 
            // Small
            // 
            this.Small.AutoSize = true;
            this.Small.Location = new System.Drawing.Point(21, 49);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(50, 17);
            this.Small.TabIndex = 4;
            this.Small.TabStop = true;
            this.Small.Text = "Small";
            this.Small.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Onions);
            this.groupBox2.Controls.Add(this.Tomatoes);
            this.groupBox2.Controls.Add(this.Mushroom);
            this.groupBox2.Controls.Add(this.ExtraCheese);
            this.groupBox2.Location = new System.Drawing.Point(375, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 228);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Onions
            // 
            this.Onions.AutoSize = true;
            this.Onions.Location = new System.Drawing.Point(20, 182);
            this.Onions.Name = "Onions";
            this.Onions.Size = new System.Drawing.Size(59, 17);
            this.Onions.TabIndex = 12;
            this.Onions.Text = "Onions";
            this.Onions.UseVisualStyleBackColor = true;
            // 
            // Tomatoes
            // 
            this.Tomatoes.AutoSize = true;
            this.Tomatoes.Location = new System.Drawing.Point(20, 139);
            this.Tomatoes.Name = "Tomatoes";
            this.Tomatoes.Size = new System.Drawing.Size(73, 17);
            this.Tomatoes.TabIndex = 11;
            this.Tomatoes.Text = "Tomatoes";
            this.Tomatoes.UseVisualStyleBackColor = true;
            // 
            // Mushroom
            // 
            this.Mushroom.AutoSize = true;
            this.Mushroom.Location = new System.Drawing.Point(20, 89);
            this.Mushroom.Name = "Mushroom";
            this.Mushroom.Size = new System.Drawing.Size(75, 17);
            this.Mushroom.TabIndex = 10;
            this.Mushroom.Text = "Mushroom";
            this.Mushroom.UseVisualStyleBackColor = true;
            // 
            // ExtraCheese
            // 
            this.ExtraCheese.AutoSize = true;
            this.ExtraCheese.Location = new System.Drawing.Point(20, 49);
            this.ExtraCheese.Name = "ExtraCheese";
            this.ExtraCheese.Size = new System.Drawing.Size(87, 17);
            this.ExtraCheese.TabIndex = 9;
            this.ExtraCheese.Text = "Extra chesse";
            this.ExtraCheese.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Thick);
            this.groupBox3.Controls.Add(this.Thin);
            this.groupBox3.Location = new System.Drawing.Point(53, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crust Type";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Thick
            // 
            this.Thick.AutoSize = true;
            this.Thick.Location = new System.Drawing.Point(110, 42);
            this.Thick.Name = "Thick";
            this.Thick.Size = new System.Drawing.Size(76, 17);
            this.Thick.TabIndex = 13;
            this.Thick.TabStop = true;
            this.Thick.Text = "ThickType";
            this.Thick.UseVisualStyleBackColor = true;
            // 
            // Thin
            // 
            this.Thin.AutoSize = true;
            this.Thin.Location = new System.Drawing.Point(15, 42);
            this.Thin.Name = "Thin";
            this.Thin.Size = new System.Drawing.Size(73, 17);
            this.Thin.TabIndex = 12;
            this.Thin.TabStop = true;
            this.Thin.Text = "Thin Type";
            this.Thin.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EatOut);
            this.groupBox4.Controls.Add(this.EatIn);
            this.groupBox4.Location = new System.Drawing.Point(347, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Service";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // EatOut
            // 
            this.EatOut.AutoSize = true;
            this.EatOut.Location = new System.Drawing.Point(110, 42);
            this.EatOut.Name = "EatOut";
            this.EatOut.Size = new System.Drawing.Size(61, 17);
            this.EatOut.TabIndex = 15;
            this.EatOut.TabStop = true;
            this.EatOut.Text = "Eat Out";
            this.EatOut.UseVisualStyleBackColor = true;
            // 
            // EatIn
            // 
            this.EatIn.AutoSize = true;
            this.EatIn.Location = new System.Drawing.Point(29, 42);
            this.EatIn.Name = "EatIn";
            this.EatIn.Size = new System.Drawing.Size(52, 17);
            this.EatIn.TabIndex = 14;
            this.EatIn.TabStop = true;
            this.EatIn.Text = "Eat in";
            this.EatIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Select Your Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Large;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Small;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Onions;
        private System.Windows.Forms.CheckBox Tomatoes;
        private System.Windows.Forms.CheckBox Mushroom;
        private System.Windows.Forms.CheckBox ExtraCheese;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Thick;
        private System.Windows.Forms.RadioButton Thin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton EatOut;
        private System.Windows.Forms.RadioButton EatIn;

    }
}

