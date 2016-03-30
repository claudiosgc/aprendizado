Option Explicit On 'Todas as variáveis devem ser delcaradas
Option Strict On 'Impedir conversões implicitas

Public Class frmCadastro

    'Cria classe Usuário
    Public Class clsUsuario

        'Declaração de variáveis
        Private f_strNome As String
        Private f_strCPF As String
        Private f_strIdentidade As String
        Private f_strTelefone As String
        Private f_lstUsuario As List(Of clsUsuario)

        'Construtor
        Public Sub New()

            f_strNome = ""
            f_strCPF = ""
            f_strIdentidade = ""
            f_strTelefone = ""

        End Sub

        'Propriedade Publicas
        Public Property Nome As String
            Get
                Return f_strNome
            End Get
            Set(value As String)
                f_strNome = Trim(value)
            End Set
        End Property

        Public Property CPF As String
            Get
                Return f_strCPF
            End Get
            Set(value As String)
                f_strCPF = Trim(value)
            End Set
        End Property

        Public Property Identidade As String
            Get
                Return f_strIdentidade
            End Get
            Set(value As String)
                f_strIdentidade = Trim(value)
            End Set
        End Property

        Public Property Telefone As String
            Get
                Return f_strTelefone
            End Get
            Set(value As String)
                f_strTelefone = Trim(value)
            End Set
        End Property

    End Class

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        Try

            Dim clsUsuario As New clsUsuario

            clsUsuario.Nome = txtNome.Text
            clsUsuario.CPF = txtCPF.Text
            clsUsuario.Identidade = txtIdentidade.Text
            clsUsuario.Telefone = txtTelefone.Text

        Catch ex As Exception

        End Try

    End Sub

End Class