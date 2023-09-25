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
        BtnConsejo = New Button()
        imgReimu = New PictureBox()
        titleP1 = New Label()
        BtnDonate = New Button()
        titleP2 = New Label()
        BtnAdminControl = New Button()
        BtnExit = New Label()
        CType(imgReimu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnConsejo
        ' 
        BtnConsejo.BackColor = Color.LemonChiffon
        BtnConsejo.Cursor = Cursors.Hand
        BtnConsejo.Font = New Font("Roboto", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnConsejo.Location = New Point(184, 478)
        BtnConsejo.Name = "BtnConsejo"
        BtnConsejo.Size = New Size(410, 70)
        BtnConsejo.TabIndex = 0
        BtnConsejo.Text = "Dame un consejo sabio"
        BtnConsejo.UseVisualStyleBackColor = False
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
        ' BtnDonate
        ' 
        BtnDonate.BackColor = Color.SpringGreen
        BtnDonate.Cursor = Cursors.Hand
        BtnDonate.Font = New Font("Roboto", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDonate.Location = New Point(512, 67)
        BtnDonate.Name = "BtnDonate"
        BtnDonate.Size = New Size(260, 100)
        BtnDonate.TabIndex = 3
        BtnDonate.Text = "Donar plata a Reimu"
        BtnDonate.UseVisualStyleBackColor = False
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
        ' BtnAdminControl
        ' 
        BtnAdminControl.BackColor = Color.SteelBlue
        BtnAdminControl.Cursor = Cursors.Hand
        BtnAdminControl.Font = New Font("Roboto", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAdminControl.Location = New Point(12, 494)
        BtnAdminControl.Name = "BtnAdminControl"
        BtnAdminControl.Size = New Size(142, 51)
        BtnAdminControl.TabIndex = 5
        BtnAdminControl.Text = "ADMIN"
        BtnAdminControl.UseVisualStyleBackColor = False
        ' 
        ' BtnExit
        ' 
        BtnExit.AutoSize = True
        BtnExit.Cursor = Cursors.Hand
        BtnExit.Font = New Font("Roboto", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnExit.ForeColor = Color.DarkRed
        BtnExit.Location = New Point(648, 492)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(89, 42)
        BtnExit.TabIndex = 6
        BtnExit.Text = "Salir"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        CausesValidation = False
        ClientSize = New Size(780, 557)
        Controls.Add(BtnExit)
        Controls.Add(BtnAdminControl)
        Controls.Add(titleP2)
        Controls.Add(BtnDonate)
        Controls.Add(titleP1)
        Controls.Add(imgReimu)
        Controls.Add(BtnConsejo)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(800, 600)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Un poco de sabiduría de Reimu"
        CType(imgReimu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnConsejo As Button
    Friend WithEvents imgReimu As PictureBox
    Friend WithEvents titleP1 As Label
    Friend WithEvents BtnDonate As Button
    Friend WithEvents titleP2 As Label
    Friend WithEvents BtnAdminControl As Button
    Friend WithEvents BtnExit As Label
End Class
