Imports System.Data.SqlClient
Imports System.Net.Security
Imports System.Runtime.InteropServices

Public Class Login

    Public conexion As New Conexion

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '---------------------------------------------------------------------------------------------------------------------------------------------------
        'QUITAR ESTAS LINEAS PARA EL LOGIN FUNCIONAL
        TextBox1.Text = "Cangrejo"
        TextBox2.Text = "Dinero247"
        Dim miTabla As DataTable
        Dim miDataRow() As DataRow
        Dim User As DataRow
        'Dim miDataRow2 As DataRow
        'miDataRow = conexion.MiDataSet.Tables("Empleados")


        Try
        miTabla = conexion.MiDataSet.Tables("Empleados")
            miDataRow = miTabla.Select("Nombre = '" & CStr(TextBox1.Text) & "' AND Contraseña = '" & CStr(TextBox2.Text) & "'")
            User = miDataRow(0)

            If miDataRow Is Nothing Then
            Else
                If TextBox1.Text <> "Cangrejo" Then
                    FormTpv.ibArticulos.Hide()
                    FormTpv.ibEmpleados.Hide()
                    FormTpv.Show()
                    Me.Hide()
                Else
                    FormTpv.Show()
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Usuario Incorrecto")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        End Try
    End Sub


    '---------------------------------------------------------------------------------------------------------------------------------------------------
    'DISEÑO PARA QUE NO APAREZCAN LOS CONTROLES  POR DEFECTO DE LA BARRA SUPERIOR
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------
    'DISEÑO BARRA SUPERIOR FORMULARIO

    <DllImport("user32.DLL”, EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapure()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal Wind As System.IntPtr, ByVal wii As Integer, ByVal waram As Integer, ByVal Param As Integer)
    End Sub

    Private Sub PanelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDown
        ReleaseCapure()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FormTpv_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------
    'BOTONES AUXILIARES

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximizar_Click_1(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimizar_Click_1(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

End Class