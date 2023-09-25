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
        Label1 = New Label()
        btnReverse = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Bk", 48F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(54, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(687, 77)
        Label1.TabIndex = 0
        Label1.Text = "Pronto habrá algo aquí"
        ' 
        ' btnReverse
        ' 
        btnReverse.Font = New Font("Roboto Cn", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnReverse.Location = New Point(190, 424)
        btnReverse.Name = "btnReverse"
        btnReverse.Size = New Size(370, 121)
        btnReverse.TabIndex = 1
        btnReverse.Text = "Regresar a casa decepcionado"
        btnReverse.UseVisualStyleBackColor = True
        ' 
        ' DataMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(780, 557)
        Controls.Add(btnReverse)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(800, 600)
        Name = "DataMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reimus"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnReverse As Button
End Class
