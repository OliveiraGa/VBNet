<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal_02
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnNumerosInteiros = New System.Windows.Forms.Button()
        Me.btnNumerosFlutuantes = New System.Windows.Forms.Button()
        Me.btnConversaoNumero = New System.Windows.Forms.Button()
        Me.txt_Numerado = New System.Windows.Forms.TextBox()
        Me.txt_Denominador = New System.Windows.Forms.TextBox()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNumerosInteiros
        '
        Me.btnNumerosInteiros.Location = New System.Drawing.Point(12, 37)
        Me.btnNumerosInteiros.Name = "btnNumerosInteiros"
        Me.btnNumerosInteiros.Size = New System.Drawing.Size(109, 38)
        Me.btnNumerosInteiros.TabIndex = 1
        Me.btnNumerosInteiros.Text = "Botão Numeros Inteiros"
        Me.btnNumerosInteiros.UseVisualStyleBackColor = True
        '
        'btnNumerosFlutuantes
        '
        Me.btnNumerosFlutuantes.Location = New System.Drawing.Point(12, 90)
        Me.btnNumerosFlutuantes.Name = "btnNumerosFlutuantes"
        Me.btnNumerosFlutuantes.Size = New System.Drawing.Size(109, 38)
        Me.btnNumerosFlutuantes.TabIndex = 2
        Me.btnNumerosFlutuantes.Text = "Botao Numeros Flutuantes"
        Me.btnNumerosFlutuantes.UseVisualStyleBackColor = True
        '
        'btnConversaoNumero
        '
        Me.btnConversaoNumero.Location = New System.Drawing.Point(12, 146)
        Me.btnConversaoNumero.Name = "btnConversaoNumero"
        Me.btnConversaoNumero.Size = New System.Drawing.Size(109, 38)
        Me.btnConversaoNumero.TabIndex = 3
        Me.btnConversaoNumero.Text = "Conversao de numeros"
        Me.btnConversaoNumero.UseVisualStyleBackColor = True
        '
        'txt_Numerado
        '
        Me.txt_Numerado.Location = New System.Drawing.Point(163, 37)
        Me.txt_Numerado.Name = "txt_Numerado"
        Me.txt_Numerado.Size = New System.Drawing.Size(204, 20)
        Me.txt_Numerado.TabIndex = 4
        '
        'txt_Denominador
        '
        Me.txt_Denominador.Location = New System.Drawing.Point(163, 63)
        Me.txt_Denominador.Name = "txt_Denominador"
        Me.txt_Denominador.Size = New System.Drawing.Size(204, 20)
        Me.txt_Denominador.TabIndex = 5
        '
        'btnResultado
        '
        Me.btnResultado.Location = New System.Drawing.Point(291, 90)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(75, 23)
        Me.btnResultado.TabIndex = 6
        Me.btnResultado.Text = "Resultado"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'Frm_TelaPrincipal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 319)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.txt_Denominador)
        Me.Controls.Add(Me.txt_Numerado)
        Me.Controls.Add(Me.btnConversaoNumero)
        Me.Controls.Add(Me.btnNumerosFlutuantes)
        Me.Controls.Add(Me.btnNumerosInteiros)
        Me.Name = "Frm_TelaPrincipal_02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2 - Criando Variaveis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNumerosInteiros As Button
    Friend WithEvents btnNumerosFlutuantes As Button
    Friend WithEvents btnConversaoNumero As Button
    Friend WithEvents txt_Numerado As TextBox
    Friend WithEvents txt_Denominador As TextBox
    Friend WithEvents btnResultado As Button
End Class
