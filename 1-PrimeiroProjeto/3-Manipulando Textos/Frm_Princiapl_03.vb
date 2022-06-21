Public Class Frm_Princiapl_03

    Dim ListaCurso As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim PrimeiraLetra As Char = "a"c

        MsgBox("O caracter da variavel PrimeiraLetra é " + PrimeiraLetra)

        Dim SegundaLetra As Char = Chr(65)
        MsgBox("O caracter da variavel SegundaLetra é " + SegundaLetra)

        Dim NumeroChar As Integer = 65
        Dim TerceiraLetra As Char = Chr(NumeroChar)

        NumeroChar = NumeroChar + 1
        Dim QuartaLetra As Char = Chr(NumeroChar)
        MsgBox("O caracter da variavel TerceiraLetra é " + SegundaLetra + " e o 66 é " + QuartaLetra)

    End Sub

    Private Sub btn_TxtVal_Click(sender As Object, e As EventArgs) Handles btn_TxtVal.Click
        Dim ValorChar As Integer = Val(txt_Str.Text)
        Dim QuintaLetra As Char = Chr(ValorChar)

        MsgBox("O Caracter para o numero " + ValorChar.ToString + " é " + QuintaLetra)


    End Sub

    Private Sub btn_Adicionar_Click(sender As Object, e As EventArgs) Handles btn_Adicionar.Click
        Dim CursoDigitado As String = txt_Curso.Text
        ListaCurso += CursoDigitado + vbCrLf 'Environment.NewLine
        txt_ListCurso.Text = ListaCurso
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        MsgBox($"Lista atual de cursos: {vbCrLf} {ListaCurso}")

    End Sub
End Class
