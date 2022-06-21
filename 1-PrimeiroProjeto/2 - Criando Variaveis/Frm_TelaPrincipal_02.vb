Public Class Frm_TelaPrincipal_02
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNumerosInteiros.Click
        Dim idade As Integer
        idade = 12
        MsgBox(idade, MsgBoxStyle.Critical)
    End Sub

    Private Sub btnNumerosFlutuantes_Click(sender As Object, e As EventArgs) Handles btnNumerosFlutuantes.Click
        Dim valor As Double
        valor = 9.5
        MsgBox(valor, MsgBoxStyle.Critical)

        valor = 5 / 2
        MsgBox("O valor de 5 dividido por 2 é" + valor.ToString, MsgBoxStyle.Critical)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        valor = numerador / denominador
        MsgBox("O valor do numerador dividido pelo denominador é " + valor.ToString, MsgBoxStyle.Critical)


    End Sub

    Private Sub btnConversaoNumero_Click(sender As Object, e As EventArgs) Handles btnConversaoNumero.Click
        Dim salario As Double
        salario = 1300.45
        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("O valor do salario é " + salario.ToString + " e do salario inteiro é " + salarioInteiro.ToString, MsgBoxStyle.Critical)

        Dim salarioGrande As Long
        salarioGrande = 1300000000000000

        Dim salarioPequeno As Short
        salarioPequeno = 1

        Dim valorDOuble As Double
        valorDOuble = 9.2455679912454887

        Dim valorDecimal As Decimal
        valorDecimal = 9.2455679912454887

    End Sub

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        Dim numerador As Double
        Dim denominador As Double
        numerador = txt_Numerado.Text
        denominador = txt_Denominador.Text

        Dim resultado As Double

        resultado = numerador / denominador

        MsgBox("O resultado entre a divisão de " + numerador.ToString + " por " +
               denominador.ToString + " é " + resultado.ToString, MsgBoxStyle.Critical)

    End Sub
End Class
