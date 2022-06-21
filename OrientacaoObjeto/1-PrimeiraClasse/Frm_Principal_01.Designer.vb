<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_01
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
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.btnAcao = New System.Windows.Forms.Button()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblIncremento = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtIncremento = New System.Windows.Forms.TextBox()
        Me.btnAcao2 = New System.Windows.Forms.Button()
        Me.btnValRef = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(13, 24)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(39, 13)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "Label1"
        '
        'btnAcao
        '
        Me.btnAcao.Location = New System.Drawing.Point(16, 56)
        Me.btnAcao.Name = "btnAcao"
        Me.btnAcao.Size = New System.Drawing.Size(108, 42)
        Me.btnAcao.TabIndex = 1
        Me.btnAcao.Text = "Conta Gabriela"
        Me.btnAcao.UseVisualStyleBackColor = True
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(13, 122)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(34, 13)
        Me.lblSaldo.TabIndex = 2
        Me.lblSaldo.Text = "Saldo"
        '
        'lblIncremento
        '
        Me.lblIncremento.AutoSize = True
        Me.lblIncremento.Location = New System.Drawing.Point(124, 122)
        Me.lblIncremento.Name = "lblIncremento"
        Me.lblIncremento.Size = New System.Drawing.Size(60, 13)
        Me.lblIncremento.TabIndex = 3
        Me.lblIncremento.Text = "Incremento"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(16, 138)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 4
        '
        'txtIncremento
        '
        Me.txtIncremento.Location = New System.Drawing.Point(127, 138)
        Me.txtIncremento.Name = "txtIncremento"
        Me.txtIncremento.Size = New System.Drawing.Size(100, 20)
        Me.txtIncremento.TabIndex = 5
        '
        'btnAcao2
        '
        Me.btnAcao2.Location = New System.Drawing.Point(130, 56)
        Me.btnAcao2.Name = "btnAcao2"
        Me.btnAcao2.Size = New System.Drawing.Size(108, 42)
        Me.btnAcao2.TabIndex = 6
        Me.btnAcao2.Text = "Conta Bruno"
        Me.btnAcao2.UseVisualStyleBackColor = True
        '
        'btnValRef
        '
        Me.btnValRef.Location = New System.Drawing.Point(244, 56)
        Me.btnValRef.Name = "btnValRef"
        Me.btnValRef.Size = New System.Drawing.Size(108, 42)
        Me.btnValRef.TabIndex = 7
        Me.btnValRef.Text = "Clique Aqui"
        Me.btnValRef.UseVisualStyleBackColor = True
        '
        'Frm_Principal_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 289)
        Me.Controls.Add(Me.btnValRef)
        Me.Controls.Add(Me.btnAcao2)
        Me.Controls.Add(Me.txtIncremento)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.lblIncremento)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.btnAcao)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Name = "Frm_Principal_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrincipal As Label
    Friend WithEvents btnAcao As Button
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblIncremento As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtIncremento As TextBox
    Friend WithEvents btnAcao2 As Button
    Friend WithEvents btnValRef As Button
End Class
