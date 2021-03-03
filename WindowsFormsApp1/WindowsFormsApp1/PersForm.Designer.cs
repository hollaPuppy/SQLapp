
namespace WindowsFormsApp1
{
    partial class PersFrom
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОВыручкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОПроданныхБилетахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_Fam = new System.Windows.Forms.Label();
            this.Label_21124 = new System.Windows.Forms.Label();
            this.Label_321 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_Num = new System.Windows.Forms.Label();
            this.label_oklad = new System.Windows.Forms.Label();
            this.label_FIO = new System.Windows.Forms.Label();
            this.label_Dolj = new System.Windows.Forms.Label();
            this.label_Kino = new System.Windows.Forms.Label();
            this.label_Gor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.завершитьРаботуToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // завершитьРаботуToolStripMenuItem
            // 
            this.завершитьРаботуToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.завершитьРаботуToolStripMenuItem.Name = "завершитьРаботуToolStripMenuItem";
            this.завершитьРаботуToolStripMenuItem.Size = new System.Drawing.Size(151, 23);
            this.завершитьРаботуToolStripMenuItem.Text = "Завершить работу";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетОВыручкеToolStripMenuItem,
            this.отчетОПроданныхБилетахToolStripMenuItem});
            this.отчетыToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            this.отчетыToolStripMenuItem.Visible = false;
            // 
            // отчетОВыручкеToolStripMenuItem
            // 
            this.отчетОВыручкеToolStripMenuItem.Name = "отчетОВыручкеToolStripMenuItem";
            this.отчетОВыручкеToolStripMenuItem.Size = new System.Drawing.Size(281, 24);
            this.отчетОВыручкеToolStripMenuItem.Text = "Отчет о выручке";
            // 
            // отчетОПроданныхБилетахToolStripMenuItem
            // 
            this.отчетОПроданныхБилетахToolStripMenuItem.Name = "отчетОПроданныхБилетахToolStripMenuItem";
            this.отчетОПроданныхБилетахToolStripMenuItem.Size = new System.Drawing.Size(281, 24);
            this.отчетОПроданныхБилетахToolStripMenuItem.Text = "Отчет о проданных билетах";
            // 
            // Label_Fam
            // 
            this.Label_Fam.AutoSize = true;
            this.Label_Fam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Fam.Location = new System.Drawing.Point(13, 83);
            this.Label_Fam.Name = "Label_Fam";
            this.Label_Fam.Size = new System.Drawing.Size(52, 19);
            this.Label_Fam.TabIndex = 4;
            this.Label_Fam.Text = "ФИО:";
            // 
            // Label_21124
            // 
            this.Label_21124.AutoSize = true;
            this.Label_21124.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_21124.Location = new System.Drawing.Point(13, 121);
            this.Label_21124.Name = "Label_21124";
            this.Label_21124.Size = new System.Drawing.Size(92, 19);
            this.Label_21124.TabIndex = 6;
            this.Label_21124.Text = "Кинотеатр:";
            // 
            // Label_321
            // 
            this.Label_321.AutoSize = true;
            this.Label_321.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_321.Location = new System.Drawing.Point(13, 140);
            this.Label_321.Name = "Label_321";
            this.Label_321.Size = new System.Drawing.Size(94, 19);
            this.Label_321.TabIndex = 7;
            this.Label_321.Text = "Должность:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Паспорт работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Город:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Оклад:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Номер телефона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Эл. Почта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Паспортные данные";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pass.Location = new System.Drawing.Point(177, 216);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(17, 19);
            this.label_pass.TabIndex = 14;
            this.label_pass.Text = "*";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mail.Location = new System.Drawing.Point(177, 197);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(17, 19);
            this.label_mail.TabIndex = 15;
            this.label_mail.Text = "*";
            // 
            // label_Num
            // 
            this.label_Num.AutoSize = true;
            this.label_Num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Num.Location = new System.Drawing.Point(177, 178);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(17, 19);
            this.label_Num.TabIndex = 16;
            this.label_Num.Text = "*";
            // 
            // label_oklad
            // 
            this.label_oklad.AutoSize = true;
            this.label_oklad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_oklad.Location = new System.Drawing.Point(177, 159);
            this.label_oklad.Name = "label_oklad";
            this.label_oklad.Size = new System.Drawing.Size(17, 19);
            this.label_oklad.TabIndex = 17;
            this.label_oklad.Text = "*";
            // 
            // label_FIO
            // 
            this.label_FIO.AutoSize = true;
            this.label_FIO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FIO.Location = new System.Drawing.Point(177, 83);
            this.label_FIO.Name = "label_FIO";
            this.label_FIO.Size = new System.Drawing.Size(17, 19);
            this.label_FIO.TabIndex = 18;
            this.label_FIO.Text = "*";
            // 
            // label_Dolj
            // 
            this.label_Dolj.AutoSize = true;
            this.label_Dolj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Dolj.Location = new System.Drawing.Point(177, 140);
            this.label_Dolj.Name = "label_Dolj";
            this.label_Dolj.Size = new System.Drawing.Size(17, 19);
            this.label_Dolj.TabIndex = 19;
            this.label_Dolj.Text = "*";
            // 
            // label_Kino
            // 
            this.label_Kino.AutoSize = true;
            this.label_Kino.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Kino.Location = new System.Drawing.Point(177, 121);
            this.label_Kino.Name = "label_Kino";
            this.label_Kino.Size = new System.Drawing.Size(17, 19);
            this.label_Kino.TabIndex = 20;
            this.label_Kino.Text = "*";
            // 
            // label_Gor
            // 
            this.label_Gor.AutoSize = true;
            this.label_Gor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Gor.Location = new System.Drawing.Point(177, 102);
            this.label_Gor.Name = "label_Gor";
            this.label_Gor.Size = new System.Drawing.Size(17, 19);
            this.label_Gor.TabIndex = 21;
            this.label_Gor.Text = "*";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(392, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Купить/забронировать билет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(392, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 35);
            this.button3.TabIndex = 24;
            this.button3.Text = "Добавить пользователя системы (работника)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(392, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(308, 34);
            this.button4.TabIndex = 25;
            this.button4.Text = "Добавить новый фильм";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(392, 117);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(308, 35);
            this.button6.TabIndex = 27;
            this.button6.Text = "Добавить нового покупателя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(392, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Отчет о проданных билетах";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(392, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(308, 34);
            this.button7.TabIndex = 29;
            this.button7.Text = "Отчет о выручке";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(392, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(308, 32);
            this.button5.TabIndex = 30;
            this.button5.Text = "Добавить новый сеанс";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(392, 197);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(308, 32);
            this.button8.TabIndex = 31;
            this.button8.Text = "Добавить места к сеансу";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // PersFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 360);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Gor);
            this.Controls.Add(this.label_Kino);
            this.Controls.Add(this.label_Dolj);
            this.Controls.Add(this.label_FIO);
            this.Controls.Add(this.label_oklad);
            this.Controls.Add(this.label_Num);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_321);
            this.Controls.Add(this.Label_21124);
            this.Controls.Add(this.Label_Fam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersFrom";
            this.Text = "Паспорт работника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersFrom_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem завершитьРаботуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label Label_Fam;
        private System.Windows.Forms.Label Label_21124;
        private System.Windows.Forms.Label Label_321;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_Num;
        private System.Windows.Forms.Label label_oklad;
        private System.Windows.Forms.Label label_FIO;
        private System.Windows.Forms.Label label_Dolj;
        private System.Windows.Forms.Label label_Kino;
        private System.Windows.Forms.Label label_Gor;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОВыручкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОПроданныхБилетахToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
    }
}