namespace Exec2_TextBox
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			FormBorderStyle = FormBorderStyle.Fixed3D;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NumberCheck set = new NumberCheck();
			set.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DateCheck set = new DateCheck();
			set.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AgeCheck set = new AgeCheck();
			set.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			FeeCheck set = new FeeCheck();
			set.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}