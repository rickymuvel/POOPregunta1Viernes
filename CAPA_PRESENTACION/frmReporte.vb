Public Class frmReporte

    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reporte As New rptClientesPais
        crvClientes.ReportSource = reporte
    End Sub
End Class