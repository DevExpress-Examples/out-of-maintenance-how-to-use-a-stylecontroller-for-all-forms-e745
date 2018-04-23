using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace UseOneStyleController
{
	public partial class Form1
	{

		internal Form1()
		{
			InitializeComponent();
		}
		private void simpleButton1_Click(object sender, System.EventArgs e)
		{
			Form2 frm = new Form2();
			EditorsHelper.SetStyleController(frm, styleController1);
			frm.Show();
		}
	}

}