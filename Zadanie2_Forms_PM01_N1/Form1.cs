using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2_Forms_PM01_N1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int year = DateTime.Now.Year;
				int month = DateTime.Now.Month;
				int day = DateTime.Now.Day;

				int n = int.Parse(textBox4.Text);

				int[] months = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

				if (year % 4 == 0)
				{
					months[1] = 29;
				}

				while(n > 0)
				{
					day--;
					if(day <= 0)
					{
						month--;
						if(month <= 0)
						{
							year--;
							if(year % 4 == 0)
							{
								months[1] = 29;
							}
							else
							{
								months[1] = 28;
							}
							month = 12;
						}
						day = months[month - 1];
					}
					n--;
				}
				textBox7.Text = string.Format("{0}", day);
				textBox6.Text = string.Format("{0}", month);
				textBox5.Text = string.Format("{0}", year);
			}
			catch
			{
				textBox8.Text = string.Format("Введены некорректные данные");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int year = DateTime.Now.Year;
			int month = DateTime.Now.Month;
			int day = DateTime.Now.Day;

			textBox1.Text = String.Format("{0}", day);
			textBox2.Text = String.Format("{0}", month);
			textBox3.Text = String.Format("{0}", year);
		}
	}
}
