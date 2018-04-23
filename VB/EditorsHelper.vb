Imports DevExpress.XtraEditors

Public Class EditorsHelper
    Public Shared Sub SetStyleController(ByVal parent As Control, ByVal styleController As StyleController)
        Dim control As Control
        For Each control In parent.Controls
            If TypeOf control Is BaseControl Then
                CType(control, BaseControl).StyleController = styleController
            End If
            SetStyleController(control, styleController)
        Next
    End Sub
End Class
