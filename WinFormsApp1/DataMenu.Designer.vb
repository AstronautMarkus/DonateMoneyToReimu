<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataMenu
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DataMenu))
        btnReverse = New Button()
        Label1 = New Label()
        DataGridConsejos = New DataGridView()
        BtnCargarDatos = New Button()
        DataGridDonaciones = New DataGridView()
        Label2 = New Label()
        DonacionesTotalTextBox = New TextBox()
        BtnDeleteConsejos = New Button()
        Label3 = New Label()
        Button1 = New Button()
        CType(DataGridConsejos, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridDonaciones, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnReverse
        ' 
        btnReverse.Font = New Font("Roboto Cn", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnReverse.Location = New Point(526, 483)
        btnReverse.Name = "btnReverse"
        btnReverse.Size = New Size(242, 62)
        btnReverse.TabIndex = 1
        btnReverse.Text = "Menú principal"
        btnReverse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Cn", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(87, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 44)
        Label1.TabIndex = 2
        Label1.Text = "Consejos"
        ' 
        ' DataGridConsejos
        ' 
        DataGridConsejos.BackgroundColor = Color.AntiqueWhite
        DataGridConsejos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridConsejos.GridColor = SystemColors.MenuHighlight
        DataGridConsejos.Location = New Point(34, 94)
        DataGridConsejos.Name = "DataGridConsejos"
        DataGridConsejos.RowTemplate.Height = 25
        DataGridConsejos.Size = New Size(265, 353)
        DataGridConsejos.TabIndex = 3
        ' 
        ' BtnCargarDatos
        ' 
        BtnCargarDatos.BackColor = Color.DarkKhaki
        BtnCargarDatos.Font = New Font("Roboto Cn", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnCargarDatos.Location = New Point(223, 483)
        BtnCargarDatos.Name = "BtnCargarDatos"
        BtnCargarDatos.Size = New Size(242, 62)
        BtnCargarDatos.TabIndex = 4
        BtnCargarDatos.Text = "Cargar datos"
        BtnCargarDatos.UseVisualStyleBackColor = False
        ' 
        ' DataGridDonaciones
        ' 
        DataGridDonaciones.BackgroundColor = Color.AntiqueWhite
        DataGridDonaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridDonaciones.GridColor = SystemColors.MenuHighlight
        DataGridDonaciones.Location = New Point(409, 105)
        DataGridDonaciones.Name = "DataGridDonaciones"
        DataGridDonaciones.RowTemplate.Height = 25
        DataGridDonaciones.Size = New Size(344, 153)
        DataGridDonaciones.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto Cn", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(494, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 44)
        Label2.TabIndex = 6
        Label2.Text = "Donaciones"
        ' 
        ' DonacionesTotalTextBox
        ' 
        DonacionesTotalTextBox.Location = New Point(572, 289)
        DonacionesTotalTextBox.Name = "DonacionesTotalTextBox"
        DonacionesTotalTextBox.Size = New Size(158, 23)
        DonacionesTotalTextBox.TabIndex = 7
        ' 
        ' BtnDeleteConsejos
        ' 
        BtnDeleteConsejos.BackColor = Color.Brown
        BtnDeleteConsejos.Font = New Font("Roboto Cn", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDeleteConsejos.Location = New Point(12, 483)
        BtnDeleteConsejos.Name = "BtnDeleteConsejos"
        BtnDeleteConsejos.Size = New Size(149, 62)
        BtnDeleteConsejos.TabIndex = 8
        BtnDeleteConsejos.Text = "Eliminar consejos"
        BtnDeleteConsejos.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto Cn", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(409, 288)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 24)
        Label3.TabIndex = 9
        Label3.Text = "Total donaciones:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Font = New Font("Roboto Cn", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(244, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 62)
        Button1.TabIndex = 10
        Button1.Text = "Restaurar Consejos"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(780, 557)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(BtnDeleteConsejos)
        Controls.Add(DonacionesTotalTextBox)
        Controls.Add(Label2)
        Controls.Add(DataGridDonaciones)
        Controls.Add(BtnCargarDatos)
        Controls.Add(DataGridConsejos)
        Controls.Add(Label1)
        Controls.Add(btnReverse)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(800, 600)
        Name = "DataMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Administración"
        CType(DataGridConsejos, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridDonaciones, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnReverse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridConsejos As DataGridView
    Friend WithEvents BtnCargarDatos As Button
    Friend WithEvents DataGridDonaciones As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents DonacionesTotalTextBox As TextBox
    Friend WithEvents BtnDeleteConsejos As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
