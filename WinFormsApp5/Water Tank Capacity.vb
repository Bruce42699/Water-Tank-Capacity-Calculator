Imports System.ComponentModel.Design.Serialization

Public Class Form1
    Public Property height As Int32
    Public Property Width As Int32
    Public Property Depth As Int32


    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        height = Val(Heighttxtbox.Text)
        Width = Val(Widthtxtbox.Text)
        Depth = Val(depthtxtbox.Text)

        answer.Text = height * Width * Depth

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class