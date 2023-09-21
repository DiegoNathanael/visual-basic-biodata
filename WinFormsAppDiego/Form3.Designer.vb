<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(591, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 48)
        Label1.TabIndex = 0
        Label1.Text = "BIODATA ORANG TUA"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(674, 201)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(427, 31)
        DateTimePicker1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(503, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 2
        Label2.Text = "TANGGAL LAHIR"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(716, 276)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 56)
        Button1.TabIndex = 3
        Button1.Text = "KELUAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1710, 672)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
