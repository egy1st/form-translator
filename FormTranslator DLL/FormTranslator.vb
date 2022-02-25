Namespace DynamicComponents
    Public Class FormTranslator
        Inherits System.ComponentModel.Component

#Region " Component Designer generated code "

        Public Sub New(ByVal Container As System.ComponentModel.IContainer)
            MyClass.New()

            'Required for Windows.Forms Class Composition Designer support
            Container.Add(Me)
        End Sub

        Public Sub New()
            MyBase.New()

            'This call is required by the Component Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'Component overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Component Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Component Designer
        'It can be modified using the Component Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
        End Sub

#End Region


        Private MyForm As New System.Windows.Forms.Form()
        Private MyGrid As New AxMSDataGridLib.AxDataGrid()
        Private Col_ControlName As New Collection()
        Private Col_ControlIndex As New Collection()
        Private HasGrid As Boolean = False
        Private oMaster As New ADODB.Recordset()
        Private FlipState As Boolean = False
        Private Col_GridFields As New Collection()
        Private CN As New ADODB.Connection()

        Private Function ZeroPad(ByVal str_String As String, ByVal int_Count As Byte) As String
            If str_String <> "" And int_Count <> 0 Then
                Return (New String("0", int_Count - Len(Trim(str_String))) & Trim(str_String))
            ElseIf int_Count = 0 Then
                Return str_String
            End If
        End Function


        Public Sub TranslateForm(ByRef dm_Form As System.Windows.Forms.Form, ByRef dm_DSN As ADODB.Connection, ByVal dm_Language As Byte)

            Dim TxtCtrl As New Control()
            Dim X As Byte
           
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