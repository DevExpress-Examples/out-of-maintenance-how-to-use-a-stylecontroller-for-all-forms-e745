<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit
        CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateEdit1
        '
        Me.dateEdit1.EditValue = New Date(2006, 11, 6, 0, 0, 0, 0)
        Me.dateEdit1.Location = New System.Drawing.Point(12, 49)
        Me.dateEdit1.Name = "dateEdit1"
        Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEdit1.Size = New System.Drawing.Size(151, 20)
        Me.dateEdit1.TabIndex = 3
        '
        'buttonEdit1
        '
        Me.buttonEdit1.EditValue = "test"
        Me.buttonEdit1.Location = New System.Drawing.Point(12, 12)
        Me.buttonEdit1.Name = "buttonEdit1"
        Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.buttonEdit1.Size = New System.Drawing.Size(151, 20)
        Me.buttonEdit1.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 182)
        Me.Controls.Add(Me.dateEdit1)
        Me.Controls.Add(Me.buttonEdit1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dateEdit1 As DevExpress.XtraEditors.DateEdit
    Private WithEvents buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
End Class
