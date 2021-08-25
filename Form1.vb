Imports System.Text.RegularExpressions
Imports System.Collections




Public Class Form1

    Private Enum ListViewColumns
        DATE_COL = 0
        CUST_NAME_COL = 1
        LABOR_COST_COL = 2
        PARTS_COST_COL = 3
        BILL_TOTAL_COL = 4
    End Enum
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
            .Add(New TextBoxValidator(txtCustomerName, "^\S\w*", "Invalid Customer Name"))
            .Add(New TextBoxValidator(txtHoursOfLabor, "^\d{1,3}(\.5)?$", "Invalid Hours of Labor"))
            .Add(New TextBoxValidator(txtLaborRate, "^\d{1,2}(\.\d{2})?$", "Invalid Labor Rate"))
            .Add(New TextBoxValidator(txtCostOfParts, "^\d+(\.\d{1,2})?$", "Invalid Cost of Parts"))
            .Add(New TextBoxValidator(txtTaxRate, "^\d{1,2}(\.\d)?$", "Invalid Tax Rate"))

        End With

        For Each objValidator As TextBoxValidator In Validators
            If Not objValidator.IsValid() Then
                Return False
            End If
        Next

        Return True


    End Function

    Private Function AddBill() As Boolean
        '==========================================================
        'Calculate labor cost. Then create and populate new
        'ListViewItem and add it to the ListView control.
        'Then update the bill count and grand total labels for labor cost
        'and bill totals.
        '==========================================================
        Try
            'Get the current date and add it to the ListViewItem, which will eventually
            'be added to the ListView control
            Dim objListViewItem As New ListViewItem(Today.ToString("MM/dd/yyyy"))
            Dim dblLaborCost As Double = CDbl(txtHoursOfLabor.Text) * CDbl(txtLaborRate.Text)
            Dim dblBillTotal As Double = (CDbl(txtCostOfParts.Text) + dblLaborCost) * CDbl(1 + (txtTaxRate.Text / 100))

            'Add the remaining items to the ListView using the values in the corrsponding
            'textboxes.
            With objListViewItem
                .SubItems.Add(ListViewColumns.CUST_NAME_COL).Text = txtCustomerName.Text
                .SubItems.Add(ListViewColumns.LABOR_COST_COL).Text = FormatCurrency(dblLaborCost)
                .SubItems.Add(ListViewColumns.PARTS_COST_COL).Text = FormatCurrency(CDbl(txtCostOfParts.Text))
                .SubItems.Add(ListViewColumns.BILL_TOTAL_COL).Text = FormatCurrency(dblBillTotal)
            End With

            'Add fully populated ListViewItem to the ListView control
            lsvBills.Items.Add(objListViewItem)

            'TODO Update label controls beneath the ListView with current totals
        Catch ex As Exception
            msgAttention(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Private Sub ToggleButtons(ByVal ParamArray Buttons() As Object)
        '==========================================================
        'Toggle visibility of each button passed to the procedure.
        '==========================================================

        For Each obj As Button In Buttons
            Dim objButton As Button = CType(obj, Button)
            objButton.Visible = Not objButton.Visible
        Next

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreateBill_Click(sender As Object, e As EventArgs) Handles btnCreateBill.Click
        '==========================================================
        'Valdate input controls and then add new ListViewItem to 
        'the ListView control.
        '==========================================================
        If ValidateInput() Then
            msgInfo("Validations were successful!")
            If Not AddBill() Then Exit Sub

        Else
            'if a validation has failed the TextValidator object
            'will have displayed a warning.

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub txtCustomerName_LostFocus(sender As Object, e As EventArgs) Handles txtCustomerName.LostFocus
        '==========================================================
        'Convert customer name to Proper Case.
        '==========================================================
        If txtCustomerName.Text <> "" Then
            txtCustomerName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtCustomerName.Text)
        End If
    End Sub
End Class
