using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox
{
	public partial class NumberCheck : Form
	{
		public NumberCheck()
		{
			InitializeComponent();
			label1.Text = String.Empty;
			FormBorderStyle = FormBorderStyle.Fixed3D;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			int number;
			try
			{
				number = SetNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			CheckNumber(number);
		}
		private int SetNumber()
		{
			TextBox txt = textBox1;
			string input = txt.Text;
			return GetInt(txt, input);
		}
		private int GetInt(TextBox txt, string input)
		{
			string value = txt.Text;
			bool Isint = int.TryParse(value, out int number);
			return Isint ? number : throw new Exception($"{input}必須要填值");
		}
		private string CheckNumber(int checkednumber)
		{
			int uncheck = checkednumber;

			if (uncheck >= 1 && uncheck <= 99)
				return label1.Text = "Number is in range";
			else
				return label1.Text = "Number is not in range";
		}
	}
}
