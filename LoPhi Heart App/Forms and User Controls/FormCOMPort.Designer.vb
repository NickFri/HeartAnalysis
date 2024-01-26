<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCOMPort
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
        tbMessage = New TextBox()
        btnSelect = New Button()
        btnScan = New Button()
        listBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' tbMessage
        ' 
        tbMessage.BackColor = SystemColors.Control
        tbMessage.BorderStyle = BorderStyle.None
        tbMessage.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tbMessage.Location = New Point(11, 12)
        tbMessage.Multiline = True
        tbMessage.Name = "tbMessage"
        tbMessage.Size = New Size(243, 60)
        tbMessage.TabIndex = 9
        tbMessage.Text = "message"
        ' 
        ' btnSelect
        ' 
        btnSelect.FlatStyle = FlatStyle.System
        btnSelect.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelect.Location = New Point(133, 283)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(121, 23)
        btnSelect.TabIndex = 8
        btnSelect.Text = "Select"
        btnSelect.UseVisualStyleBackColor = True
        ' 
        ' btnScan
        ' 
        btnScan.FlatStyle = FlatStyle.System
        btnScan.Location = New Point(11, 283)
        btnScan.Name = "btnScan"
        btnScan.Size = New Size(121, 23)
        btnScan.TabIndex = 7
        btnScan.Text = "Re-Scan"
        btnScan.UseVisualStyleBackColor = True
        ' 
        ' listBox1
        ' 
        listBox1.FormattingEnabled = True
        listBox1.ItemHeight = 15
        listBox1.Location = New Point(11, 78)
        listBox1.Name = "listBox1"
        listBox1.Size = New Size(242, 199)
        listBox1.TabIndex = 5
        ' 
        ' FormCOMPort
        ' 
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = SystemColors.Control
        ClientSize = New Size(263, 313)
        Controls.Add(tbMessage)
        Controls.Add(btnSelect)
        Controls.Add(btnScan)
        Controls.Add(listBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormCOMPort"
        Text = "Select COM Port"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents tbMessage As TextBox
    Private WithEvents btnSelect As Button
    Private WithEvents btnScan As Button
    Private WithEvents listBox1 As ListBox
End Class
