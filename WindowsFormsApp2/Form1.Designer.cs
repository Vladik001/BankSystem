namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button6;
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountNumber2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccountNumber3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAccountNumber5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAccountNumber4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTargetAccount4 = new System.Windows.Forms.TextBox();
            this.txtAmount4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAccountNumber6 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            button6.Cursor = System.Windows.Forms.Cursors.Hand;
            button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button6.Location = new System.Drawing.Point(732, 580);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(245, 66);
            button6.TabIndex = 32;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(132, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "CОЗДАТЬ СЧЕТ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(947, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "×";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(649, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "ПОПОЛНИТЬ СЧЕТ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(132, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "СНЯТЬ СО СЧЕТА";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(649, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(245, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "ПЕРЕВЕСТИ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(132, 580);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(245, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "ИНФОРМАЦИЯ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(201, 38);
            this.txtAccountNumber.Multiline = true;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(176, 52);
            this.txtAccountNumber.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(718, 96);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(176, 51);
            this.txtAmount.TabIndex = 8;
            // 
            // txtOwner
            // 
            this.txtOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwner.Location = new System.Drawing.Point(201, 96);
            this.txtOwner.Multiline = true;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(176, 51);
            this.txtOwner.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(58, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "РЕГИСТРАЦИЯ СЧЕТА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "НОМЕР СЧЕТА:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "ИМЯ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(688, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "ПОПОЛНЕНИЕ";
            // 
            // txtAccountNumber2
            // 
            this.txtAccountNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber2.Location = new System.Drawing.Point(718, 38);
            this.txtAccountNumber2.Multiline = true;
            this.txtAccountNumber2.Name = "txtAccountNumber2";
            this.txtAccountNumber2.Size = new System.Drawing.Size(176, 52);
            this.txtAccountNumber2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "НОМЕР СЧЕТА:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "СУММА:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAccountNumber3
            // 
            this.txtAccountNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber3.Location = new System.Drawing.Point(201, 265);
            this.txtAccountNumber3.Multiline = true;
            this.txtAccountNumber3.Name = "txtAccountNumber3";
            this.txtAccountNumber3.Size = new System.Drawing.Size(176, 52);
            this.txtAccountNumber3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "СНЯТИЕ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-4, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "НОМЕР СЧЕТА:";
            // 
            // txtAmount3
            // 
            this.txtAmount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount3.Location = new System.Drawing.Point(201, 323);
            this.txtAmount3.Multiline = true;
            this.txtAmount3.Name = "txtAmount3";
            this.txtAmount3.Size = new System.Drawing.Size(176, 51);
            this.txtAmount3.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "СУММА:";
            // 
            // txtAccountNumber5
            // 
            this.txtAccountNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber5.Location = new System.Drawing.Point(201, 509);
            this.txtAccountNumber5.Multiline = true;
            this.txtAccountNumber5.Name = "txtAccountNumber5";
            this.txtAccountNumber5.Size = new System.Drawing.Size(176, 52);
            this.txtAccountNumber5.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(90, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 26);
            this.label11.TabIndex = 23;
            this.label11.Text = "ИНФОРМАЦИЯ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-4, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 26);
            this.label12.TabIndex = 24;
            this.label12.Text = "НОМЕР СЧЕТА:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(688, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 26);
            this.label13.TabIndex = 25;
            this.label13.Text = "ПЕРЕВОДЫ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(559, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 26);
            this.label14.TabIndex = 26;
            this.label14.Text = "С СЧЕТА:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtAccountNumber4
            // 
            this.txtAccountNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber4.Location = new System.Drawing.Point(718, 276);
            this.txtAccountNumber4.Multiline = true;
            this.txtAccountNumber4.Name = "txtAccountNumber4";
            this.txtAccountNumber4.Size = new System.Drawing.Size(176, 52);
            this.txtAccountNumber4.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(556, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 26);
            this.label15.TabIndex = 28;
            this.label15.Text = "НА СЧЕТ:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtTargetAccount4
            // 
            this.txtTargetAccount4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetAccount4.Location = new System.Drawing.Point(718, 335);
            this.txtTargetAccount4.Multiline = true;
            this.txtTargetAccount4.Name = "txtTargetAccount4";
            this.txtTargetAccount4.Size = new System.Drawing.Size(176, 51);
            this.txtTargetAccount4.TabIndex = 29;
            // 
            // txtAmount4
            // 
            this.txtAmount4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount4.Location = new System.Drawing.Point(718, 395);
            this.txtAmount4.Multiline = true;
            this.txtAmount4.Name = "txtAmount4";
            this.txtAmount4.Size = new System.Drawing.Size(176, 51);
            this.txtAmount4.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(556, 406);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 26);
            this.label16.TabIndex = 31;
            this.label16.Text = "СУММА:";
            // 
            // txtAccountNumber6
            // 
            this.txtAccountNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber6.Location = new System.Drawing.Point(450, 592);
            this.txtAccountNumber6.Multiline = true;
            this.txtAccountNumber6.Name = "txtAccountNumber6";
            this.txtAccountNumber6.Size = new System.Drawing.Size(186, 44);
            this.txtAccountNumber6.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(604, 525);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(237, 26);
            this.label17.TabIndex = 34;
            this.label17.Text = "УДАЛЕНИЕ СЧЕТА";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(445, 561);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(191, 26);
            this.label18.TabIndex = 35;
            this.label18.Text = "НОМЕР СЧЕТА";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(989, 658);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAccountNumber6);
            this.Controls.Add(button6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAmount4);
            this.Controls.Add(this.txtTargetAccount4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAccountNumber4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAccountNumber5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAmount3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAccountNumber3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAccountNumber2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountNumber2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountNumber3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmount3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAccountNumber5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAccountNumber4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTargetAccount4;
        private System.Windows.Forms.TextBox txtAmount4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAccountNumber6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

