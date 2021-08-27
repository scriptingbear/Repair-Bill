﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lsvBills = New System.Windows.Forms.ListView()
        Me.colDate = New System.Windows.Forms.ColumnHeader()
        Me.colCustName = New System.Windows.Forms.ColumnHeader()
        Me.colLaborCost = New System.Windows.Forms.ColumnHeader()
        Me.colPartsCost = New System.Windows.Forms.ColumnHeader()
        Me.colBillTotal = New System.Windows.Forms.ColumnHeader()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtHoursOfLabor = New System.Windows.Forms.TextBox()
        Me.txtCostOfParts = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTaxRate = New System.Windows.Forms.TextBox()
        Me.btnCreateBill = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancelUpdate = New System.Windows.Forms.Button()
        Me.txtLaborRate = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblLaborCostTotal = New System.Windows.Forms.Label()
        Me.lblPartsCostTotal = New System.Windows.Forms.Label()
        Me.lblBillTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dteBillDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lsvBills
        '
        Me.lsvBills.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lsvBills.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDate, Me.colCustName, Me.colLaborCost, Me.colPartsCost, Me.colBillTotal})
        Me.lsvBills.FullRowSelect = True
        Me.lsvBills.GridLines = True
        Me.lsvBills.HideSelection = False
        Me.lsvBills.Location = New System.Drawing.Point(53, 243)
        Me.lsvBills.Margin = New System.Windows.Forms.Padding(4)
        Me.lsvBills.MultiSelect = False
        Me.lsvBills.Name = "lsvBills"
        Me.lsvBills.ShowGroups = False
        Me.lsvBills.Size = New System.Drawing.Size(910, 227)
        Me.lsvBills.TabIndex = 10
        Me.lsvBills.UseCompatibleStateImageBehavior = False
        Me.lsvBills.View = System.Windows.Forms.View.Details
        '
        'colDate
        '
        Me.colDate.Text = "Date"
        Me.colDate.Width = 140
        '
        'colCustName
        '
        Me.colCustName.Text = "Customer Name"
        Me.colCustName.Width = 200
        '
        'colLaborCost
        '
        Me.colLaborCost.Text = "Labor Cost"
        Me.colLaborCost.Width = 180
        '
        'colPartsCost
        '
        Me.colPartsCost.Text = "Parts Cost"
        Me.colPartsCost.Width = 180
        '
        'colBillTotal
        '
        Me.colBillTotal.Text = "Total"
        Me.colBillTotal.Width = 180
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(201, 39)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(280, 34)
        Me.txtCustomerName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtCustomerName, "Enter customer name")
        '
        'txtHoursOfLabor
        '
        Me.txtHoursOfLabor.Location = New System.Drawing.Point(201, 81)
        Me.txtHoursOfLabor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoursOfLabor.Name = "txtHoursOfLabor"
        Me.txtHoursOfLabor.Size = New System.Drawing.Size(89, 34)
        Me.txtHoursOfLabor.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtHoursOfLabor, "Enter a positive number for the hours of labor")
        '
        'txtCostOfParts
        '
        Me.txtCostOfParts.Location = New System.Drawing.Point(220, 123)
        Me.txtCostOfParts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostOfParts.Name = "txtCostOfParts"
        Me.txtCostOfParts.Size = New System.Drawing.Size(174, 34)
        Me.txtCostOfParts.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtCostOfParts, "Enter a positive number for the cost of parts")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hours Of Labor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cost Of Parts"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tax Rate"
        '
        'txtTaxRate
        '
        Me.txtTaxRate.Location = New System.Drawing.Point(201, 165)
        Me.txtTaxRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTaxRate.Name = "txtTaxRate"
        Me.txtTaxRate.Size = New System.Drawing.Size(89, 34)
        Me.txtTaxRate.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtTaxRate, "Enter a positive number between 0 and 10 for the tax rate")
        '
        'btnCreateBill
        '
        Me.btnCreateBill.Location = New System.Drawing.Point(808, 39)
        Me.btnCreateBill.Name = "btnCreateBill"
        Me.btnCreateBill.Size = New System.Drawing.Size(155, 60)
        Me.btnCreateBill.TabIndex = 9
        Me.btnCreateBill.Text = "Create Bill"
        Me.ToolTip1.SetToolTip(Me.btnCreateBill, "Create new bill and add it to the list" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnCreateBill.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Wingdings", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.Location = New System.Drawing.Point(524, 106)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(155, 60)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "ü"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Update bill")
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnCancelUpdate
        '
        Me.btnCancelUpdate.Font = New System.Drawing.Font("Wingdings", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelUpdate.Location = New System.Drawing.Point(524, 166)
        Me.btnCancelUpdate.Name = "btnCancelUpdate"
        Me.btnCancelUpdate.Size = New System.Drawing.Size(155, 60)
        Me.btnCancelUpdate.TabIndex = 8
        Me.btnCancelUpdate.Text = "û"
        Me.ToolTip1.SetToolTip(Me.btnCancelUpdate, "Cancel update")
        Me.btnCancelUpdate.UseVisualStyleBackColor = True
        Me.btnCancelUpdate.Visible = False
        '
        'txtLaborRate
        '
        Me.txtLaborRate.Location = New System.Drawing.Point(335, 78)
        Me.txtLaborRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLaborRate.Name = "txtLaborRate"
        Me.txtLaborRate.Size = New System.Drawing.Size(89, 34)
        Me.txtLaborRate.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtLaborRate, "Enter a positive number for the cost of labor per hour")
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(524, 39)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 60)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear the billing info textboxes")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(726, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 67)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Double click an item in the list to edit it"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(297, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 28)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "@$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(431, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "/hr"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(202, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "$"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(297, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 28)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "%"
        '
        'lblLaborCostTotal
        '
        Me.lblLaborCostTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLaborCostTotal.Location = New System.Drawing.Point(394, 484)
        Me.lblLaborCostTotal.Name = "lblLaborCostTotal"
        Me.lblLaborCostTotal.Size = New System.Drawing.Size(170, 25)
        Me.lblLaborCostTotal.TabIndex = 8
        Me.lblLaborCostTotal.Tag = ""
        '
        'lblPartsCostTotal
        '
        Me.lblPartsCostTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPartsCostTotal.Location = New System.Drawing.Point(574, 484)
        Me.lblPartsCostTotal.Name = "lblPartsCostTotal"
        Me.lblPartsCostTotal.Size = New System.Drawing.Size(170, 28)
        Me.lblPartsCostTotal.TabIndex = 8
        '
        'lblBillTotal
        '
        Me.lblBillTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBillTotal.Location = New System.Drawing.Point(755, 484)
        Me.lblBillTotal.Name = "lblBillTotal"
        Me.lblBillTotal.Size = New System.Drawing.Size(170, 28)
        Me.lblBillTotal.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(53, 207)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 28)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Date"
        '
        'dteBillDate
        '
        Me.dteBillDate.CustomFormat = "MM/dd/yyyy"
        Me.dteBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dteBillDate.Location = New System.Drawing.Point(201, 207)
        Me.dteBillDate.Name = "dteBillDate"
        Me.dteBillDate.Size = New System.Drawing.Size(145, 34)
        Me.dteBillDate.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 536)
        Me.Controls.Add(Me.dteBillDate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblBillTotal)
        Me.Controls.Add(Me.lblPartsCostTotal)
        Me.Controls.Add(Me.lblLaborCostTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancelUpdate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreateBill)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCostOfParts)
        Me.Controls.Add(Me.txtTaxRate)
        Me.Controls.Add(Me.txtLaborRate)
        Me.Controls.Add(Me.txtHoursOfLabor)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lsvBills)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Repair Bil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvBills As ListView
    Friend WithEvents colDate As ColumnHeader
    Friend WithEvents colCustName As ColumnHeader
    Friend WithEvents colLaborCost As ColumnHeader
    Friend WithEvents colPartsCost As ColumnHeader
    Friend WithEvents colBillTotal As ColumnHeader
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtHoursOfLabor As TextBox
    Friend WithEvents txtCostOfParts As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTaxRate As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnCreateBill As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancelUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLaborRate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblLaborCostTotal As Label
    Friend WithEvents lblPartsCostTotal As Label
    Friend WithEvents lblBillTotal As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents dteBillDate As DateTimePicker
End Class
