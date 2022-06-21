Public Class ContaCorrente
    Public Titular As String
    Public Agencia As Integer
    Public Conta As Integer
    Public Saldo As Double = 100
    Public Extrato As String = ""


    Public Function Sacar(ByVal ValorSacar As Double) As Boolean
        Sacar = False

        If Saldo >= ValorSacar Then
            Saldo -= ValorSacar
            Sacar = True
        End If

        Return Sacar
    End Function

    Public Sub Depositar(ByVal valorDeposito As Double)
        Saldo += valorDeposito
    End Sub

End Class
