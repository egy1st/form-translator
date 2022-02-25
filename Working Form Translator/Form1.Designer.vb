<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Fax = New System.Windows.Forms.TextBox
        Me.Fax_Label = New System.Windows.Forms.Label
        Me.Phone = New System.Windows.Forms.TextBox
        Me.Phone_Label = New System.Windows.Forms.Label
        Me.Address = New System.Windows.Forms.TextBox
        Me.Address_Label = New System.Windows.Forms.Label
        Me.CustName_Label = New System.Windows.Forms.Label
        Me.CustID_Label = New System.Windows.Forms.Label
        Me.CustomerName = New System.Windows.Forms.TextBox
        Me.CustomerID = New System.Windows.Forms.TextBox
        Me.TranslateForm = New System.Windows.Forms.Button
        Me.LastButton = New System.Windows.Forms.Button
        Me.NextButton = New System.Windows.Forms.Button
        Me.PreviousButton = New System.Windows.Forms.Button
        Me.FirstButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Fax
        '
        Me.Fax.AcceptsReturn = True
        Me.Fax.BackColor = System.Drawing.SystemColors.Window
        Me.Fax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Fax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Fax.Location = New System.Drawing.Point(130, 150)
        Me.Fax.MaxLength = 12
        Me.Fax.Name = "Fax"
        Me.Fax.Size = New System.Drawing.Size(133, 20)
        Me.Fax.TabIndex = 98
        '
        'Fax_Label
        '
        Me.Fax_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Fax_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Fax_Label.Location = New System.Drawing.Point(16, 150)
        Me.Fax_Label.Name = "Fax_Label"
        Me.Fax_Label.Size = New System.Drawing.Size(112, 24)
        Me.Fax_Label.TabIndex = 103
        Me.Fax_Label.Text = "Fax"
        '
        'Phone
        '
        Me.Phone.AcceptsReturn = True
        Me.Phone.BackColor = System.Drawing.SystemColors.Window
        Me.Phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Phone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Phone.Location = New System.Drawing.Point(130, 118)
        Me.Phone.MaxLength = 12
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(134, 20)
        Me.Phone.TabIndex = 97
        '
        'Phone_Label
        '
        Me.Phone_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Phone_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Phone_Label.Location = New System.Drawing.Point(18, 118)
        Me.Phone_Label.Name = "Phone_Label"
        Me.Phone_Label.Size = New System.Drawing.Size(112, 24)
        Me.Phone_Label.TabIndex = 102
        Me.Phone_Label.Text = "Telephone"
        '
        'Address
        '
        Me.Address.AcceptsReturn = True
        Me.Address.BackColor = System.Drawing.SystemColors.Window
        Me.Address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Address.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Address.Location = New System.Drawing.Point(130, 86)
        Me.Address.MaxLength = 50
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(263, 20)
        Me.Address.TabIndex = 96
        '
        'Address_Label
        '
        Me.Address_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Address_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Address_Label.Location = New System.Drawing.Point(18, 86)
        Me.Address_Label.Name = "Address_Label"
        Me.Address_Label.Size = New System.Drawing.Size(112, 24)
        Me.Address_Label.TabIndex = 101
        Me.Address_Label.Text = "Address"
        '
        'CustName_Label
        '
        Me.CustName_Label.AccessibleDescription = ""
        Me.CustName_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CustName_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CustName_Label.Location = New System.Drawing.Point(18, 54)
        Me.CustName_Label.Name = "CustName_Label"
        Me.CustName_Label.Size = New System.Drawing.Size(112, 24)
        Me.CustName_Label.TabIndex = 100
        Me.CustName_Label.Text = "Customer Name"
        '
        'CustID_Label
        '
        Me.CustID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CustID_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CustID_Label.Location = New System.Drawing.Point(18, 22)
        Me.CustID_Label.Name = "CustID_Label"
        Me.CustID_Label.Size = New System.Drawing.Size(112, 24)
        Me.CustID_Label.TabIndex = 99
        Me.CustID_Label.Text = "Customer ID"
        '
        'CustomerName
        '
        Me.CustomerName.AcceptsReturn = True
        Me.CustomerName.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustomerName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerName.Location = New System.Drawing.Point(130, 54)
        Me.CustomerName.MaxLength = 50
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(263, 20)
        Me.CustomerName.TabIndex = 95
        '
        'CustomerID
        '
        Me.CustomerID.AcceptsReturn = True
        Me.CustomerID.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustomerID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerID.Location = New System.Drawing.Point(130, 22)
        Me.CustomerID.MaxLength = 4
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Size = New System.Drawing.Size(84, 20)
        Me.CustomerID.TabIndex = 94
        '
        'TranslateForm
        '
        Me.TranslateForm.Location = New System.Drawing.Point(267, 118)
        Me.TranslateForm.Name = "TranslateForm"
        Me.TranslateForm.Size = New System.Drawing.Size(127, 56)
        Me.TranslateForm.TabIndex = 93
        Me.TranslateForm.Text = "Translate Form into French"
        '
        'LastButton
        '
        Me.LastButton.Image = CType(resources.GetObject("LastButton.Image"), System.Drawing.Image)
        Me.LastButton.Location = New System.Drawing.Point(250, 238)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(72, 48)
        Me.LastButton.TabIndex = 91
        '
        'NextButton
        '
        Me.NextButton.Image = CType(resources.GetObject("NextButton.Image"), System.Drawing.Image)
        Me.NextButton.Location = New System.Drawing.Point(170, 238)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(72, 48)
        Me.NextButton.TabIndex = 90
        '
        'PreviousButton
        '
        Me.PreviousButton.Image = CType(resources.GetObject("PreviousButton.Image"), System.Drawing.Image)
        Me.PreviousButton.Location = New System.Drawing.Point(98, 238)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(72, 48)
        Me.PreviousButton.TabIndex = 89
        '
        'FirstButton
        '
        Me.FirstButton.Image = CType(resources.GetObject("FirstButton.Image"), System.Drawing.Image)
        Me.FirstButton.Location = New System.Drawing.Point(18, 238)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(72, 48)
        Me.FirstButton.TabIndex = 88
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(378, 238)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ExitButton.Size = New System.Drawing.Size(72, 48)
        Me.ExitButton.TabIndex = 92
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 308)
        Me.Controls.Add(Me.Fax)
        Me.Controls.Add(Me.Fax_Label)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Phone_Label)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Address_Label)
        Me.Controls.Add(Me.CustName_Label)
        Me.Controls.Add(Me.CustID_Label)
        Me.Controls.Add(Me.CustomerName)
        Me.Controls.Add(Me.CustomerID)
        Me.Controls.Add(Me.TranslateForm)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Form1"
        Me.Text = "DC Image Button V. 3.5 Tutorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Fax As System.Windows.Forms.TextBox
    Friend WithEvents Fax_Label As System.Windows.Forms.Label
    Public WithEvents Phone As System.Windows.Forms.TextBox
    Friend WithEvents Phone_Label As System.Windows.Forms.Label
    Public WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Address_Label As System.Windows.Forms.Label
    Friend WithEvents CustName_Label As System.Windows.Forms.Label
    Friend WithEvents CustID_Label As System.Windows.Forms.Label
    Public WithEvents CustomerName As System.Windows.Forms.TextBox
    Public WithEvents CustomerID As System.Windows.Forms.TextBox
    Friend WithEvents TranslateForm As System.Windows.Forms.Button
    Friend WithEvents LastButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents FirstButton As System.Windows.Forms.Button
    Public WithEvents ExitButton As System.Windows.Forms.Button

End Class
