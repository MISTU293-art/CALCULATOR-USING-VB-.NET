<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 35F)
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(234, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(849, 160)
        Label1.TabIndex = 0
        Label1.Text = "SCIENTIFIC CALCULATOR"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 38F)
        Label2.ForeColor = SystemColors.MenuHighlight
        Label2.Location = New Point(570, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(668, 86)
        Label2.TabIndex = 1
        Label2.Text = "~Developed by mistu"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(264, 415)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(805, 41)
        ProgressBar1.TabIndex = 2
        ' 
        ' Timer1
        ' 
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1288, 676)
        Controls.Add(ProgressBar1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
