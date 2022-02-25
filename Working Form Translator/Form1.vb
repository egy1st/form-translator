Public Class Form1
    Dim FT As New DynamicComponents.FormTranslator()
    Dim CN As New ADODB.Connection()
    Dim oCust As New ADODB.Recordset()
    Dim oAccess As New Microsoft.Office.Interop.Access.Application

    Private Sub TestForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'establish DSN
        oAccess.DBEngine.RegisterDatabase("DCDM_Nwind", "Microsoft Access Driver (*.mdb)", True, "DBQ=" & Application.StartupPath & "\Nwind.mdb")
        CN.Open("DSN=DCDM_NWind")
        oCust.Open("Customers", CN, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        PopulateDate()
        PopulateDate()
        FT.TranslateForm(Me, CN, 2) 'Trnslate form into French 

    End Sub


    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        oAccess.Quit()
        Me.Close()

    End Sub

    Private Sub PopulateDate()
        Me.CustomerID.Text = oCust.Fields("CustomerID").Value
        Me.CustomerName.Text = oCust.Fields("CustomerName").Value
        Me.Address.Text = oCust.Fields("Address").Value
        Me.Phone.Text = oCust.Fields("Phone").Value
        Me.Fax.Text = oCust.Fields("Fax").Value

    End Sub

    Private Sub FirstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstButton.Click
        oCust.MoveFirst()
        PopulateDate()
    End Sub

    Private Sub PreviousButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousButton.Click
        On Error Resume Next

        oCust.MovePrevious()
        PopulateDate()
    End Sub

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        On Error Resume Next

        oCust.MoveNext()
        PopulateDate()
    End Sub

    Private Sub LastButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastButton.Click
        oCust.MoveLast()
        PopulateDate()
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

