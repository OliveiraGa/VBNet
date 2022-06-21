Public Class Frm_TelaPrincipal_01
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_CliqueAqui.Click
        MsgBox("Teste", MsgBoxStyle.Critical, "Mensagem")
    End Sub


End Class
