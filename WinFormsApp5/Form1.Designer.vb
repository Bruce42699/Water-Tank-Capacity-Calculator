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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Heighttxtbox = New TextBox()
        Widthtxtbox = New TextBox()
        depthtxtbox = New TextBox()
        answer = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(355, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 28)
        Label1.TabIndex = 0
        Label1.Text = "Water Tank Capacity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(218, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 20)
        Label2.TabIndex = 1
        Label2.Text = "Height(cm)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(223, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 1
        Label3.Text = "Width(cm)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(222, 254)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 20)
        Label4.TabIndex = 2
        Label4.Text = "Depth(cm)"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(223, 327)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(165, 31)
        Button1.TabIndex = 3
        Button1.Text = "Calculate Capacity"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Heighttxtbox
        ' 
        Heighttxtbox.Location = New Point(322, 152)
        Heighttxtbox.Margin = New Padding(3, 4, 3, 4)
        Heighttxtbox.Name = "Heighttxtbox"
        Heighttxtbox.Size = New Size(114, 27)
        Heighttxtbox.TabIndex = 4
        ' 
        ' Widthtxtbox
        ' 
        Widthtxtbox.Location = New Point(322, 203)
        Widthtxtbox.Margin = New Padding(3, 4, 3, 4)
        Widthtxtbox.Name = "Widthtxtbox"
        Widthtxtbox.Size = New Size(114, 27)
        Widthtxtbox.TabIndex = 4
        ' 
        ' depthtxtbox
        ' 
        depthtxtbox.Location = New Point(322, 254)
        depthtxtbox.Margin = New Padding(3, 4, 3, 4)
        depthtxtbox.Name = "depthtxtbox"
        depthtxtbox.Size = New Size(114, 27)
        depthtxtbox.TabIndex = 4
        ' 
        ' answer
        ' 
        answer.AutoSize = True
        answer.Location = New Point(442, 332)
        answer.Name = "answer"
        answer.Size = New Size(55, 20)
        answer.TabIndex = 2
        answer.Text = "answer"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(depthtxtbox)
        Controls.Add(Widthtxtbox)
        Controls.Add(Heighttxtbox)
        Controls.Add(Button1)
        Controls.Add(answer)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Water Tank Capacity"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Heighttxtbox As TextBox
    Friend WithEvents Widthtxtbox As TextBox
    Friend WithEvents depthtxtbox As TextBox
    Friend WithEvents answer As Label

End Class
