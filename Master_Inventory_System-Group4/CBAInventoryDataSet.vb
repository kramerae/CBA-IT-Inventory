

Partial Public Class CBAInventoryDataSet
    Partial Public Class qryGetEmployeeListDataTable
        Private Sub qryGetEmployeeListDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.txtFirstNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace CBAInventoryDataSetTableAdapters

    Partial Public Class qryGetEmployeeListTableAdapter
    End Class
End Namespace
