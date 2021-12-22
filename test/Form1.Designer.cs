namespace test
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriceOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPriceShipping = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер на поръчка";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(276, 23);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(194, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(276, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име на получател";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(276, 94);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон за връзка";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(276, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имейл за получателя";
            // 
            // txtPriceOrder
            // 
            this.txtPriceOrder.Location = new System.Drawing.Point(276, 171);
            this.txtPriceOrder.Name = "txtPriceOrder";
            this.txtPriceOrder.Size = new System.Drawing.Size(194, 20);
            this.txtPriceOrder.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(43, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Стойност на поръчката";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(276, 206);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(194, 20);
            this.txtPay.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(43, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Начин на плащане";
            // 
            // txtPriceShipping
            // 
            this.txtPriceShipping.Location = new System.Drawing.Point(276, 243);
            this.txtPriceShipping.Name = "txtPriceShipping";
            this.txtPriceShipping.Size = new System.Drawing.Size(194, 20);
            this.txtPriceShipping.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(43, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Стойност на доставката";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(276, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(390, 282);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(80, 33);
            this.btnSaveFile.TabIndex = 15;
            this.btnSaveFile.Text = "Save to file";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(510, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(678, 289);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1205, 25);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 289);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Text = "Open file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 334);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPriceShipping);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPriceOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriceOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPriceShipping;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnOpen;
    }
}

