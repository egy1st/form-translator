Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NWindDataSet.OrderDetails' table. You can move, or remove it, as needed.
        Me.OrderDetailsTableAdapter.Fill(Me.NWindDataSet.OrderDetails)

    End Sub

End Class