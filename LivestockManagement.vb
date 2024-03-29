Public Class Form1
    Dim livestockList As New List(Of String)
    Private Sub BtnAddLivestock_Click(sender As Object, e As EventArgs) Handles BtnAddLivestock.Click
        Dim animalType As String = InputBox("Enter Animal Type:", "Add Livestock")
        Dim feedingSchedule As String = InputBox("Enter Feeding Schedule:", "Add Livestock")
        Dim breedingDetails As String = InputBox("Enter Breeding Details:", "Add Livestock")
        Dim healthMonitoring As String = InputBox("Enter Health Monitoring Details:", "Add Livestock")
        Dim livestockDetails As String = $"Type: {animalType}, Feeding: {feedingSchedule}, Breeding: {breedingDetails}, Health Monitoring: {healthMonitoring}"
        livestockList.Add(livestockDetails)
    End Sub

    Private Sub BtnDeleteLivestock_Click(sender As Object, e As EventArgs) Handles BtnDeleteLivestock.Click
        Dim indexString As String = InputBox("Enter the index of the livestock to delete:", "Delete Livestock")
        Dim index As Integer
        If Integer.TryParse(indexString, index) AndAlso index >= 0 AndAlso index < livestockList.Count Then
            livestockList.RemoveAt(index)
        Else
            MessageBox.Show("Invalid index. Please enter a valid index.")
        End If
    End Sub

    Private Sub BtnViewLivestock_Click(sender As Object, e As EventArgs) Handles BtnViewLivestock.Click
        MessageBox.Show("List of Livestock:" & vbCrLf & String.Join(vbCrLf, livestockList))
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
