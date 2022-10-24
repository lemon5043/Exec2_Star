using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void leftTriangle_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();
			if (!rows.HasValue)
			{
				MessageBox.Show("請輸入0-10的整數");
				return;
			}

			string stars = BuildLeftTriangle(rows.Value);
			txtAnswer.Text = stars;
		}


		private void rightTriangle_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();
			if (!rows.HasValue)
			{
				MessageBox.Show("請輸入0-10的整數");
				return;
			}

			string stars = BuildRightTriangle(rows.Value);
			txtAnswer.Text = stars;
		}

		private void isoscelesTriangle_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();
			if (!rows.HasValue)
			{
				MessageBox.Show("請輸入0-10的整數");
				return;
			}

			string stars = BuildIsoscelesTriangle(rows.Value);
			txtAnswer.Text = stars;
		}

		private int? GetRows()
		{
			string input = txtInput.Text;
			bool isInt = int.TryParse(input, out int result);

			if (!isInt || result < 0 || result > 10)
			{
				return null;
			}
			return result;
		}

		private string BuildLeftTriangle(int n)
		{
			string result = String.Empty;
			for (int i = 1; i <= n; i++)
			{
				result += new string('*', i) +"\r\n";
				
			}

			return result;
		}

		private string BuildRightTriangle(int n)
		{
			string result = String.Empty;
			for (int i = 1; i <= n; i++)
			{
				result += new string(' ', (n - i) * 2) + new string('*', i) + "\r\n";
			}

			return result;
		}

		private string BuildIsoscelesTriangle(int n)
		{
			string result = String.Empty;
			for (int i = 1; i <= n; i++)
			{
				result += new string(' ', (n - i) * 2) + new string('*', i * 2 - 1) + "\r\n";
			}

			return result;
		}


	}
}
