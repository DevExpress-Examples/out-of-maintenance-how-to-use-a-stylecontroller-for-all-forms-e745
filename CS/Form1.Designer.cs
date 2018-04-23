//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace UseOneStyleController
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class Form1 : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)this.styleController1).BeginInit();
			this.SuspendLayout();
			//
			//styleController1
			//
			this.styleController1.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.styleController1.AppearanceFocused.Options.UseFont = true;
			this.styleController1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
			this.styleController1.LookAndFeel.UseDefaultLookAndFeel = false;
			//
			//simpleButton1
			//
			this.simpleButton1.Location = new System.Drawing.Point(12, 12);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(119, 23);
			this.simpleButton1.StyleController = this.styleController1;
			this.simpleButton1.TabIndex = 1;
			this.simpleButton1.Text = "Open Form2";
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0), (float)(13.0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(141, 47);
			this.Controls.Add(this.simpleButton1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)this.styleController1).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted event handler wireups:
			simpleButton1.Click += new System.EventHandler(simpleButton1_Click);

		}
		private DevExpress.XtraEditors.StyleController styleController1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;

	}

} //end of root namespace