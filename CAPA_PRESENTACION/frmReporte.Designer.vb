<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvClientes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvClientes
        '
        Me.crvClientes.ActiveViewIndex = -1
        Me.crvClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvClientes.CachedPageNumberPerDoc = 10
        Me.crvClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvClientes.Location = New System.Drawing.Point(0, 0)
        Me.crvClientes.Name = "crvClientes"
        Me.crvClientes.Size = New System.Drawing.Size(534, 355)
        Me.crvClientes.TabIndex = 0
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 355)
        Me.Controls.Add(Me.crvClientes)
        Me.Name = "frmReporte"
        Me.Text = "frmReporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvClientes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
