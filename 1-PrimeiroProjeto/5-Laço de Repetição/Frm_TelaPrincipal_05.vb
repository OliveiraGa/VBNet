Public Class Frm_TelaPrincipal_05
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btn_CliqueAqui_Click(sender As Object, e As EventArgs) Handles Btn_While.Click

        Txt_Extrato.Text = ""
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodo As Integer = Val(Txt_Periodo.Text)
        Dim contador As Integer = 1
        Dim extrato As String = ""

        While contador <= periodo

            'investimento = FormatNumber((investimento + (investimento * (rendimento / 100))), 2)
            investimento = investimento + (investimento * (rendimento / 100))
            extrato += $"O valor do extrato do mês {contador} é: {investimento.ToString()} {Environment.NewLine}"
            contador += 1
        End While

        Txt_Extrato.Text = extrato

    End Sub

    Private Sub Btn_For_Click(sender As Object, e As EventArgs) Handles Btn_For.Click

        Txt_Extrato_For.Text = ""
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodo As Integer = Val(Txt_Periodo.Text)
        Dim extrato As String = ""

        For index = 1 To periodo
            investimento = investimento + (investimento * (rendimento / 100))
            extrato += $"O valor do extrato do mês {index} é: {investimento.ToString()} {Environment.NewLine}"
        Next
        Txt_Extrato_For.Text = extrato
    End Sub

    Private Sub btn_Caulcular_Click(sender As Object, e As EventArgs) Handles btn_Caulcular.Click
        Dim investimento As Double = Val(Txt_Principal2.Text)
        Dim rendimento As Double = Val(Txt_Juros.Text)
        Dim anos As Integer = Val(Txt_Anos.Text)
        Dim acrescimosJuros As Double = Val(Txt_Acrescimo.Text)
        Dim extrato As String = ""
        Dim contador As Integer = 1

        For index = 1 To anos
            For j = 1 To 12
                investimento = investimento + (investimento * (rendimento / 100))

                extrato += $"O valor do extrato do mês {contador} é: {investimento.ToString()} " +
                           $"usando a taxa de: {rendimento} % mês {Environment.NewLine}"

                contador += 1

            Next
            rendimento = rendimento + (rendimento * acrescimosJuros / 100)
        Next

        Txt_ExtratoAcrescimo.Text = extrato

    End Sub
End Class
