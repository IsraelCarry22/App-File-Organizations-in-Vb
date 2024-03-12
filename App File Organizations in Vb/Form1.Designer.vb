<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ListFilesData = New DataGridView()
        Id = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Apellido = New DataGridViewTextBoxColumn()
        Unidad1 = New DataGridViewTextBoxColumn()
        Unidad2 = New DataGridViewTextBoxColumn()
        Unidad3 = New DataGridViewTextBoxColumn()
        Promedio = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        IDTXT = New TextBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveHowToolStripMenuItem = New ToolStripMenuItem()
        OrganizaToolStripMenuItem = New ToolStripMenuItem()
        SecuencialsToolStripMenuItem = New ToolStripMenuItem()
        HashToolStripMenuItem = New ToolStripMenuItem()
        AccesoAleatorioToolStripMenuItem = New ToolStripMenuItem()
        Add = New Button()
        NombreTXT = New TextBox()
        Label2 = New Label()
        Unidad1TXT = New TextBox()
        Label3 = New Label()
        ApellidoTXT = New TextBox()
        Label4 = New Label()
        Unidad3TXT = New TextBox()
        Label5 = New Label()
        Unidad2TXT = New TextBox()
        Label6 = New Label()
        Delete = New Button()
        Search = New Button()
        Edit = New Button()
        ViewAll = New Button()
        CType(ListFilesData, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListFilesData
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        ListFilesData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        ListFilesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListFilesData.Columns.AddRange(New DataGridViewColumn() {Id, Nombre, Apellido, Unidad1, Unidad2, Unidad3, Promedio})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        ListFilesData.DefaultCellStyle = DataGridViewCellStyle4
        ListFilesData.Location = New Point(12, 180)
        ListFilesData.Name = "ListFilesData"
        ListFilesData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        ListFilesData.Size = New Size(642, 258)
        ListFilesData.TabIndex = 0
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.Name = "Id"
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        ' 
        ' Apellido
        ' 
        Apellido.HeaderText = "Apellido"
        Apellido.Name = "Apellido"
        ' 
        ' Unidad1
        ' 
        Unidad1.HeaderText = "Unidad1"
        Unidad1.Name = "Unidad1"
        ' 
        ' Unidad2
        ' 
        Unidad2.HeaderText = "Unidad2"
        Unidad2.Name = "Unidad2"
        ' 
        ' Unidad3
        ' 
        Unidad3.HeaderText = "Unidad3"
        Unidad3.Name = "Unidad3"
        ' 
        ' Promedio
        ' 
        Promedio.HeaderText = "Promedio"
        Promedio.Name = "Promedio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F)
        Label1.Location = New Point(12, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 25)
        Label1.TabIndex = 1
        Label1.Text = "ID:"
        ' 
        ' IDTXT
        ' 
        IDTXT.Font = New Font("Segoe UI", 14.25F)
        IDTXT.Location = New Point(52, 64)
        IDTXT.Name = "IDTXT"
        IDTXT.Size = New Size(156, 33)
        IDTXT.TabIndex = 2
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, OrganizaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 29)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenToolStripMenuItem, SaveToolStripMenuItem, SaveHowToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 25)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(149, 26)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(149, 26)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' SaveHowToolStripMenuItem
        ' 
        SaveHowToolStripMenuItem.Name = "SaveHowToolStripMenuItem"
        SaveHowToolStripMenuItem.Size = New Size(149, 26)
        SaveHowToolStripMenuItem.Text = "Save How"
        ' 
        ' OrganizaToolStripMenuItem
        ' 
        OrganizaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SecuencialsToolStripMenuItem, HashToolStripMenuItem, AccesoAleatorioToolStripMenuItem})
        OrganizaToolStripMenuItem.Name = "OrganizaToolStripMenuItem"
        OrganizaToolStripMenuItem.Size = New Size(119, 25)
        OrganizaToolStripMenuItem.Text = "Organizations"
        ' 
        ' SecuencialsToolStripMenuItem
        ' 
        SecuencialsToolStripMenuItem.Name = "SecuencialsToolStripMenuItem"
        SecuencialsToolStripMenuItem.Size = New Size(195, 26)
        SecuencialsToolStripMenuItem.Text = "Secuencials"
        ' 
        ' HashToolStripMenuItem
        ' 
        HashToolStripMenuItem.Name = "HashToolStripMenuItem"
        HashToolStripMenuItem.Size = New Size(195, 26)
        HashToolStripMenuItem.Text = "Hash"
        ' 
        ' AccesoAleatorioToolStripMenuItem
        ' 
        AccesoAleatorioToolStripMenuItem.Name = "AccesoAleatorioToolStripMenuItem"
        AccesoAleatorioToolStripMenuItem.Size = New Size(195, 26)
        AccesoAleatorioToolStripMenuItem.Text = "Acceso Aleatorio"
        ' 
        ' Add
        ' 
        Add.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Add.Location = New Point(672, 180)
        Add.Name = "Add"
        Add.Size = New Size(116, 35)
        Add.TabIndex = 4
        Add.Text = "Agregar"
        Add.UseVisualStyleBackColor = True
        ' 
        ' NombreTXT
        ' 
        NombreTXT.Font = New Font("Segoe UI", 14.25F)
        NombreTXT.Location = New Point(103, 109)
        NombreTXT.Name = "NombreTXT"
        NombreTXT.Size = New Size(105, 33)
        NombreTXT.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F)
        Label2.Location = New Point(12, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 5
        Label2.Text = "Nombre:"
        ' 
        ' Unidad1TXT
        ' 
        Unidad1TXT.Font = New Font("Segoe UI", 14.25F)
        Unidad1TXT.Location = New Point(324, 109)
        Unidad1TXT.Name = "Unidad1TXT"
        Unidad1TXT.Size = New Size(98, 33)
        Unidad1TXT.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F)
        Label3.Location = New Point(226, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 25)
        Label3.TabIndex = 9
        Label3.Text = "Unidad 1:"
        ' 
        ' ApellidoTXT
        ' 
        ApellidoTXT.Font = New Font("Segoe UI", 14.25F)
        ApellidoTXT.Location = New Point(318, 64)
        ApellidoTXT.Name = "ApellidoTXT"
        ApellidoTXT.Size = New Size(104, 33)
        ApellidoTXT.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F)
        Label4.Location = New Point(226, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 7
        Label4.Text = "Apellido:"
        ' 
        ' Unidad3TXT
        ' 
        Unidad3TXT.Font = New Font("Segoe UI", 14.25F)
        Unidad3TXT.Location = New Point(556, 109)
        Unidad3TXT.Name = "Unidad3TXT"
        Unidad3TXT.Size = New Size(98, 33)
        Unidad3TXT.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F)
        Label5.Location = New Point(458, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 25)
        Label5.TabIndex = 13
        Label5.Text = "Unidad 3:"
        ' 
        ' Unidad2TXT
        ' 
        Unidad2TXT.Font = New Font("Segoe UI", 14.25F)
        Unidad2TXT.Location = New Point(556, 64)
        Unidad2TXT.Name = "Unidad2TXT"
        Unidad2TXT.Size = New Size(98, 33)
        Unidad2TXT.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F)
        Label6.Location = New Point(458, 67)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 25)
        Label6.TabIndex = 11
        Label6.Text = "Unidad 2:"
        ' 
        ' Delete
        ' 
        Delete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Delete.Location = New Point(672, 221)
        Delete.Name = "Delete"
        Delete.Size = New Size(116, 35)
        Delete.TabIndex = 15
        Delete.Text = "Eliminar"
        Delete.UseVisualStyleBackColor = True
        ' 
        ' Search
        ' 
        Search.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Search.Location = New Point(672, 262)
        Search.Name = "Search"
        Search.Size = New Size(116, 35)
        Search.TabIndex = 16
        Search.Text = "Buscar"
        Search.UseVisualStyleBackColor = True
        ' 
        ' Edit
        ' 
        Edit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Edit.Location = New Point(672, 303)
        Edit.Name = "Edit"
        Edit.Size = New Size(116, 35)
        Edit.TabIndex = 17
        Edit.Text = "Editar"
        Edit.UseVisualStyleBackColor = True
        ' 
        ' ViewAll
        ' 
        ViewAll.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ViewAll.Location = New Point(672, 344)
        ViewAll.Name = "ViewAll"
        ViewAll.Size = New Size(116, 35)
        ViewAll.TabIndex = 18
        ViewAll.Text = "Mostrar todos"
        ViewAll.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ViewAll)
        Controls.Add(Edit)
        Controls.Add(Search)
        Controls.Add(Delete)
        Controls.Add(Unidad3TXT)
        Controls.Add(Label5)
        Controls.Add(Unidad2TXT)
        Controls.Add(Label6)
        Controls.Add(Unidad1TXT)
        Controls.Add(Label3)
        Controls.Add(ApellidoTXT)
        Controls.Add(Label4)
        Controls.Add(NombreTXT)
        Controls.Add(Label2)
        Controls.Add(Add)
        Controls.Add(IDTXT)
        Controls.Add(Label1)
        Controls.Add(ListFilesData)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        CType(ListFilesData, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListFilesData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents IDTXT As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveHowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Add As Button
    Friend WithEvents SecuencialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesoAleatorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NombreTXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Unidad1TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ApellidoTXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Unidad3TXT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Unidad2TXT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Delete As Button
    Friend WithEvents Search As Button
    Friend WithEvents Edit As Button
    Friend WithEvents ViewAll As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Unidad1 As DataGridViewTextBoxColumn
    Friend WithEvents Unidad2 As DataGridViewTextBoxColumn
    Friend WithEvents Unidad3 As DataGridViewTextBoxColumn
    Friend WithEvents Promedio As DataGridViewTextBoxColumn

End Class
