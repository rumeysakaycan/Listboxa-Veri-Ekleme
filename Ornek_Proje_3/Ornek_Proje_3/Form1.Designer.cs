namespace Ornek_Proje_3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.maskedTextBox_TC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker_Dogum = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Sehir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "T.C :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doğum Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şehir :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Listbox\'a Aktar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(15, 350);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(779, 166);
            this.listBox1.TabIndex = 7;
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(119, 32);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(120, 24);
            this.textBox_Ad.TabIndex = 8;
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(119, 74);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(120, 24);
            this.textBox_Soyad.TabIndex = 9;
            // 
            // maskedTextBox_TC
            // 
            this.maskedTextBox_TC.Location = new System.Drawing.Point(119, 113);
            this.maskedTextBox_TC.Mask = "00000000000";
            this.maskedTextBox_TC.Name = "maskedTextBox_TC";
            this.maskedTextBox_TC.Size = new System.Drawing.Size(120, 24);
            this.maskedTextBox_TC.TabIndex = 10;
            this.maskedTextBox_TC.ValidatingType = typeof(int);
            // 
            // maskedTextBox_Telefon
            // 
            this.maskedTextBox_Telefon.Location = new System.Drawing.Point(119, 154);
            this.maskedTextBox_Telefon.Mask = "(999) 000-0000";
            this.maskedTextBox_Telefon.Name = "maskedTextBox_Telefon";
            this.maskedTextBox_Telefon.Size = new System.Drawing.Size(120, 24);
            this.maskedTextBox_Telefon.TabIndex = 11;
            // 
            // dateTimePicker_Dogum
            // 
            this.dateTimePicker_Dogum.Location = new System.Drawing.Point(119, 201);
            this.dateTimePicker_Dogum.Name = "dateTimePicker_Dogum";
            this.dateTimePicker_Dogum.Size = new System.Drawing.Size(120, 24);
            this.dateTimePicker_Dogum.TabIndex = 12;
            // 
            // comboBox_Sehir
            // 
            this.comboBox_Sehir.FormattingEnabled = true;
            this.comboBox_Sehir.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Aydın",
            "Manisa",
            "Adana",
            "Bayburt",
            "Osmaniye",
            "Hatay",
            "Tekirdağ",
            "Bursa",
            "Yalova"});
            this.comboBox_Sehir.Location = new System.Drawing.Point(119, 238);
            this.comboBox_Sehir.Name = "comboBox_Sehir";
            this.comboBox_Sehir.Size = new System.Drawing.Size(120, 26);
            this.comboBox_Sehir.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(818, 542);
            this.Controls.Add(this.comboBox_Sehir);
            this.Controls.Add(this.dateTimePicker_Dogum);
            this.Controls.Add(this.maskedTextBox_Telefon);
            this.Controls.Add(this.maskedTextBox_TC);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.textBox_Ad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Örnek Proje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TC;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Telefon;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Dogum;
        private System.Windows.Forms.ComboBox comboBox_Sehir;
    }
}

