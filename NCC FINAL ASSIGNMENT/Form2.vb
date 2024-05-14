Public Class Form2
    Dim randomnumber(10) As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 0 To 9
            randomnumber(i) = CInt(Rnd() * 100) + 1
        Next


        ListBox1.Items.Clear()

        ListBox1.Items.Add("UNSORTED")
        For i = 0 To 9
            ListBox1.Items.Add(randomnumber(i).ToString())
        Next


        Dim swapped As Boolean = True ' method to see if any swaps have been made
        ' 

        For i = 1 To 9
            Dim key As Integer = randomnumber(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso randomnumber(j) > key
                randomnumber(j + 1) = randomnumber(j)
                j -= 1
                If j < 0 Then Exit While
            End While
            randomnumber(j + 1) = key

        Next
        ListBox1.Items.Add("")
        ListBox1.Items.Add("SORTED:")
        For i = 0 To 9
            ListBox1.Items.Add(randomnumber(i).ToString())
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For i = 0 To 9
            randomnumber(i) = CInt(Rnd() * 100) + 1
        Next

        ListBox1.Items.Clear()


        ListBox1.Items.Add("UNSORTED:")
        For i = 0 To 9
            ListBox1.Items.Add(randomnumber(i).ToString())
        Next


        For i = 1 To 9 '' 
            Dim key As Integer = randomnumber(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso randomnumber(j) > key
                randomnumber(j + 1) = randomnumber(j)
                j -= 1
                If j < 0 Then Exit While
            End While
            randomnumber(j + 1) = key
        Next


        ListBox1.Items.Add("")
        ListBox1.Items.Add("SORTED:")
        For i = 0 To 9
            ListBox1.Items.Add(randomnumber(i).ToString())
        Next
    End Sub
End Class