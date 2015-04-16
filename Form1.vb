Public Class Form1
    Private MyDictionary As New Dictionary(Of String, Decimal)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyDictionary.Add("Cheeseburger", 5.99)
        MyDictionary.Add("Regular Burger", 1.29)
        MyDictionary.Add("Chicken Fingers", 1.29)
        MyDictionary.Add("Large Drink", 1.25)
        UpdateMenu()
    End Sub
    Private Sub UpdateMenu()
        'UPDATE LISTBOX
        lbxmenu.Items.Clear()

        For Each mystring As String In From kvp In MyDictionary Select String.Format("{0}: ${1}", kvp.Key, kvp.Value)
            lbxmenu.Items.Add(mystring)
        Next
    End Sub

    Private Sub cmdadditem_Click(sender As Object, e As EventArgs) Handles cmdadditem.Click
        If txtitem.Text <> "" And txtprice.Text <> "" Then
            If MyDictionary.ContainsKey(txtitem.Text) Then
                MyDictionary(txtitem.Text) = txtprice.Text
            Else
                MyDictionary.Add(txtitem.Text, System.Convert.ToDecimal(txtprice.Text))

            End If
        End If

        UpdateMenu()
    End Sub
End Class
