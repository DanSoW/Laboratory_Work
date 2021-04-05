
namespace ChangeEncoding
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
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this._btnToUtf16 = new System.Windows.Forms.Button();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox5 = new System.Windows.Forms.RichTextBox();
			this.richTextBox6 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button3 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Текст в кодировке UTF-8:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(16, 57);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(465, 66);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// _btnToUtf16
			// 
			this._btnToUtf16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this._btnToUtf16.Location = new System.Drawing.Point(16, 223);
			this._btnToUtf16.Name = "_btnToUtf16";
			this._btnToUtf16.Size = new System.Drawing.Size(465, 39);
			this._btnToUtf16.TabIndex = 2;
			this._btnToUtf16.Text = "Перевод в UTF-16";
			this._btnToUtf16.UseVisualStyleBackColor = true;
			this._btnToUtf16.Click += new System.EventHandler(this._btnToUtf16_Click);
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(16, 269);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(465, 96);
			this.richTextBox2.TabIndex = 3;
			this.richTextBox2.Text = "";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(519, 269);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(485, 96);
			this.richTextBox3.TabIndex = 7;
			this.richTextBox3.Text = "";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.button1.Location = new System.Drawing.Point(519, 223);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(485, 39);
			this.button1.TabIndex = 6;
			this.button1.Text = "Перевод в UTF-8";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// richTextBox4
			// 
			this.richTextBox4.Location = new System.Drawing.Point(519, 57);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.Size = new System.Drawing.Size(485, 66);
			this.richTextBox4.TabIndex = 5;
			this.richTextBox4.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(515, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(233, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Текст в кодировке UTF-16:";
			// 
			// richTextBox5
			// 
			this.richTextBox5.Location = new System.Drawing.Point(16, 129);
			this.richTextBox5.Name = "richTextBox5";
			this.richTextBox5.Size = new System.Drawing.Size(465, 77);
			this.richTextBox5.TabIndex = 8;
			this.richTextBox5.Text = "";
			// 
			// richTextBox6
			// 
			this.richTextBox6.Location = new System.Drawing.Point(519, 129);
			this.richTextBox6.Name = "richTextBox6";
			this.richTextBox6.Size = new System.Drawing.Size(485, 77);
			this.richTextBox6.TabIndex = 9;
			this.richTextBox6.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(16, 394);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(228, 25);
			this.label3.TabIndex = 10;
			this.label3.Text = "Перекодировка файла:";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.button2.Location = new System.Drawing.Point(21, 445);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(170, 41);
			this.button2.TabIndex = 11;
			this.button2.Text = "Выбор файла";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(211, 455);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Кодировка файла:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(384, 452);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.Location = new System.Drawing.Point(21, 523);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(162, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "Новая кодировка:";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(190, 523);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 24);
			this.comboBox2.TabIndex = 15;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.button3.Location = new System.Drawing.Point(323, 514);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(182, 38);
			this.button3.TabIndex = 16;
			this.button3.Text = "Перекодировать";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1152, 604);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox6);
			this.Controls.Add(this.richTextBox5);
			this.Controls.Add(this.richTextBox3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this._btnToUtf16);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Change Encoding";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button _btnToUtf16;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox5;
		private System.Windows.Forms.RichTextBox richTextBox6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

