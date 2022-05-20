<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TelaPrincipal
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
        Me.Btn_Principal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(120, 64)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Principal.TabIndex = 0
        Me.Btn_Principal.Text = "Teste 1"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Frm_TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 203)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Name = "Frm_TelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1 - Projeto"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Principal As Button
End Class
