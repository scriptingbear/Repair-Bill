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

    Private Structure LaborCostInfo
        Dim Hours As Double
        Dim LaborRate As Double
        Dim TaxRate As Double
    End Structure

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
            .Add(New TextBoxValidator(txtTaxRate, "^\d{1,2}(\.\d{1,2})?$", "Invalid Tax Rate"))

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
        'Need to store hours of labor and labor rate, even though
        'they're not displayed in the ListView, because they will
        'be needed when editing an item.
        'Also need to store tax rate, for the same reasons.
        '=========================================================

        Try
            'Get the current date and add it to the ListViewItem, which will eventually
            'be added to the ListView control
            Dim objListViewItem As New ListViewItem(Today.ToString("MM/dd/yyyy"))

            Dim objLaborCostInfo As LaborCostInfo
            With objLaborCostInfo
                .Hours = CDbl(txtHoursOfLabor.Text)
                .LaborRate = CDbl(txtLaborRate.Text)
                .TaxRate = CDbl(txtTaxRate.Text)
            End With

            Dim dblLaborCost As Double = objLaborCostInfo.Hours * objLaborCostInfo.LaborRate
            Dim dblBillTotal As Double = (CDbl(txtCostOfParts.Text) + dblLaborCost) * CDbl(1 + (objLaborCostInfo.TaxRate / 100))

            'Add the remaining items to the ListView using the values in the corrsponding
            'textboxes.
            With objListViewItem
                .SubItems.Add(ListViewColumns.CUST_NAME_COL).Text = txtCustomerName.Text
                .SubItems.Add(ListViewColumns.LABOR_COST_COL).Text = FormatCurrency(dblLaborCost)

                'Store the labor hours and rate in the Labor Cost subitem for use
                'when editing an existing bill
                .SubItems(ListViewColumns.LABOR_COST_COL).Tag = objLaborCostInfo

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

    Private Sub UpdateTotalLabels()
        '==========================================================
        'Write total of labor cost, parts cost and bill amounts
        'to labels beneath the ListView control.
        '==========================================================
        Dim dblLaborCostTotal As Double = 0
        Dim dblPartsCostTotal As Double = 0
        Dim dblBillTotal As Double = 0

        For Each objListViewItem As ListViewItem In lsvBills.Items
            dblLaborCostTotal += CDbl(objListViewItem.SubItems(ListViewColumns.LABOR_COST_COL).Text)
            dblPartsCostTotal += CDbl(objListViewItem.SubItems(ListViewColumns.PARTS_COST_COL).Text)
            dblBillTotal += CDbl(objListViewItem.SubItems(ListViewColumns.BILL_TOTAL_COL).Text)
        Next

        lblLaborCostTotal.Text = FormatCurrency(dblLaborCostTotal)
        lblPartsCostTotal.Text = FormatCurrency(dblPartsCostTotal)
        lblBillTotal.Text = FormatCurrency(dblBillTotal)

    End Sub

    Private Sub SetTotalLabelTags()
        '==========================================================
        'Assign the tag property of the total labels beneath the 
        'ListView control from the ListViewColumns enum, which
        'will make UpdateTotalLabels() easier to code.
        'MIGHT NOT NEED THIS AFTER ALL :-\
        '==========================================================
        Dim TotalLabels = New List(Of Label) From {lblLaborCostTotal, lblLaborCostTotal, lblBillTotal}

        For i As ListViewColumns = ListViewColumns.LABOR_COST_COL To ListViewColumns.BILL_TOTAL_COL
            TotalLabels(i - 2).Tag = i
        Next
    End Sub

    Private Sub ClearInputs()
        '===================================================================
        'Clear the input textboxes but cannot clear the totals labels at the
        'bottom of the ListView control since there still may be
        'items present.
        '===================================================================

        Dim arTextBoxes As New List(Of TextBox)
        With arTextBoxes
            .Add(txtCustomerName)
            .Add(txtHoursOfLabor)
            .Add(txtLaborRate)
            .Add(txtCostOfParts)
            .Add(txtTaxRate)
        End With

        For Each obj As TextBox In arTextBoxes
            obj.Clear()
        Next obj

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '==========================================================
        'Set the Tag property of the labels beneath the ListView
        'control.
        '==========================================================
        'SetTotalLabelTags()
    End Sub

    Private Sub btnCreateBill_Click(sender As Object, e As EventArgs) Handles btnCreateBill.Click
        '==========================================================
        'Valdate input controls and then add new ListViewItem to 
        'the ListView control. If a validation fails, a warning
        'message will have been displayed.
        '==========================================================
        If ValidateInput() Then
            msgInfo("Validations were successful!")
            If Not AddBill() Then Exit Sub
            UpdateTotalLabels()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        '===================================================================
        'Clear the input textboxes but cannot clear the totals labels at the bottom
        'of the ListView control since there still may be items present.
        '===================================================================
        ClearInputs()
    End Sub

    Private Sub txtCustomerName_LostFocus(sender As Object, e As EventArgs) Handles txtCustomerName.LostFocus
        '==========================================================
        'Convert customer name to Proper Case.
        '==========================================================
        If txtCustomerName.Text <> "" Then
            txtCustomerName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtCustomerName.Text)
        End If
    End Sub

    Private Sub lsvBills_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvBills.SelectedIndexChanged

    End Sub

    Private Sub lsvBills_DoubleClick(sender As Object, e As EventArgs) Handles lsvBills.DoubleClick
        '==========================================================
        'If ListView is not empty, clear input textboxes and populate
        'them from the contents of the ListViewItem corresponding
        'to the SelectedIndex of the ListView control.
        'This event occurs only when the Listview control contains
        'at least 1 item.
        '==========================================================
        Dim objListViewItem As ListViewItem = lsvBills.SelectedItems(0)
        Dim objLaborCostInfo As LaborCostInfo

        ClearInputs()

        objListViewItem = lsvBills.SelectedItems(0)
        With objListViewItem
            txtCustomerName.Text = .SubItems(ListViewColumns.CUST_NAME_COL).Text

            objLaborCostInfo = .SubItems(ListViewColumns.LABOR_COST_COL).Tag
            txtHoursOfLabor.Text = objLaborCostInfo.Hours
            txtLaborRate.Text = objLaborCostInfo.LaborRate
            txtTaxRate.Text = objLaborCostInfo.TaxRate

            txtCostOfParts.Text = CDbl(.SubItems(ListViewColumns.PARTS_COST_COL).Text)
        End With


    End Sub

    Private Sub lsvBills_Click(sender As Object, e As EventArgs) Handles lsvBills.Click
        'msgAttention("Click event")
    End Sub
End Class
