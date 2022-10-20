namespace WinFormsApp1
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
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.btnCalculateBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(147, 116);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(135, 32);
            this.lblUnits.TabIndex = 0;
            this.lblUnits.Text = "Enter Units:";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(271, 298);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(296, 32);
            this.lblBill.TabIndex = 1;
            this.lblBill.Text = "Here Bill Will Be Displayed";
            this.lblBill.Click += new System.EventHandler(this.lblBill_Click);
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(288, 116);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(255, 39);
            this.txtUnits.TabIndex = 2;
            // 
            // btnCalculateBill
            // 
            this.btnCalculateBill.Location = new System.Drawing.Point(309, 208);
            this.btnCalculateBill.Name = "btnCalculateBill";
            this.btnCalculateBill.Size = new System.Drawing.Size(210, 46);
            this.btnCalculateBill.TabIndex = 3;
            this.btnCalculateBill.Text = "Calculate Bill";
            this.btnCalculateBill.UseVisualStyleBackColor = true;
            this.btnCalculateBill.Click += new System.EventHandler(this.btnCalculateBill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculateBill);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.lblUnits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUnits;
        private Label lblBill;
        private TextBox txtUnits;
        private Button btnCalculateBill;
    }
}