using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace UseOneStyleController
{
	public class EditorsHelper
	{
		public static void SetStyleController(Control parent, StyleController styleController)
		{
			foreach (Control control in parent.Controls)
			{
				if (control is BaseControl)
				{
					((BaseControl)control).StyleController = styleController;
				}
				SetStyleController(control, styleController);
			}
		}
	}

}