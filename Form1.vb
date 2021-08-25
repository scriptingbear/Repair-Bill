Imports System.Text.RegularExpressions
Imports System.Collections


Public Class Form1
    Private Function ValidateInput() As Boolean
        '==========================================================
        '1.) Customer name must not be empty
        '2.) Hours of labor must be a positive number
        '3.) Cost of labor must be a positive number
        '4.) Cost of parts must be a positive number
        '5.) Tax rate must be positive number or 0
        '
        'Use Regex to validate each control
        '==========================================================
        Dim Validators As New List(Of TextBoxValidator)

        With Validators
            .Add(New TextBoxValidator(txtCustomerName, "^\w$", "Invalid Customer Name"))

        End With

        For Each objValidator As TextBoxValidator In Validators
            If Not objValidator.IsValid() Then
                Return False
            End If
        Next

        Return True


    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreateBill_Click(sender As Object, e As EventArgs) Handles btnCreateBill.Click
        '==========================================================
        'Valdate input controls and then add new ListViewItem to 
        'the ListView control.
        '==========================================================
        If ValidateInput() Then

        Else


        End If
    End Sub
End Class
