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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnConsejo = New Button()
        imgReimu = New PictureBox()
        titleP1 = New Label()
        btnDonate = New Button()
        titleP2 = New Label()
        Button1 = New Button()
        CType(imgReimu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnConsejo
        ' 
        btnConsejo.BackColor = Color.LemonChiffon
        btnConsejo.Cursor = Cursors.Hand
        btnConsejo.Font = New Font("Roboto", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnConsejo.Location = New Point(184, 478)
        btnConsejo.Name = "btnConsejo"
        btnConsejo.Size = New Size(410, 70)
        btnConsejo.TabIndex = 0
        btnConsejo.Text = "Dame un consejo sabio"
        btnConsejo.UseVisualStyleBackColor = False
        ' 
        ' imgReimu
        ' 
        imgReimu.Image = My.Resources.Resources.reimu
        imgReimu.Location = New Point(91, 67)
        imgReimu.Name = "imgReimu"
        imgReimu.Size = New Size(415, 394)
        imgReimu.TabIndex = 1
        imgReimu.TabStop = False
        ' 
        ' titleP1
        ' 
        titleP1.AutoSize = True
        titleP1.Font = New Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point)
        titleP1.Location = New Point(149, 6)
        titleP1.Name = "titleP1"
        titleP1.Size = New Size(385, 58)
        titleP1.TabIndex = 2
        titleP1.Text = "Consejos Sabios"
        ' 
        ' btnDonate
        ' 
        btnDonate.BackColor = Color.SpringGreen
        btnDonate.Cursor = Cursors.Hand
        btnDonate.Font = New Font("Roboto", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnDonate.Location = New Point(512, 67)
        btnDonate.Name = "btnDonate"
        btnDonate.Size = New Size(260, 100)
        btnDonate.TabIndex = 3
        btnDonate.Text = "Donar plata a Reimu"
        btnDonate.UseVisualStyleBackColor = False
        ' 
        ' titleP2
        ' 
        titleP2.AutoSize = True
        titleP2.Font = New Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point)
        titleP2.Location = New Point(524, 29)
        titleP2.Name = "titleP2"
        titleP2.Size = New Size(256, 29)
        titleP2.TabIndex = 4
        titleP2.Text = """Reimu Programming"""
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Roboto", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(512, 173)
        Button1.Name = "Button1"
        Button1.Size = New Size(260, 100)
        Button1.TabIndex = 5
        Button1.Text = "Coming soon"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        CausesValidation = False
        ClientSize = New Size(780, 557)
        Controls.Add(Button1)
        Controls.Add(titleP2)
        Controls.Add(btnDonate)
        Controls.Add(titleP1)
        Controls.Add(imgReimu)
        Controls.Add(btnConsejo)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(800, 600)
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Un poco de sabiduría de Reimu"
        CType(imgReimu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConsejo As Button
    Friend WithEvents imgReimu As PictureBox
    Friend WithEvents titleP1 As Label
    Friend WithEvents btnDonate As Button
    Friend WithEvents titleP2 As Label
    Friend WithEvents Button1 As Button
End Class
