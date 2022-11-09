Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class FormTpv

    Private btnPanel As IconButton
    Private nuevoBoton As Panel
    Private formHijoActual As Form

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        nuevoBoton = New Panel()
        nuevoBoton.Size = New Size(7, 74)
        PanelMenu.Controls.Add(nuevoBoton)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ActivateButton(senderbtn As Object, customColor As Color)
        If senderbtn IsNot Nothing Then
            disableButton()
            btnPanel = CType(senderbtn, IconButton)
            btnPanel.BackColor = Color.SkyBlue
            btnPanel.ForeColor = customColor
            btnPanel.IconColor = customColor
            btnPanel.TextAlign = ContentAlignment.MiddleCenter
            btnPanel.ImageAlign = ContentAlignment.MiddleRight
            btnPanel.TextImageRelation = TextImageRelation.TextBeforeImage

            nuevoBoton.BackColor = customColor
            nuevoBoton.Location = New Point(0, btnPanel.Location.Y)
            nuevoBoton.Visible = True
            nuevoBoton.BringToFront()

            ipbHome.IconChar = btnPanel.IconChar
            ipbHome.IconColor = customColor

        End If
    End Sub

    Private Sub disableButton()
        If btnPanel IsNot Nothing Then
            btnPanel.BackColor = Color.MidnightBlue
            btnPanel.ForeColor = Color.Gainsboro
            btnPanel.IconColor = Color.Gainsboro
            btnPanel.TextAlign = ContentAlignment.MiddleLeft
            btnPanel.ImageAlign = ContentAlignment.MiddleLeft
            btnPanel.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(formHijo As Form)
        If formHijoActual IsNot Nothing Then
            formHijoActual.Close()
        End If
        formHijoActual = formHijo

        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill
        PanelEscritorio.Controls.Add(formHijo)
        PanelEscritorio.Tag = formHijo
        formHijo.BringToFront()
        formHijo.Show()
        lblTitulo.Text = formHijo.Text
    End Sub

    Private Sub ibPedido_Click(sender As Object, e As EventArgs) Handles ibPedido.Click
        ActivateButton(sender, Color.MidnightBlue)
        OpenChildForm(New FormPedidos)
    End Sub

    Private Sub ibEmpleados_Click(sender As Object, e As EventArgs) Handles ibEmpleados.Click
        ActivateButton(sender, Color.MidnightBlue)
        OpenChildForm(New FormEmpleados)
    End Sub

    Private Sub ibArticulos_Click(sender As Object, e As EventArgs) Handles ibArticulos.Click
        ActivateButton(sender, Color.MidnightBlue)
        OpenChildForm(New FormArticulos)
    End Sub

    Private Sub pbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click
        If formHijoActual IsNot Nothing Then
            formHijoActual.Close()
        End If
        reset()
    End Sub

    Private Sub reset()
        disableButton()
        nuevoBoton.Visible = False
        ipbHome.IconChar = IconChar.Home
        ipbHome.IconColor = Color.SkyBlue
        lblTitulo.Text = "Home"
    End Sub


    <DllImport("user32.DLL”, EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapure()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal Wind As System.IntPtr, ByVal wii As Integer, ByVal waram As Integer, ByVal Param As Integer)
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDown
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
