Namespace DynamicComponents
    Public Class FormTranslator

        Private MyForm As New System.Windows.Forms.Form()
        Private MyGrid As New AxMSDataGridLib.AxDataGrid()
        Private Col_ControlName As New Collection()
        Private Col_ControlIndex As New Collection()
        Private HasGrid As Boolean = False
        Private oMaster As New ADODB.Recordset()
        Private FlipState As Boolean = False
        Private Col_GridFields As New Collection()
        Private CN As New ADODB.Connection()

        Public Sub TranslateForm(ByRef dm_Form As System.Windows.Forms.Form, ByRef dm_DSN As ADODB.Connection, ByVal dm_Language As Byte)
            Dim MyProtect As New MyProtection()

            Dim _ProductId As String
            Dim _CompanyId As String
            Dim _CompanyInfo As String
            Dim _ProductVersion As String
            Dim _buynow_URL As String

            _CompanyId = "EgyFirst Software"
            _ProductId = "FormTranslator"
            _ProductVersion = "V. 3.5"

            _CompanyInfo = "Form Translator V. 3.5" + vbCrLf
            _CompanyInfo += "Powered by EgyFirst Software, Inc." + vbCrLf
            _CompanyInfo += "Free 30 Days Trial Version"

            _buynow_URL = "http://www.mygoldensoft.com/ordernow.html"

            MyProtect.SetProductKeys(_CompanyId, _ProductId, _ProductVersion)
            MyProtect.SetAlgorithms(1971, 18, 35)
            MyProtect.SetInformation(_buynow_URL, _CompanyInfo)
            MyProtect.SetLicense(30)
            'MyProtect.ShowAuthor()
            If MyProtect.NotLicensed = True Then
                'Return 
            End If



            Dim TxtCtrl As New Control()
            Dim X As Byte
            Dim Num As Byte = 0
            Dim Num2 As Byte = 0
            Dim MyControl As System.Windows.Forms.Control
            Dim oLang As New ADODB.Recordset()


            MyForm = dm_Form
            CN = dm_DSN

            X = 0
            For Each TxtCtrl In dm_Form.Controls
                If TypeName(TxtCtrl) = "TextBox" Then
                    Col_ControlName.Add(TxtCtrl)
                    Col_ControlIndex.Add(X)
                End If
                X += 1
            Next TxtCtrl



            FlipState = True
            oLang.Open("MultiLanguage", CN, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            oLang.Filter = "Tag = '" + dm_Form.Name + "' and Id = '" + dm_Form.Name + "'"
            If Not oLang.EOF Then
                dm_Form.Text = oLang.Fields("Language" + dm_Language.ToString).Value
            End If

            For Each MyControl In dm_Form.Controls
                If TypeName(MyControl) = "Label" Then
                    oLang.Filter = "Tag = '" + dm_Form.Name + "' and Id = '" + MyControl.Name + "'"
                    If Not oLang.EOF Then
                        MyControl.Text = oLang.Fields("Language" + dm_Language.ToString).Value
                    End If
                End If
            Next MyControl

            If HasGrid Then
                Dim Num3 As Byte
                For Num3 = 0 To MyGrid.Columns.Count - 1
                    oLang.Filter = "Tag = '" + dm_Form.Name + "' and Id = '" + MyGrid.Name + "_" + MyGrid.Columns(Num3).DataField + "'"
                    If Not oLang.EOF Then
                        Col_GridFields.Add(oLang.Fields("Language" + dm_Language.ToString).Value)
                    Else
                        Col_GridFields.Add(MyGrid.Columns(Num3).Caption)
                    End If
                Next Num3
            End If

        End Sub

    End Class
End Namespace