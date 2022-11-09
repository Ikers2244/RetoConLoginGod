Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Conexion

    Public MiDataAdapter, MiDataAdapter2 As SqlDataAdapter
    Public MiDataSet As DataSet
    Public MiConexion As New SqlConnection
    Public CadenaConexion = "SERVER=PC-FIRE\SQLEXPRESS; INTEGRATED Security=SSPI;DATABASE=reto"

    Public Sub Conectar()
        Try
            MiConexion.ConnectionString = CadenaConexion
            MiDataAdapter = New SqlDataAdapter("Select * From Articulos", MiConexion)
            MiDataAdapter2 = New SqlDataAdapter("Select * From Empleados", MiConexion)

            Dim MicommBuilder As SqlCommandBuilder = New SqlCommandBuilder(MiDataAdapter)
            Dim MicommBuilder2 As SqlCommandBuilder = New SqlCommandBuilder(MiDataAdapter2)

            MiDataSet = New DataSet

            MiConexion.Open()
            MiDataAdapter.Fill(MiDataSet, "Articulos")
            MiDataAdapter2.Fill(MiDataSet, "Empleados")
            MiConexion.Close()

        Catch ex As Exception
            MsgBox("Error al crear la conexion:" & vbCrLf & ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub CargarDatosArticulos()
        Dim MiDataRow As DataRow
        MiDataRow = MiDataSet.Tables("Articulos").Rows(0)
        FormArticulos.txtNombre.Text = MiDataRow("Nombre")
        FormArticulos.txtPrecio.Text = MiDataRow("Precio")
        FormArticulos.txtStock.Text = MiDataRow("Stock")
        FormArticulos.cbTipo.Text = MiDataRow("Tipo")
    End Sub

    Public Sub CargarDatosEmpleados()
        Dim MiDataRow As DataRow
        MiDataRow = MiDataSet.Tables("Empleados").Rows(0)
        FormEmpleados.txtNombre.Text = MiDataRow("Nombre")
        FormEmpleados.txtPswd.Text = MiDataRow("Contraseña")
        FormEmpleados.txtSueldo.Text = MiDataRow("Sueldo")
        FormEmpleados.cbAdmin.Text = MiDataRow("Admin")
        FormEmpleados.txtPuesto.Text = MiDataRow("Puesto")
    End Sub

    Public Sub ActualizarDgvArticulos()
        Dim dtTabla As New DataTable
        Dim sql = "SELECT * FROM Articulos"

        Try
            Dim conectorSQL = New SqlClient.SqlConnection(CadenaConexion)
            conectorSQL.Open()
            Dim comando = New SqlClient.SqlCommand(sql, conectorSQL)

            Dim adaptador = New SqlClient.SqlDataAdapter(comando)
            MiDataAdapter.Fill(dtTabla)
            FormArticulos.dgvLista.DataSource = dtTabla

            conectorSQL.Close()
        Catch ex As Exception
            MsgBox("ERROR AL CONECTAR")
        End Try
    End Sub

    Public Sub ActualizarDgvEmpleados()
        Dim dtTabla As New DataTable
        Dim sql = "SELECT * FROM Empleados"

        Try
            Dim conectorSQL = New SqlClient.SqlConnection(CadenaConexion)
            conectorSQL.Open()
            Dim comando = New SqlClient.SqlCommand(sql, conectorSQL)

            Dim adaptador = New SqlClient.SqlDataAdapter(comando)
            MiDataAdapter2.Fill(dtTabla)
            FormEmpleados.dgvLista.DataSource = dtTabla

            conectorSQL.Close()
        Catch ex As Exception
            MsgBox("ERROR AL CONECTAR")
        End Try
    End Sub

End Class
