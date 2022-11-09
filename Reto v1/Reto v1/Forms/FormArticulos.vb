Imports System.Data.Common

Public Class FormArticulos

    Public conexion As New Conexion
    Dim validaciones As New Validaciones

    Private Sub FormArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
        conexion.CargarDatosArticulos()

        dgvLista.DataSource = conexion.MiDataSet
        dgvLista.DataMember = "Articulos"
        editarCols()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtStock.Text = ""
        cbTipo.Text = ""
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim miDataRow As DataRow
        Dim i As Integer
        i = dgvLista.CurrentRow.Index
        miDataRow = conexion.MiDataSet.Tables("Articulos").Rows(i)
        miDataRow("Nombre") = txtNombre.Text
        miDataRow("Precio") = txtPrecio.Text
        miDataRow("Stock") = txtStock.Text
        miDataRow("Tipo") = cbTipo.Text
        conexion.MiDataAdapter.Update(conexion.MiDataSet, "Articulos")

        conexion.ActualizarDgvArticulos()
        MsgBox("Info del artículo modificada")
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim miDataRow As DataRow
        Dim i As Integer
        i = dgvLista.CurrentRow.Index
        miDataRow = conexion.MiDataSet.Tables("Articulos").Rows(i)
        miDataRow.Delete()
        Dim TablaBorrados As DataTable
        TablaBorrados = conexion.MiDataSet.Tables("Articulos").GetChanges(DataRowState.Deleted)
        conexion.MiDataAdapter.Update(TablaBorrados)
        conexion.MiDataSet.Tables("Articulos").AcceptChanges()
        btnCancelar.PerformClick()
        MsgBox("Artículo Eliminado")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim comprobaciones As Boolean = True
        If Validaciones.validarNombre(txtNombre.Text.Trim) = False Then
            MessageBox.Show(Validaciones.mensaje, "Informacion")
            txtNombre.Focus()
            comprobaciones = False
        End If

        If comprobaciones = True Then
            If validaciones.validarPrecio(txtPrecio.Text.Trim) = False Then
                MessageBox.Show(validaciones.mensaje, "Informacion")
                txtPrecio.Focus()
                comprobaciones = False
            End If
        End If

        If comprobaciones = True Then
            If validaciones.validarStock(txtStock.Text.Trim) = False Then
                MessageBox.Show(validaciones.mensaje, "Informacion")
                txtStock.Focus()
                comprobaciones = False
            End If
        End If

        If comprobaciones = True Then
            Dim miDataRow As DataRow
            miDataRow = conexion.MiDataSet.Tables("Articulos").NewRow
            miDataRow("Nombre") = txtNombre.Text
            miDataRow("Precio") = txtPrecio.Text
            miDataRow("Stock") = txtStock.Text
            miDataRow("Tipo") = cbTipo.Text


            conexion.MiDataSet.Tables("Articulos").Rows.Add(miDataRow)
            conexion.MiDataAdapter.Update(conexion.MiDataSet, "Articulos")

            conexion.ActualizarDgvArticulos()
            MsgBox("Artículo añadido")
        End If

    End Sub

    Private Sub dgvLista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellClick
        txtNombre.Text = dgvLista.SelectedCells.Item(1).Value
        txtPrecio.Text = dgvLista.SelectedCells.Item(2).Value
        txtStock.Text = dgvLista.SelectedCells.Item(3).Value
        cbTipo.Text = dgvLista.SelectedCells.Item(4).Value
    End Sub

    Private Sub Buscar()
        Dim dtTabla As New DataTable
        conexion.MiDataAdapter.Fill(dtTabla)
        Try
            Dim DataSet As New DataSet
            DataSet.Tables.Add(dtTabla.Copy)
            Dim DataView As New DataView(DataSet.Tables(0))

            DataView.RowFilter = cbBuscar.Text & " like '" & txtBuscar.Text & "%'"

            If DataView.Count <> 0 Then
                dgvLista.DataSource = DataView
            End If

        Catch ex As Exception
            MsgBox("Selecciona por que campo deseas buscar")
        End Try
        editarCols()
    End Sub

    Private Sub editarCols()
        dgvLista.Columns(0).Visible = False
        dgvLista.Columns(1).Width = 270
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub
End Class