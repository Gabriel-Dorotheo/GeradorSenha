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
				if (TamanhoDaSenha > 20)
				{
					TamanhoDaSenha = 20;
					tb1.Text = "20";
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
			if (int.Parse(tb1.Text) < 8 || int.Parse(tb1.Text) > 20)
			{
				tb2.Text = "O tamanho da senha deve ser maior que 8 e menor que 20.";
			}



			else
			{
				ValidaTamanhoSenha();
				string caracteresPermitidos = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
				char[] chars = new char[int.Parse(tb1.Text)];
				Random rd = new Random();
				for (int i = 0; i < int.Parse(tb1.Text); i++)
				{
					chars[i] = caracteresPermitidos[rd.Next(0, caracteresPermitidos.Length)];
				}
				tb2.Text = new string(chars);
			}	
		}

	}
}