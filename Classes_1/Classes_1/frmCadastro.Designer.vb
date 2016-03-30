<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastro
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
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.txtIdentidade = New System.Windows.Forms.TextBox()
        Me.lblIdentidade = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(12, 44)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(343, 20)
        Me.txtNome.TabIndex = 0
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(12, 87)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(116, 20)
        Me.txtCPF.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(9, 28)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(9, 71)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(27, 13)
        Me.lblCPF.TabIndex = 3
        Me.lblCPF.Text = "CPF"
        '
        'txtIdentidade
        '
        Me.txtIdentidade.Location = New System.Drawing.Point(134, 87)
        Me.txtIdentidade.Name = "txtIdentidade"
        Me.txtIdentidade.Size = New System.Drawing.Size(115, 20)
        Me.txtIdentidade.TabIndex = 4
        '
        'lblIdentidade
        '
        Me.lblIdentidade.AutoSize = True
        Me.lblIdentidade.Location = New System.Drawing.Point(131, 71)
        Me.lblIdentidade.Name = "lblIdentidade"
        Me.lblIdentidade.Size = New System.Drawing.Size(57, 13)
        Me.lblIdentidade.TabIndex = 5
        Me.lblIdentidade.Text = "Identidade"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(255, 87)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefone.TabIndex = 6
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(252, 71)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefone.TabIndex = 7
        Me.lblTelefone.Text = "Telefone"
        '
        'frmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 283)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.lblIdentidade)
        Me.Controls.Add(Me.txtIdentidade)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.txtNome)
        Me.Name = "frmCadastro"
        Me.Text = "frmCadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCPF As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblCPF As System.Windows.Forms.Label
    Friend WithEvents txtIdentidade As System.Windows.Forms.TextBox
    Friend WithEvents lblIdentidade As System.Windows.Forms.Label
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
End Class
