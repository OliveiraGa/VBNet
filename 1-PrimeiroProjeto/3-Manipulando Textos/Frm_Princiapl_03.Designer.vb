<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Princiapl_03
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
        Me.btn = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txt_Str = New System.Windows.Forms.TextBox()
        Me.btn_TxtVal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Curso = New System.Windows.Forms.TextBox()
        Me.btn_Adicionar = New System.Windows.Forms.Button()
        Me.txt_ListCurso = New System.Windows.Forms.TextBox()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(12, 43)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(96, 49)
        Me.btn.TabIndex = 1
        Me.btn.Text = "Clique Aqui"
        Me.btn.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(9, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(99, 13)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "Manipulando textos"
        '
        'txt_Str
        '
        Me.txt_Str.Location = New System.Drawing.Point(148, 43)
        Me.txt_Str.Name = "txt_Str"
        Me.txt_Str.Size = New System.Drawing.Size(162, 20)
        Me.txt_Str.TabIndex = 3
        '
        'btn_TxtVal
        '
        Me.btn_TxtVal.Location = New System.Drawing.Point(148, 69)
        Me.btn_TxtVal.Name = "btn_TxtVal"
        Me.btn_TxtVal.Size = New System.Drawing.Size(75, 23)
        Me.btn_TxtVal.TabIndex = 4
        Me.btn_TxtVal.Text = "Convert"
        Me.btn_TxtVal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Digite o seu curso preferido"
        '
        'txt_Curso
        '
        Me.txt_Curso.Location = New System.Drawing.Point(12, 163)
        Me.txt_Curso.Name = "txt_Curso"
        Me.txt_Curso.Size = New System.Drawing.Size(208, 20)
        Me.txt_Curso.TabIndex = 6
        '
        'btn_Adicionar
        '
        Me.btn_Adicionar.Location = New System.Drawing.Point(226, 160)
        Me.btn_Adicionar.Name = "btn_Adicionar"
        Me.btn_Adicionar.Size = New System.Drawing.Size(96, 23)
        Me.btn_Adicionar.TabIndex = 7
        Me.btn_Adicionar.Text = "Adicionar"
        Me.btn_Adicionar.UseVisualStyleBackColor = True
        '
        'txt_ListCurso
        '
        Me.txt_ListCurso.Location = New System.Drawing.Point(12, 189)
        Me.txt_ListCurso.Multiline = True
        Me.txt_ListCurso.Name = "txt_ListCurso"
        Me.txt_ListCurso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_ListCurso.Size = New System.Drawing.Size(412, 87)
        Me.txt_ListCurso.TabIndex = 8
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(328, 160)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(96, 23)
        Me.btnResult.TabIndex = 9
        Me.btnResult.Text = "Mostrar Lista"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'Frm_Princiapl_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 288)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.txt_ListCurso)
        Me.Controls.Add(Me.btn_Adicionar)
        Me.Controls.Add(Me.txt_Curso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_TxtVal)
        Me.Controls.Add(Me.txt_Str)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btn)
        Me.Name = "Frm_Princiapl_03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3-Manipulando Textos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents txt_Str As TextBox
    Friend WithEvents btn_TxtVal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Curso As TextBox
    Friend WithEvents btn_Adicionar As Button
    Friend WithEvents txt_ListCurso As TextBox
    Friend WithEvents btnResult As Button
End Class
