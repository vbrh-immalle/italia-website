﻿Public Class Programma
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As System.EventArgs) Handles btnlogin.Click
        Response.Redirect("Login.aspx")
    End Sub
End Class