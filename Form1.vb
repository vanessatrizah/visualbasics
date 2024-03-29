Public Class Form1
    Dim cropsList As New List(Of String())
    Private Sub AddCrop_Click(sender As Object, e As EventArgs) Handles AddCrop.Click
        Dim cropName As String = InputBox("Enter Crop Name:", "Add Crop")
        Dim variety As String = InputBox("Enter Variety:", "Add Crop")
        Dim plantingDate As String = InputBox("Enter Planting Date:", "Add Crop")
        Dim harvestingDate As String = InputBox("Enter Harvesting Date:", "Add Crop")
        Dim cropDetails As String = $"{cropName}, {variety}, Planting: {plantingDate}, Harvesting: {harvestingDate}"
        cropsList.Add(cropDetails)
    End Sub

    Private Sub DeleteCrop_Click(sender As Object, e As EventArgs) Handles DeleteCrop.Click
        Dim indexString As String = InputBox("Enter the index of the crop to delete:", "Delete Crop")
        Dim index As Integer
        If Integer.TryParse(indexString, index) AndAlso index >= 0 AndAlso index < cropsList.Count Then
            cropsList.RemoveAt(index)
        Else
            MessageBox.Show("Invalid index. Please enter a valid index.")
        End If

    End Sub

    Private Sub ViewCrop_Click(sender As Object, e As EventArgs) Handles ViewCrop.Click
        MessageBox.Show("List of Crops:" & vbCrLf & String.Join(vbCrLf, cropsList))
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class