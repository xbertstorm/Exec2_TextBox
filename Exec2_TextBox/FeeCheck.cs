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
	public partial class FeeCheck : Form
	{
		public FeeCheck()
		{
			InitializeComponent();
			label3.Text = String.Empty;
			label4.Text = String.Empty;
			FormBorderStyle = FormBorderStyle.Fixed3D;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int people, car;

			try
			{
				people = SetNumber1();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			try
			{
				car = SetNumber2();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			PeopleFee(people);
			CarFee(car);
		}
		private int SetNumber1()
		{
			TextBox txt = textBox1;
			string input = txt.Text;
			return GetInt(txt, input);
		}
		private int SetNumber2()
		{
			TextBox txt = textBox2;
			string input = txt.Text;
			return GetInt(txt, input);
		}
		private int GetInt(TextBox txt, string input)
		{
			string value = txt.Text;
			bool Isint = int.TryParse(value, out int number);
			return Isint ? number : throw new Exception($"{input}必須要填值");
		}
		private string PeopleFee(int input)
		{
			int result = input * 60;

			return label3.Text = $"按人計算\r\n{result}元";
		}
		private string CarFee(int input)
		{
			int result = input * 200;

			return label4.Text = $"按車計算\r\n{result}元";

		}
	}
}
