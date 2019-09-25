using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClient._Test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Point locationOnForm = textBox1.FindForm().PointToClient(textBox1.Parent.PointToScreen(textBox1.Location));
			string str	= string.Format("Location.X: {0}, Left: {1}, Point.X: {2}, Point.Y: {3}", textBox1.Location.X, textBox1.Left, locationOnForm.X, locationOnForm.Y);
			//MessageBox.Show(str);
		}
	}
}
