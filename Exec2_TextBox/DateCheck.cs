using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Exec2_TextBox
{
	public partial class DateCheck : Form
	{
		public DateCheck()
		{
			InitializeComponent();
			label1.Text = string.Empty;
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
			CheckDate(input);
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
		private string CheckDate(DateTime input)
		{
			DateTime uncheck = input;
			if (uncheck <= DateTime.Now) return label1.Text = "日期不大於今天";
			else return label1.Text = "日期大於今天";
		}
	}
}
