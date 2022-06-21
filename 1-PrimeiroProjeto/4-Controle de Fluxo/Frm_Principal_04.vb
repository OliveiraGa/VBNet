Public Class Frm_Principal_04

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btn_CliqueAqui_Click(sender As Object, e As EventArgs) Handles Btn_CliqueAqui.Click

        Txt_Resultado.Text = ""

        Dim idade As Integer
        idade = Txt_Idade.Text

        Dim PodeEntrar As Boolean = (idade >= 18) Or (Rdb_SIm.Checked And idade >= 16)
        Dim NaoPodeEntrar As Boolean = (idade < 16) Or (Rdb_Nao.Checked And idade >= 16)

        Dim MensagemAdicional As String

        If Rdb_SIm.Checked Then
            MensagemAdicional = "Está acompanhado(a)"
        Else
            MensagemAdicional = "Não está acompanhado(a)"
        End If



        If PodeEntrar Then
            'Txt_Resultado.Text = "A pessoa pode assistir a peça por que tem mais de 18 anos"
            Txt_Resultado.ForeColor = Color.Green
            Txt_Resultado.Text = $"Pode entrar. {MensagemAdicional}"
        Else
            If NaoPodeEntrar Then
                Txt_Resultado.ForeColor = Color.Red
                Txt_Resultado.Text = $"Não pode entrar. {MensagemAdicional}"

            End If
        End If

    End Sub
End Class
