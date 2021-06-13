﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIconGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			notifyIcon1.ShowBalloonTip(5000, "Quốc sư Hoa Kì Said that: ", textBox1.Text, ToolTipIcon.Warning);
		}

		private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
		{
			textBox1.Text = contextMenuStrip1.Text;
		}
	}
}
