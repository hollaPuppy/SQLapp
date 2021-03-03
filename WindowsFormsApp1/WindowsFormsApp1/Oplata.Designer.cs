
namespace WindowsFormsApp1
{
    partial class Oplata
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
            this.maskedTextBox_card = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox_srok = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_cvv = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Fam = new System.Windows.Forms.Label();
            this.label_Otc = new System.Windows.Forms.Label();
            this.label_numcard = new System.Windows.Forms.Label();
            this.label_Bal = new System.Windows.Forms.Label();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox_card
            // 
            this.maskedTextBox_card.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_card.Location = new System.Drawing.Point(12, 31);
            this.maskedTextBox_card.Mask = "0000-0000-0000-0000";
            this.maskedTextBox_card.Name = "maskedTextBox_card";
            this.maskedTextBox_card.Size = new System.Drawing.Size(208, 32);
            this.maskedTextBox_card.TabIndex = 0;
            this.maskedTextBox_card.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите карту:";
            // 
            // maskedTextBox_srok
            // 
            this.maskedTextBox_srok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_srok.Location = new System.Drawing.Point(12, 88);
            this.maskedTextBox_srok.Mask = "00-00";
            this.maskedTextBox_srok.Name = "maskedTextBox_srok";
            this.maskedTextBox_srok.Size = new System.Drawing.Size(44, 26);
            this.maskedTextBox_srok.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Срок действия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(174, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "CVV:";
            // 
            // maskedTextBox_cvv
            // 
            this.maskedTextBox_cvv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_cvv.Location = new System.Drawing.Point(178, 88);
            this.maskedTextBox_cvv.Mask = "000";
            this.maskedTextBox_cvv.Name = "maskedTextBox_cvv";
            this.maskedTextBox_cvv.Size = new System.Drawing.Size(42, 26);
            this.maskedTextBox_cvv.TabIndex = 5;
            this.maskedTextBox_cvv.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 57);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите эл. почту, \r\nна которую придет\r\nуведовление об оплате:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(12, 177);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(206, 20);
            this.textBox_mail.TabIndex = 8;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(66, 219);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(0, 19);
            this.label_Name.TabIndex = 9;
            // 
            // label_Fam
            // 
            this.label_Fam.AutoSize = true;
            this.label_Fam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Fam.Location = new System.Drawing.Point(66, 238);
            this.label_Fam.Name = "label_Fam";
            this.label_Fam.Size = new System.Drawing.Size(0, 19);
            this.label_Fam.TabIndex = 11;
            // 
            // label_Otc
            // 
            this.label_Otc.AutoSize = true;
            this.label_Otc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Otc.Location = new System.Drawing.Point(66, 257);
            this.label_Otc.Name = "label_Otc";
            this.label_Otc.Size = new System.Drawing.Size(0, 19);
            this.label_Otc.TabIndex = 12;
            // 
            // label_numcard
            // 
            this.label_numcard.AutoSize = true;
            this.label_numcard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_numcard.Location = new System.Drawing.Point(116, 276);
            this.label_numcard.Name = "label_numcard";
            this.label_numcard.Size = new System.Drawing.Size(0, 19);
            this.label_numcard.TabIndex = 13;
            // 
            // label_Bal
            // 
            this.label_Bal.AutoSize = true;
            this.label_Bal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Bal.Location = new System.Drawing.Point(125, 295);
            this.label_Bal.Name = "label_Bal";
            this.label_Bal.Size = new System.Drawing.Size(0, 19);
            this.label_Bal.TabIndex = 14;
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(12, 358);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.ReadOnly = true;
            this.textBox_sum.Size = new System.Drawing.Size(100, 20);
            this.textBox_sum.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "К оплате:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Списать бонусные рубли";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Баланс карты:";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.Location = new System.Drawing.Point(8, 200);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(114, 19);
            this.label_info.TabIndex = 20;
            this.label_info.Text = "О покупателе:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "ФИО:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Номер карты:";
            // 
            // Oplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(230, 492);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.label_Bal);
            this.Controls.Add(this.label_numcard);
            this.Controls.Add(this.label_Otc);
            this.Controls.Add(this.label_Fam);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox_cvv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox_srok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox_card);
            this.Name = "Oplata";
            this.Text = "Oplata";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Oplata_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_srok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cvv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Fam;
        private System.Windows.Forms.Label label_Otc;
        private System.Windows.Forms.Label label_numcard;
        private System.Windows.Forms.Label label_Bal;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}