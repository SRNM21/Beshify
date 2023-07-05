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
        Label1 = New Label()
        Panel1 = New Panel()
        CopyBtn = New Button()
        Copyright = New Label()
        ResultTextBox = New TextBox()
        ResultLabel = New Label()
        MainTextBox = New TextBox()
        TextLabel = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Image = My.Resources.Resources.Logo
        Label1.Location = New Point(80, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(480, 129)
        Label1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(CopyBtn)
        Panel1.Controls.Add(Copyright)
        Panel1.Controls.Add(ResultTextBox)
        Panel1.Controls.Add(ResultLabel)
        Panel1.Controls.Add(MainTextBox)
        Panel1.Controls.Add(TextLabel)
        Panel1.Location = New Point(23, 131)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(590, 267)
        Panel1.TabIndex = 1
        ' 
        ' CopyBtn
        ' 
        CopyBtn.BackColor = Color.Transparent
        CopyBtn.Cursor = Cursors.Hand
        CopyBtn.FlatAppearance.BorderSize = 0
        CopyBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        CopyBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        CopyBtn.FlatStyle = FlatStyle.Flat
        CopyBtn.ForeColor = Color.Transparent
        CopyBtn.Image = My.Resources.Resources.CopyButtonNHover
        CopyBtn.Location = New Point(509, 1)
        CopyBtn.Name = "CopyBtn"
        CopyBtn.Size = New Size(78, 25)
        CopyBtn.TabIndex = 5
        CopyBtn.UseVisualStyleBackColor = False
        ' 
        ' Copyright
        ' 
        Copyright.AutoSize = True
        Copyright.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Copyright.ForeColor = Color.White
        Copyright.Location = New Point(189, 240)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(213, 21)
        Copyright.TabIndex = 4
        Copyright.Text = "Developed by: Greggy Boi"
        ' 
        ' ResultTextBox
        ' 
        ResultTextBox.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(38))
        ResultTextBox.BorderStyle = BorderStyle.None
        ResultTextBox.Cursor = Cursors.IBeam
        ResultTextBox.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ResultTextBox.ForeColor = Color.White
        ResultTextBox.Location = New Point(310, 27)
        ResultTextBox.Multiline = True
        ResultTextBox.Name = "ResultTextBox"
        ResultTextBox.ReadOnly = True
        ResultTextBox.ScrollBars = ScrollBars.Vertical
        ResultTextBox.Size = New Size(280, 200)
        ResultTextBox.TabIndex = 3
        ' 
        ' ResultLabel
        ' 
        ResultLabel.AutoSize = True
        ResultLabel.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        ResultLabel.ForeColor = Color.White
        ResultLabel.Location = New Point(310, 0)
        ResultLabel.Name = "ResultLabel"
        ResultLabel.Size = New Size(70, 24)
        ResultLabel.TabIndex = 2
        ResultLabel.Text = "Result"
        ' 
        ' MainTextBox
        ' 
        MainTextBox.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(38))
        MainTextBox.BorderStyle = BorderStyle.None
        MainTextBox.Cursor = Cursors.IBeam
        MainTextBox.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        MainTextBox.ForeColor = Color.White
        MainTextBox.Location = New Point(0, 27)
        MainTextBox.Multiline = True
        MainTextBox.Name = "MainTextBox"
        MainTextBox.ScrollBars = ScrollBars.Vertical
        MainTextBox.Size = New Size(280, 200)
        MainTextBox.TabIndex = 1
        ' 
        ' TextLabel
        ' 
        TextLabel.AutoSize = True
        TextLabel.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextLabel.ForeColor = Color.White
        TextLabel.Location = New Point(0, 0)
        TextLabel.Name = "TextLabel"
        TextLabel.Size = New Size(49, 24)
        TextLabel.TabIndex = 0
        TextLabel.Text = "Text"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        ClientSize = New Size(634, 401)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Beshify"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextLabel As Label
    Friend WithEvents MainTextBox As TextBox
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents ResultLabel As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents CopyBtn As Button
End Class
