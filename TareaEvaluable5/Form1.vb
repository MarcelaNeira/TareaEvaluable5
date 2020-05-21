Public Class Form1
    Public ficheroXML As String = My.Application.Info.DirectoryPath + "\xmlBaseDatos.xml"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists(ficheroXML) = True Then
            DataSet1.ReadXml(ficheroXML)
        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        DataTable1BindingSource.AddNew()
    End Sub

    Private Sub DataTable1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DataTable1BindingNavigatorSaveItem.Click
        Me.Validate()
        DataTable1BindingSource.EndEdit()
        DataSet1.WriteXml(ficheroXML)
        DataTable1DataGridView.Refresh()
        MessageBox.Show("Los Datos se guardaron exitosamente")
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        DataTable1BindingSource.RemoveCurrent()
    End Sub
End Class
