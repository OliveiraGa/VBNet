Public Class Frm_Principal_02

    Dim ContaGabriela As New ContaCorrente
    Dim ContaBruno As New ContaCorrente


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ContaGabriela.Titular = New ByteBank.Cliente("Gabriela", 123456789)
        ContaGabriela.Titular.Estado = "Rio de Janeiro"
        ContaGabriela.Agencia = 863
        ContaGabriela.Conta = 863141
        lblBemVindo.Text = $"Bem vindo(a) {ContaGabriela.Titular.Nome} Agência: {ContaGabriela.Agencia} C/C: {ContaGabriela.Conta}"
        txtSaldoAtual.Text = ContaGabriela.Saldo

        ContaBruno.Titular = New ByteBank.Cliente("Bruno", 125789104)
        ContaBruno.Titular.Estado = "São Paulo"
        ContaBruno.Agencia = 863
        ContaBruno.Conta = 863142
        lblBemVindoBruno.Text = $"Bem vindo(a) {ContaBruno.Titular.Nome} Agência: {ContaBruno.Agencia} C/C: {ContaBruno.Conta}"
        Me.txtSaldoAtualBruno.Text = ContaBruno.Saldo

    End Sub

    Private Sub btnSacar_Click(sender As Object, e As EventArgs) Handles btnSacar.Click

        Dim valorSacar As Double = Val(txtValor.Text)

        Dim result As Boolean = ContaGabriela.Sacar(valorSacar)
        txtResultado.Text = ""
        txtSaldoAtual.Text = ContaGabriela.Saldo

        If result Then
            txtSaldoAtual.Text = ContaGabriela.Saldo
            txtResultado.Text = "Saque realizado com sucesso!"
            ContaGabriela.Extrato += $"{Now.ToString} Saque de {valorSacar}{Environment.NewLine}Saldo: {ContaGabriela.Saldo}!{Environment.NewLine}"
        Else
            txtResultado.Text = "Saldo insuficiente para realizar saque!"
        End If

        txtExtrato.Text = ContaGabriela.Extrato

    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click

        txtSaldoAtual.Text = ""
        txtResultado.Text = ""
        Dim valorDeposito As Double = Val(txtValor.Text)
        ContaGabriela.Depositar(valorDeposito)
        ContaGabriela.Extrato += $"{Now.ToString} Deposito de {valorDeposito} {Environment.NewLine}Saldo: {ContaGabriela.Saldo}!{Environment.NewLine}"
        txtValor.Text = ""
        txtSaldoAtual.Text = ContaGabriela.Saldo
        txtExtrato.Text = ContaGabriela.Extrato
        txtResultado.Text = "Depósito realizado com sucesso"

    End Sub

    Private Sub btnDepositarBuno_Click(sender As Object, e As EventArgs) Handles btnDepositarBuno.Click

        txtSaldoAtualBruno.Text = ""
        txtResultadoBruno.Text = ""
        Dim valorDeposito As Double = Val(txtValorBruno.Text)
        ContaBruno.Depositar(valorDeposito)
        ContaBruno.Extrato += $"{Now.ToString} Deposito de {valorDeposito} {Environment.NewLine}Saldo: {ContaBruno.Saldo}!{Environment.NewLine}"
        txtValorBruno.Text = ""
        txtSaldoAtualBruno.Text = ContaBruno.Saldo
        txtExtratoBruno.Text = ContaBruno.Extrato
        txtResultadoBruno.Text = "Depósito realizado com sucesso"

    End Sub

    Private Sub btnSacarBruno_Click(sender As Object, e As EventArgs) Handles btnSacarBruno.Click

        Dim valorSacar As Double = Val(txtValorBruno.Text)

        Dim result As Boolean = ContaBruno.Sacar(valorSacar)
        txtResultadoBruno.Text = ""
        txtSaldoAtualBruno.Text = ContaBruno.Saldo

        If result Then
            txtSaldoAtualBruno.Text = ContaBruno.Saldo
            txtResultadoBruno.Text = "Saque realizado com sucesso!"
            ContaBruno.Extrato += $"{Now.ToString} Saque de {valorSacar}{Environment.NewLine}Saldo: {ContaBruno.Saldo}!{Environment.NewLine}"
        Else
            txtResultadoBruno.Text = "Saldo insuficiente para realizar saque!"
        End If

        txtExtratoBruno.Text = ContaBruno.Extrato
    End Sub

    Private Sub btnTransferirBruno_Click(sender As Object, e As EventArgs) Handles btnTransferirBruno.Click
        Dim valor As Double = Val(txtValorBruno.Text)

        Dim result As Boolean = ContaBruno.Transferencia(valor, ContaGabriela)

        If result = False Then
            txtResultadoBruno.Text = "Não foi possível realizar a transferencia"
        Else
            txtResultadoBruno.Text = "Tranferencia realizada com sucesso"
            txtSaldoAtualBruno.Text = ContaBruno.Saldo
            ContaBruno.Extrato += $"Tranferencia de {valor}{Environment.NewLine}Saldo: {ContaBruno.Saldo}!{Environment.NewLine}"
            txtExtratoBruno.Text = ContaBruno.Extrato


            txtSaldoAtual.Text = ContaGabriela.Saldo
            ContaGabriela.Extrato += $"Tranferencia recebida de {valor}{Environment.NewLine}Saldo: {ContaGabriela.Saldo}!{Environment.NewLine}"
            txtExtrato.Text = ContaGabriela.Extrato

        End If
    End Sub

    Private Sub btnTranferirGabriela_Click(sender As Object, e As EventArgs) Handles btnTranferirGabriela.Click
        Dim valor As Double = Val(txtValor.Text)

        Dim result As Boolean = ContaGabriela.Transferencia(valor, ContaBruno)

        If result = False Then
            txtResultado.Text = "Não foi possível realizar a transferencia"
        Else
            txtResultado.Text = "Tranferencia realizada com sucesso"
            txtSaldoAtual.Text = ContaGabriela.Saldo
            ContaGabriela.Extrato += $"Tranferencia de {valor}{Environment.NewLine}Saldo: {ContaGabriela.Saldo}!{Environment.NewLine}"
            txtExtrato.Text = ContaGabriela.Extrato


            txtSaldoAtualBruno.Text = ContaBruno.Saldo
            ContaBruno.Extrato += $"Tranferencia recebida de {valor}{Environment.NewLine}Saldo: {ContaBruno.Saldo}!{Environment.NewLine}"
            txtExtratoBruno.Text = ContaBruno.Extrato

        End If

    End Sub


End Class
