Public Class TestForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents FirstButton As System.Windows.Forms.Button
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents LastButton As System.Windows.Forms.Button
    Friend WithEvents TranslateForm As System.Windows.Forms.Button
    Public WithEvents Phone As System.Windows.Forms.TextBox
    Public WithEvents Address As System.Windows.Forms.TextBox
    Public WithEvents CustomerID As System.Windows.Forms.TextBox
    Public WithEvents Fax As System.Windows.Forms.TextBox
    Friend WithEvents Fax_Label As System.Windows.Forms.Label
    Friend WithEvents Phone_Label As System.Windows.Forms.Label
    Friend WithEvents Address_Label As System.Windows.Forms.Label
    Public WithEvents CustomerName As System.Windows.Forms.TextBox
    Friend WithEvents CustID_Label As System.Windows.Forms.Label
    Friend WithEvents CustName_Label As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestForm))
        Me.ExitButton = New System.Windows.Forms.Button
        Me.FirstButton = New System.Windows.Forms.Button
        Me.PreviousButton = New System.Windows.Forms.Button
        Me.NextButton = New System.Windows.Forms.Button
        Me.LastButton = New System.Windows.Forms.Button
        Me.TranslateForm = New System.Windows.Forms.Button
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
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(368, 224)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ExitButton.Size = New System.Drawing.Size(72, 48)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'FirstButton
        '
        Me.FirstButton.Image = CType(resources.GetObject("FirstButton.Image"), System.Drawing.Image)
        Me.FirstButton.Location = New System.Drawing.Point(8, 224)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(72, 48)
        Me.FirstButton.TabIndex = 7
        '
        'PreviousButton
        '
        Me.PreviousButton.Image = CType(resources.GetObject("PreviousButton.Image"), System.Drawing.Image)
        Me.PreviousButton.Location = New System.Drawing.Point(88, 224)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(72, 48)
        Me.PreviousButton.TabIndex = 8
        '
        'NextButton
        '
        Me.NextButton.Image = CType(resources.GetObject("NextButton.Image"), System.Drawing.Image)
        Me.NextButton.Location = New System.Drawing.Point(160, 224)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(72, 48)
        Me.NextButton.TabIndex = 9
        '
        'LastButton
        '
        Me.LastButton.Image = CType(resources.GetObject("LastButton.Image"), System.Drawing.Image)
        Me.LastButton.Location = New System.Drawing.Point(240, 224)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(72, 48)
        Me.LastButton.TabIndex = 10
        '
        'TranslateForm
        '
        Me.TranslateForm.Location = New System.Drawing.Point(257, 104)
        Me.TranslateForm.Name = "TranslateForm"
        Me.TranslateForm.Size = New System.Drawing.Size(127, 56)
        Me.TranslateForm.TabIndex = 76
        Me.TranslateForm.Text = "Translate Form into French"
        '
        'Fax
        '
        Me.Fax.AcceptsReturn = True
        Me.Fax.BackColor = System.Drawing.SystemColors.Window
        Me.Fax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Fax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Fax.Location = New System.Drawing.Point(120, 136)
        Me.Fax.MaxLength = 12
        Me.Fax.Name = "Fax"
        Me.Fax.Size = New System.Drawing.Size(133, 25)
        Me.Fax.TabIndex = 81
        '
        'Fax_Label
        '
        Me.Fax_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Fax_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Fax_Label.Location = New System.Drawing.Point(6, 136)
        Me.Fax_Label.Name = "Fax_Label"
        Me.Fax_Label.Size = New System.Drawing.Size(112, 24)
        Me.Fax_Label.TabIndex = 87
        Me.Fax_Label.Text = "Fax"
        '
        'Phone
        '
        Me.Phone.AcceptsReturn = True
        Me.Phone.BackColor = System.Drawing.SystemColors.Window
        Me.Phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Phone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Phone.Location = New System.Drawing.Point(120, 104)
        Me.Phone.MaxLength = 12
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(134, 25)
        Me.Phone.TabIndex = 80
        '
        'Phone_Label
        '
        Me.Phone_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Phone_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Phone_Label.Location = New System.Drawing.Point(8, 104)
        Me.Phone_Label.Name = "Phone_Label"
        Me.Phone_Label.Size = New System.Drawing.Size(112, 24)
        Me.Phone_Label.TabIndex = 86
        Me.Phone_Label.Text = "Telephone"
        '
        'Address
        '
        Me.Address.AcceptsReturn = True
        Me.Address.BackColor = System.Drawing.SystemColors.Window
        Me.Address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Address.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Address.Location = New System.Drawing.Point(120, 72)
        Me.Address.MaxLength = 50
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(263, 25)
        Me.Address.TabIndex = 79
        '
        'Address_Label
        '
        Me.Address_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Address_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Address_Label.Location = New System.Drawing.Point(8, 72)
        Me.Address_Label.Name = "Address_Label"
        Me.Address_Label.Size = New System.Drawing.Size(112, 24)
        Me.Address_Label.TabIndex = 85
        Me.Address_Label.Text = "Address"
        '
        'CustName_Label
        '
        Me.CustName_Label.AccessibleDescription = ""
        Me.CustName_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CustName_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CustName_Label.Location = New System.Drawing.Point(8, 40)
        Me.CustName_Label.Name = "CustName_Label"
        Me.CustName_Label.Size = New System.Drawing.Size(112, 24)
        Me.CustName_Label.TabIndex = 84
        Me.CustName_Label.Text = "Customer Name"
        '
        'CustID_Label
        '
        Me.CustID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CustID_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CustID_Label.Location = New System.Drawing.Point(8, 8)
        Me.CustID_Label.Name = "CustID_Label"
        Me.CustID_Label.Size = New System.Drawing.Size(112, 24)
        Me.CustID_Label.TabIndex = 83
        Me.CustID_Label.Text = "Customer ID"
        '
        'CustomerName
        '
        Me.CustomerName.AcceptsReturn = True
        Me.CustomerName.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustomerName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerName.Location = New System.Drawing.Point(120, 40)
        Me.CustomerName.MaxLength = 50
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(263, 25)
        Me.CustomerName.TabIndex = 78
        '
        'CustomerID
        '
        Me.CustomerID.AcceptsReturn = True
        Me.CustomerID.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustomerID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerID.Location = New System.Drawing.Point(120, 8)
        Me.CustomerID.MaxLength = 4
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Size = New System.Drawing.Size(84, 26)
        Me.CustomerID.TabIndex = 77
        '
        'TestForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 280)
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
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TestForm"
        Me.Tag = "Orders Form"
        Me.Text = "TestForm"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FT As New DynamicComponents.FormTranslator()
    Dim CN As New ADODB.Connection()
    Dim oCustomers As New ADODB.Recordset()
    Dim oAccess As New Access.Application()
    Dim DAO_DBEngine As New DAO.DBEngine()

    Private Sub TestForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'establish DSN
        oAccess.DBEngine.RegisterDatabase("DCDM_Nwind", "Microsoft Access Driver (*.mdb)", True, "DBQ=" & VB6.GetPath & "\Nwind.mdb")
        CN.Open("DSN=DCDM_NWind")
        oCustomers.Open("Customers", CN, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        PopulateData()
        FT.TranslateForm(Me, CN, 2) 'Trnslate form into French 
    End Sub


    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        oAccess.Quit()
        Me.Close()

    End Sub

    Private Sub PopulateData()
        Me.CustomerID.Text = oCustomers.Fields("CustomerID").Value
        Me.CustomerName.Text = oCustomers.Fields("CustomerName").Value
        Me.Address.Text = oCustomers.Fields("Address").Value
        Me.Phone.Text = oCustomers.Fields("Phone").Value
        Me.Fax.Text = oCustomers.Fields("Fax").Value
    End Sub

    Private Sub FirstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstButton.Click
        oCustomers.MoveFirst()
        PopulateData()
    End Sub

    Private Sub PreviousButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousButton.Click
        On Error Resume Next

        oCustomers.MovePrevious()
        PopulateData()
    End Sub

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        On Error Resume Next

        oCustomers.MoveNext()
        PopulateData()
    End Sub

    Private Sub LastButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastButton.Click
        oCustomers.MoveLast()
        PopulateData()
    End Sub

    Private Sub TranslateForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranslateForm.Click

        If Me.TranslateForm.Text = "Translate Form into English" Then
            Me.TranslateForm.Text = "Translate Form into French"
            FT.TranslateForm(Me, CN, 3) 'Trnslate form into English 
        ElseIf Me.TranslateForm.Text = "Translate Form into French" Then
            Me.TranslateForm.Text = "Translate Form into Arabic"
            FT.TranslateForm(Me, CN, 2) 'Trnslate form into French 
        ElseIf Me.TranslateForm.Text = "Translate Form into Arabic" Then
            Me.TranslateForm.Text = "Translate Form into English"
            FT.TranslateForm(Me, CN, 1) 'Trnslate form into Arabic 
        End If


    End Sub
End Class
