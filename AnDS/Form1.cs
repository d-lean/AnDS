﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnDS
{
	public partial class Form1 : Form
	{
		Queue<int> q;
		public Form1()
		{
			this.q = new Queue<int>();
			InitializeComponent();
		}

		private void buttonPush_Click(object sender, EventArgs e)
		{
			q.push(int.Parse(textBoxInput.Text));
			richTextBoxPresent.Text = q.ToString();
		}

		private void buttonPop_Click(object sender, EventArgs e)
		{
			textBoxInput.Text = q.pop().ToString();

			richTextBoxPresent.Text = q.ToString();
		}
	}
}
