<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_04
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_CliqueAqui = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Idade = New System.Windows.Forms.TextBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Grb_Pais = New System.Windows.Forms.GroupBox()
        Me.Rdb_SIm = New System.Windows.Forms.RadioButton()
        Me.Rdb_Nao = New System.Windows.Forms.RadioButton()
        Me.Grb_Pais.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_CliqueAqui
        '
        Me.Btn_CliqueAqui.Location = New System.Drawing.Point(15, 147)
        Me.Btn_CliqueAqui.Name = "Btn_CliqueAqui"
        Me.Btn_CliqueAqui.Size = New System.Drawing.Size(275, 24)
        Me.Btn_CliqueAqui.TabIndex = 1
        Me.Btn_CliqueAqui.Text = "Checagem da permissão de entrada"
        Me.Btn_CliqueAqui.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_NomeProjeto.TabIndex = 2
        Me.Lbl_NomeProjeto.Text = "4 - Controle de Fluxo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Idade"
        '
        'Txt_Idade
        '
        Me.Txt_Idade.Location = New System.Drawing.Point(16, 121)
        Me.Txt_Idade.Name = "Txt_Idade"
        Me.Txt_Idade.Size = New System.Drawing.Size(101, 20)
        Me.Txt_Idade.TabIndex = 4
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(16, 199)
        Me.Txt_Resultado.Multiline = True
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(274, 65)
        Me.Txt_Resultado.TabIndex = 5
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(16, 180)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_Resultado.TabIndex = 6
        Me.Lbl_Resultado.Text = "Resultado"
        '
        'Grb_Pais
        '
        Me.Grb_Pais.Controls.Add(Me.Rdb_Nao)
        Me.Grb_Pais.Controls.Add(Me.Rdb_SIm)
        Me.Grb_Pais.Location = New System.Drawing.Point(122, 75)
        Me.Grb_Pais.Name = "Grb_Pais"
        Me.Grb_Pais.Size = New System.Drawing.Size(168, 66)
        Me.Grb_Pais.TabIndex = 7
        Me.Grb_Pais.TabStop = False
        Me.Grb_Pais.Text = "Acompanhado dos pais?"
        '
        'Rdb_SIm
        '
        Me.Rdb_SIm.AutoSize = True
        Me.Rdb_SIm.Location = New System.Drawing.Point(7, 24)
        Me.Rdb_SIm.Name = "Rdb_SIm"
        Me.Rdb_SIm.Size = New System.Drawing.Size(42, 17)
        Me.Rdb_SIm.TabIndex = 0
        Me.Rdb_SIm.TabStop = True
        Me.Rdb_SIm.Text = "Sim"
        Me.Rdb_SIm.UseVisualStyleBackColor = True
        '
        'Rdb_Nao
        '
        Me.Rdb_Nao.AutoSize = True
        Me.Rdb_Nao.Location = New System.Drawing.Point(63, 25)
        Me.Rdb_Nao.Name = "Rdb_Nao"
        Me.Rdb_Nao.Size = New System.Drawing.Size(45, 17)
        Me.Rdb_Nao.TabIndex = 1
        Me.Rdb_Nao.TabStop = True
        Me.Rdb_Nao.Text = "Não"
        Me.Rdb_Nao.UseVisualStyleBackColor = True
        '
        'Frm_Principal_04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 307)
        Me.Controls.Add(Me.Grb_Pais)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Txt_Idade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btn_CliqueAqui)
        Me.Name = "Frm_Principal_04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação VB"
        Me.Grb_Pais.ResumeLayout(False)
        Me.Grb_Pais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_CliqueAqui As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Idade As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Grb_Pais As GroupBox
    Friend WithEvents Rdb_Nao As RadioButton
    Friend WithEvents Rdb_SIm As RadioButton
End Class

