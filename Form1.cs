using System.Collections.Generic;
using System.Xml;

namespace GeradorDeSenha
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void tb1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
		}

		private void ValidaTamanhoSenha()
		{
			int TamanhoDaSenha = 8;
			if (!string.IsNullOrWhiteSpace(tb1.Text))
			{
				TamanhoDaSenha = Convert.ToInt32(tb1.Text);
				if (TamanhoDaSenha > 30)
				{
					TamanhoDaSenha = 30;
					tb1.Text = "30";
				}
				if (TamanhoDaSenha < 8)
				{
					TamanhoDaSenha = 8;
					tb1.Text = "8";
				}
			}
			else
			{
				tb1.Text = "8";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (int.Parse(tb1.Text) < 8 || int.Parse(tb1.Text) > 30 || tb1.Text == ""  || tb1.Text == " ")
			{
				tb2.Text = "O tamanho da senha deve ser maior que 8 e menor que 30.";
			}



			else
			{
				ValidaTamanhoSenha();
				string caracteresPermitidos = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()_+";
				char[] chars = new char[int.Parse(tb1.Text)];
				Random rd = new Random();
				for (int i = 0; i < int.Parse(tb1.Text); i++)
				{
					chars[i] = caracteresPermitidos[rd.Next(0, caracteresPermitidos.Length)];
				}
				tb2.Text = new string(chars);
			}	
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void tb2_TextChanged(object sender, EventArgs e)
		{
			string QuebraLinha = Environment.NewLine;
			tb3.Text = tb2.Text + QuebraLinha + tb3.Text;
		}

		private void tb3_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			tb2.Text = null;
			tb3.Text = null;
		}

		private void tb1_TextChanged(object sender, EventArgs e)
		{

		}

	}
}