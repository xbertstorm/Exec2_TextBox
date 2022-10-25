using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox
{
	public partial class AgeCheck : Form
	{
		public AgeCheck()
		{
			InitializeComponent();
			label1.Text = String.Empty;
			FormBorderStyle = FormBorderStyle.Fixed3D;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime input;
			try
			{
				input = SetDate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			CalAge(input);
		}
		private DateTime SetDate()
		{
			TextBox txt = textBox1;
			string input = txt.Text;
			return GetDateTime(txt, input);
		}
		private DateTime GetDateTime(TextBox txt, string input)
		{
			string value = txt.Text;
			bool Isint = DateTime.TryParse(value, out DateTime number);
			return Isint ? number : throw new Exception($"{input}必須要填值");
		}
		private string CalAge(DateTime input)
		{
			DateTime birthday = input;
			DateTime now = DateTime.Now;
			int realage;

			if (birthday.Month < now.Month)
				realage = now.Year - birthday.Year;
			else
			{
				if (birthday.Month == now.Month)
				{
					if (birthday.Day < now.Day)
						realage = now.Year - birthday.Year;
					else
						realage = now.Year - birthday.Year - 1;
				}
				else
					realage = now.Year - birthday.Year - 1;
			}

			if (realage >= 13) return label1.Text = "已滿13歲";
			else return label1.Text = "未滿13歲";
		}
	}
}
