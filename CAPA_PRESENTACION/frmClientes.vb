Imports CAPA_NEGOCIO

Public Class frmClientes
    Dim objNeg As New CLienteNG

    Sub PaisListar()
        cboPais.DataSource = objNeg.PaisListar.Tables(0)
        cboPais.DisplayMember = "NombrePais"
        cboPais.ValueMember = "IdPais"
    End Sub


    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaisListar()
        dgClientes.DataSource = objNeg.ClienteListar.Tables(0)
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        For Each objeto As Object In Me.Controls
            If TypeOf objeto Is TextBox Then objeto.Text = String.Empty
        Next
        cboPais.SelectedIndex = -1
        txtCodigo.Focus()
    End Sub
End Class