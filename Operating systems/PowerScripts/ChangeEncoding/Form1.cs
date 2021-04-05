using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeEncoding
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

			comboBox1.Items.AddRange(new object[] { "UTF-16LE", "UTF-8" });
			comboBox2.Items.AddRange(new object[] { "UTF-8", "UTF-16LE" });
		}

		private void _btnToUtf16_Click(object sender, EventArgs e)
		{
			richTextBox2.Text = "";
			richTextBox5.Text = "";
			if (richTextBox1.Text.ToString().Length == 0)
			{
				MessageBox.Show("Ошибка: не введён текст для преобразования!");
				return;
			}

			byte[] utf8Bytes = Encoding.UTF8.GetBytes(richTextBox1.Text.ToString());
			byte[] utf16Bytes = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf8Bytes);

			richTextBox5.Text = richTextBox5.Text + "\n{ ";
			for (int i = 0; i < utf8Bytes.Length; i++)
			{
				richTextBox5.Text = richTextBox5.Text + utf8Bytes[i].ToString() + ", ";
			}
			richTextBox5.Text = richTextBox5.Text + "} ";

			richTextBox2.Text = richTextBox2.Text + "{ ";
			for (int i = 0; i < utf16Bytes.Length; i++)
			{
				richTextBox2.Text = richTextBox2.Text + utf16Bytes[i].ToString() + ", ";
			}
			richTextBox2.Text = richTextBox2.Text + "} ";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox3.Text = "";
			richTextBox6.Text = "";
			if (richTextBox4.Text.ToString().Length == 0)
			{
				MessageBox.Show("Ошибка: не введён текст для преобразования!");
				return;
			}

			byte[] utf16Bytes =
				Encoding.Convert(Encoding.Unicode, Encoding.UTF8,
				Encoding.UTF8.GetBytes(richTextBox4.Text));
			byte[] utf8Bytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf16Bytes);

			richTextBox6.Text = richTextBox6.Text + "\n{ ";
			for (int i = 0; i < utf16Bytes.Length; i++)
			{
				richTextBox6.Text = richTextBox6.Text + utf16Bytes[i].ToString() + ", ";
			}
			richTextBox6.Text = richTextBox6.Text + "} ";

			richTextBox3.Text = richTextBox3.Text + "{ ";
			for (int i = 0; i < utf8Bytes.Length; i++)
			{
				richTextBox3.Text = richTextBox3.Text + utf8Bytes[i].ToString() + ", ";
			}
			richTextBox3.Text = richTextBox3.Text + "} ";
		}

		private string filename = "";

		private void button2_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;

			filename = openFileDialog1.FileName;
		}

		bool ValidComboBox(ComboBox cmb)
		{
			if ((!cmb.Text.Equals("UTF-16LE"))
				&& (!cmb.Text.Equals("UTF-8")))
				return false;
			return true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if((!ValidComboBox(comboBox1)) || (!ValidComboBox(comboBox2)))
			{
				MessageBox.Show("Ошибка: не выбрана кодировка файла или перекодирования!",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}else if(filename.Length == 0)
			{
				MessageBox.Show("Ошибка: не выбран файл для перекодирования!",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string newFileName = filename + comboBox2.Text.ToString() + ".txt";

			using (StreamReader reader = new StreamReader(filename, Encoding.GetEncoding(comboBox1.Text.ToString())))
			using (StreamWriter writer = new StreamWriter(newFileName, false, Encoding.GetEncoding(comboBox2.Text.ToString())))
			{
				writer.Write(reader.ReadToEnd());
			}
		}
	}
}
