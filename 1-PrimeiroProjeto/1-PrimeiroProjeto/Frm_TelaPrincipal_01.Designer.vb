<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TelaPrincipal_01
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_CliqueAqui
        '
        Me.Btn_CliqueAqui.Location = New System.Drawing.Point(106, 75)
        Me.Btn_CliqueAqui.Name = "Btn_CliqueAqui"
        Me.Btn_CliqueAqui.Size = New System.Drawing.Size(114, 49)
        Me.Btn_CliqueAqui.TabIndex = 1
        Me.Btn_CliqueAqui.Text = "Clique Aqui"
        Me.Btn_CliqueAqui.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1 - Primeiro Projeto"
        '
        'Frm_TelaPrincipal_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 203)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_CliqueAqui)
        Me.Name = "Frm_TelaPrincipal_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_CliqueAqui As Button
    Friend WithEvents Label1 As Label
End Class
