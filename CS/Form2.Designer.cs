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
	public partial class Form2 : System.Windows.Forms.Form
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
			this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
			this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
			((System.ComponentModel.ISupportInitialize)this.dateEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.buttonEdit1.Properties).BeginInit();
			this.SuspendLayout();
			//
			//dateEdit1
			//
			this.dateEdit1.EditValue = new System.DateTime(2006, 11, 6, 0, 0, 0, 0);
			this.dateEdit1.Location = new System.Drawing.Point(12, 49);
			this.dateEdit1.Name = "dateEdit1";
			this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit1.Size = new System.Drawing.Size(151, 20);
			this.dateEdit1.TabIndex = 3;
			//
			//buttonEdit1
			//
			this.buttonEdit1.EditValue = "test";
			this.buttonEdit1.Location = new System.Drawing.Point(12, 12);
			this.buttonEdit1.Name = "buttonEdit1";
			this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.buttonEdit1.Size = new System.Drawing.Size(151, 20);
			this.buttonEdit1.TabIndex = 2;
			//
			//Form2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0), (float)(13.0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(240, 182);
			this.Controls.Add(this.dateEdit1);
			this.Controls.Add(this.buttonEdit1);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)this.dateEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.buttonEdit1.Properties).EndInit();
			this.ResumeLayout(false);

		}
		private DevExpress.XtraEditors.DateEdit dateEdit1;
		private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
	}

} //end of root namespace