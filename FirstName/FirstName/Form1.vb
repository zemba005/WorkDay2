﻿Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click

        Dim fullname As String
        'read the input from the user
        fullname = txtFullName.Text

        'trim the input so as to remove leading spaces
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        'find the index of the first space
        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")

        'extract the first name
        Dim firstname As String
        firstname = fullnameTrimmed.Substring(0, idxSpace)


        'display the result to the user
        txtFirstName.Text = firstname





    End Sub


End Class
