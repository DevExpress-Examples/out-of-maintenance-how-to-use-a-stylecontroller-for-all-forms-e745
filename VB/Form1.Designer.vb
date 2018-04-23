<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.styleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.styleController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'styleController1
        '
        Me.styleController1.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.styleController1.AppearanceFocused.Options.UseFont = True
        Me.styleController1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.styleController1.LookAndFeel.UseDefaultLookAndFeel = False
        '
        'simpleButton1
        '
        Me.simpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.simpleButton1.Name = "simpleButton1"
        Me.simpleButton1.Size = New System.Drawing.Size(119, 23)
        Me.simpleButton1.StyleController = Me.styleController1
        Me.simpleButton1.TabIndex = 1
        Me.simpleButton1.Text = "Open Form2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(141, 47)
        Me.Controls.Add(Me.simpleButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.styleController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents styleController1 As DevExpress.XtraEditors.StyleController
    Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton

End Class
