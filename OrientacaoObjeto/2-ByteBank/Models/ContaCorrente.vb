Imports _2_ByteBank.ByteBank

Public Class ContaCorrente

#Region "PROPRIEDADES"

    Private m_Titular As Cliente
    Public Property Titular As Cliente
        Get
            Return m_Titular
        End Get
        Set(value As Cliente)
            m_Titular = value
        End Set
    End Property


    Private m_Agencia As Integer
    Public Property Agencia() As Integer
        Get
            Return m_Agencia
        End Get
        Set(ByVal value As Integer)
            m_Agencia = value
        End Set
    End Property


    Private m_Conta As Integer
    Public Property Conta() As Integer
        Get
            Return m_Conta
        End Get
        Set(ByVal value As Integer)
            m_Conta = value
        End Set
    End Property

    Private m_Extrato As String
    Public Property Extrato() As String
        Get
            Return m_Extrato
        End Get
        Set(ByVal value As String)
            m_Extrato = value
        End Set
    End Property

    Private m_Saldo As Double = 100
    Public Property Saldo As Double
        Get
            Return m_Saldo
        End Get
        Set(value As Double)
            If value < 0 Then
                m_Saldo = 0
            Else
                m_Saldo = value
            End If
        End Set

    End Property

#End Region

#Region "METODOS"

    Public Function Sacar(ByVal ValorSacar As Double) As Boolean
        Sacar = False

        If m_Saldo >= ValorSacar Then
            m_Saldo -= ValorSacar
            Sacar = True
        End If

        Return Sacar
    End Function

    Public Sub Depositar(ByVal valorDeposito As Double)
        m_Saldo += valorDeposito
    End Sub

    Public Function Transferencia(ByVal valorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean

        Transferencia = Sacar(valorTransferencia)

        If Transferencia Then
            ContaDestino.Depositar(valorTransferencia)
        End If

        Return Transferencia
    End Function
#End Region

#Region "FUNCOES ESPECIAIS"

#End Region

End Class
