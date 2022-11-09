<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbEditar = New System.Windows.Forms.GroupBox()
        Me.cbTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbLista = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbBuscar = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvLista = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.gbEditar.SuspendLayout()
        Me.gbLista.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEditar
        '
        Me.gbEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbEditar.Controls.Add(Me.cbTipo)
        Me.gbEditar.Controls.Add(Me.btnBorrar)
        Me.gbEditar.Controls.Add(Me.btnCancelar)
        Me.gbEditar.Controls.Add(Me.btnEditar)
        Me.gbEditar.Controls.Add(Me.btnNuevo)
        Me.gbEditar.Controls.Add(Me.lblTipo)
        Me.gbEditar.Controls.Add(Me.txtStock)
        Me.gbEditar.Controls.Add(Me.lblStock)
        Me.gbEditar.Controls.Add(Me.txtPrecio)
        Me.gbEditar.Controls.Add(Me.lblPrecio)
        Me.gbEditar.Controls.Add(Me.txtNombre)
        Me.gbEditar.Controls.Add(Me.lblNombre)
        Me.gbEditar.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbEditar.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.gbEditar.Location = New System.Drawing.Point(38, 41)
        Me.gbEditar.Name = "gbEditar"
        Me.gbEditar.Size = New System.Drawing.Size(623, 574)
        Me.gbEditar.TabIndex = 0
        Me.gbEditar.TabStop = False
        Me.gbEditar.Text = "Gestión De Articulos"
        '
        'cbTipo
        '
        Me.cbTipo.BackColor = System.Drawing.Color.Transparent
        Me.cbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTipo.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbTipo.ItemHeight = 30
        Me.cbTipo.Items.AddRange(New Object() {"Principal", "Entrante", "Bebida"})
        Me.cbTipo.Location = New System.Drawing.Point(159, 339)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(229, 36)
        Me.cbTipo.TabIndex = 17
        '
        'btnBorrar
        '
        Me.btnBorrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBorrar.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnBorrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.Location = New System.Drawing.Point(428, 424)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(178, 47)
        Me.btnBorrar.TabIndex = 16
        Me.btnBorrar.Text = "Borrar Artículo"
        '
        'btnCancelar
        '
        Me.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancelar.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(428, 489)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(178, 47)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEditar
        '
        Me.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditar.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(224, 489)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(178, 47)
        Me.btnEditar.TabIndex = 7
        Me.btnEditar.Text = "Editar Artículo"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNuevo.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(20, 489)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(178, 47)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo Artículo"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(34, 356)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(42, 19)
        Me.lblTipo.TabIndex = 4
        Me.lblTipo.Text = "Tipo"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(159, 264)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(135, 28)
        Me.txtStock.TabIndex = 4
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(34, 267)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(54, 19)
        Me.lblStock.TabIndex = 2
        Me.lblStock.Text = "Stock"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(159, 180)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(135, 28)
        Me.txtPrecio.TabIndex = 3
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(34, 183)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(61, 19)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(159, 94)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(419, 28)
        Me.txtNombre.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(34, 97)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(76, 19)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'gbLista
        '
        Me.gbLista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbLista.Controls.Add(Me.txtBuscar)
        Me.gbLista.Controls.Add(Me.cbBuscar)
        Me.gbLista.Controls.Add(Me.dgvLista)
        Me.gbLista.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbLista.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.gbLista.Location = New System.Drawing.Point(699, 41)
        Me.gbLista.Name = "gbLista"
        Me.gbLista.Size = New System.Drawing.Size(623, 574)
        Me.gbLista.TabIndex = 2
        Me.gbLista.TabStop = False
        Me.gbLista.Text = "Listado De Articulos"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(239, 36)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(362, 28)
        Me.txtBuscar.TabIndex = 2
        '
        'cbBuscar
        '
        Me.cbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.cbBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscar.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbBuscar.ItemHeight = 30
        Me.cbBuscar.Items.AddRange(New Object() {"Nombre", "Tipo"})
        Me.cbBuscar.Location = New System.Drawing.Point(17, 32)
        Me.cbBuscar.Name = "cbBuscar"
        Me.cbBuscar.Size = New System.Drawing.Size(216, 36)
        Me.cbBuscar.TabIndex = 1
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.ColumnHeadersHeight = 35
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLista.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLista.Location = New System.Drawing.Point(17, 94)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.RowHeadersVisible = False
        Me.dgvLista.RowHeadersWidth = 51
        Me.dgvLista.RowTemplate.Height = 29
        Me.dgvLista.Size = New System.Drawing.Size(584, 456)
        Me.dgvLista.TabIndex = 0
        Me.dgvLista.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvLista.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvLista.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvLista.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvLista.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvLista.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvLista.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLista.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLista.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvLista.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dgvLista.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvLista.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvLista.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvLista.ThemeStyle.ReadOnly = True
        Me.dgvLista.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvLista.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvLista.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dgvLista.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgvLista.ThemeStyle.RowsStyle.Height = 29
        Me.dgvLista.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLista.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'FormArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1374, 668)
        Me.Controls.Add(Me.gbLista)
        Me.Controls.Add(Me.gbEditar)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormArticulos"
        Me.Text = "Gestion de Articulos"
        Me.gbEditar.ResumeLayout(False)
        Me.gbEditar.PerformLayout()
        Me.gbLista.ResumeLayout(False)
        Me.gbLista.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEditar As GroupBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbLista As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cbBuscar As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dgvLista As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbTipo As Guna.UI2.WinForms.Guna2ComboBox
End Class
