using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr4_WinForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int Accerman(int n, int m) 
		{
			if (n == 0)
				return m + 1;
			else
			{
				if (m == 0) return Accerman(n - 1, 1);
				else return Accerman(n - 1, Accerman(n, m - 1));
			}
		}
		private void calculate_button_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(n_box.Text);
			int m = Convert.ToInt32(m_box.Text);
			try
			{
				if (n < 0 || m < 0) throw new Exception("Недопустимое значение переменной");
				else
					accerman_box.Text = $"{Accerman(n, m)}";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void n_box_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
			{
				e.Handled = true;
			}
		}
		private void print(int n)
		{
			string str = "";
			void loop(int i)
			{
				int a = Math.Abs(i);
				str += new String(' ', a) +
					new String((char)(n - a + 48), (n - a - 1) * 2 + 1) +
					new String(' ', a)+"\n";
				if (++i < n) loop(i);
			}
			loop(1 - n);
			rezult_box.Text = str;
		}
		private void n2_box_TextChanged(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(n2_box.Text);
			try
			{
				if (n <= 0) throw new Exception("Недопустимое значение переменной");
				else print(n);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
