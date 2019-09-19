using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static string a = " ";
		
		public List<string> list =new List<string>();

		public int sum = 0;
		void unit()
		{
			for (int i = 0; i < list.Count(); i++) {
				try
				{
					if (!(list[i + 1] == "+") & !(list[i] == "+")
						& !(list[i + 1] == "-") & !(list[i] == "-")
						& !(list[i + 1] == "*") & !(list[i] == "*")
						& !(list[i + 1] == "/") & !(list[i] == "/"))
					{

						list[i] = list[i] + list[i + 1];
						list.RemoveAt(i + 1);
						unit();
					}
				}
				catch (ArgumentOutOfRangeException) { }

			}
		}

		void operation()
		{
			int i = 0;

			 while (i < list.Count()) {
				if (list.Contains("*"))
				{
					i = list.IndexOf("*");
				}
				try
				{
					switch (list[i])
					{
						case "+":
							sum = Convert.ToInt32(list[i - 1]) + Convert.ToInt32((list[i + 1]));
							list[i] = sum.ToString();
							list.RemoveAt(i + 1);
							list.RemoveAt(i - 1);
							break;
						case "-":
							sum = Convert.ToInt32(list[i - 1]) - Convert.ToInt32((list[i + 1]));
							list[i] = sum.ToString();
							list.RemoveAt(i + 1);
							list.RemoveAt(i - 1);
							break;
						case "*":
							sum = Convert.ToInt32(list[i - 1]) * Convert.ToInt32((list[i + 1]));
							list[i] = sum.ToString();
							list.RemoveAt(i + 1);
							list.RemoveAt(i - 1);
							i = 0;
							break;
						case "/":
							sum = Convert.ToInt32(list[i - 1]) / Convert.ToInt32((list[i + 1]));
							list[i] = sum.ToString();
							list.RemoveAt(i + 1);
							list.RemoveAt(i - 1);
							break;

					}
				}
				catch (ArgumentOutOfRangeException) { }
				i += 1;
			 } 
		}
		void FOR()
		{
			for (int i = 0; i < list.Count(); i++)
			{
				Console.WriteLine(list[i]);
			}
			Console.WriteLine(sum);
		}
	
		public void label() {
			unit();
			if (a.Contains("="))
			{
				operation();
			}
			FOR();
			label1.Text = a;
			label2.Text = sum.ToString();
			
			if (a.Length > 12) {
				label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

			}

		}
		private void Button1_Click(object sender, EventArgs e)
		{
			a += '1';
			list.Add("1");
			label();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			a += '2';
			list.Add("2");
			label();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			a += '3';
			list.Add("3");
			label();
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			a += '4';
			list.Add("4");
			label();
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			a += '5';
			list.Add("5");
			label();
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			a += '6';
			list.Add("6");
			label();
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			a += '7';
			list.Add("7");
			label();
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			a += '8';
			list.Add("8");
			label();
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			a += '9';
			list.Add("9");
			label();
		}

		private void Button10_Click(object sender, EventArgs e)
		{
			a += '0';
			list.Add("0");
			label();
		}

		private void Delit_Click(object sender, EventArgs e)
		{
			a += '/';
			list.Add("/");
			label();
		}

		private void Umnoz_Click(object sender, EventArgs e)
		{
			a += '*';
			list.Add("*");
			label();
		}

		private void Minus_Click(object sender, EventArgs e)
		{
			a += '-';
			list.Add("-");
			label();
		}

		private void Plus_Click(object sender, EventArgs e)
		{
			a += '+';
			list.Add("+");
			label();
		}

		private void Rovno_Click(object sender, EventArgs e)
		{
			a += '=';
			label();
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			list.Clear();
			a = " ";
			label1.Text = "0";
			label2.Text = "0";
			label();
		}
	}
}
