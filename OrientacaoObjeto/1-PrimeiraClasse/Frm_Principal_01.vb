Public Class Frm_Principal_01
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Text = "1 - Primeria Classe"
        lblPrincipal.Text = "1 - Primeira classe"

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnAcao_Click(sender As Object, e As EventArgs) Handles btnAcao.Click

        'Dim Titular As String = "Gabriel"
        'Dim Agencia As Integer = 863
        'Dim Conta As Integer = 863141
        'Dim Saldo As Double = 100

        'Dim Titular2 As String = "Bruno"
        'Dim Agencia2 As Integer = 863
        'Dim Conta2 As Integer = 863142
        'Dim Saldo2 As Double = 100

        Dim ContaGabriela As New ContaCorrente
        ContaGabriela.Titular = "Gabriela"
        ContaGabriela.Agencia = 863
        ContaGabriela.Conta = 863141
        ContaGabriela.Saldo = Val(txtSaldo.Text)

        MsgBox($"O saldo da {ContaGabriela.Titular} na C/C {ContaGabriela.Agencia} - {ContaGabriela.Conta} é {ContaGabriela.Saldo}")

        Dim vIncremento As Double = Val(txtIncremento.Text)

        ContaGabriela.Saldo += vIncremento

        MsgBox($"O saldo da {ContaGabriela.Titular} na C/C {ContaGabriela.Agencia} - {ContaGabriela.Conta} é {ContaGabriela.Saldo}")



    End Sub

    Private Sub btnAcao2_Click(sender As Object, e As EventArgs) Handles btnAcao2.Click

        Dim ContaBruno As New ContaCorrente



    End Sub

    Private Sub btnValRef_Click(sender As Object, e As EventArgs) Handles btnValRef.Click

        Dim idade As Integer = 20
        Dim idade2 As Integer

        idade2 = idade

        MsgBox($"Valor da idade é {idade} idade2 é {idade2}")

        idade = 30

        MsgBox($"Valor da idade é {idade} idade2 é {idade2}")

        Dim ContaGabriela As New ContaCorrente
        Dim ContaGabrielaCosta As New ContaCorrente

        ContaGabriela.Titular = "Gabriel"
        ContaGabriela.Agencia = 863
        ContaGabriela.Conta = 863141

        ContaGabrielaCosta = ContaGabriela

        MsgBox($"Valor da ContaGabriela {ContaGabriela.Saldo}, Conta da Gabriela Costa {ContaGabrielaCosta.Saldo}")

        ContaGabriela.Saldo += 300

        MsgBox($"Valor da ContaGabriela {ContaGabriela.Saldo}, Conta da Gabriela Costa {ContaGabrielaCosta.Saldo}")

    End Sub
End Class
