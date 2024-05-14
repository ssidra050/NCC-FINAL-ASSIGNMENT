Imports System.Reflection.Emit

Public Class Form3
    Dim r As IO.StreamReader

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        r = New IO.StreamReader("C:\Users\M Taha\OneDrive\Desktop\read from external file.txt")
        ListBox1.Items.Clear()
        While (r.Peek > -1)
            ListBox1.Items.Add(r.ReadLine)
        End While
        r.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim searchnumber As Integer = CInt(TextBox1.Text)
        Dim index As Integer = -1 ' Initialize the index variable to -1

        ' search for the number in the list box
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If CType(ListBox1.Items(i), Integer) = searchnumber Then
                index = i

                Exit For
            End If
        Next
        If index = -1 Then
            Lblresult.Text = "Number not found in the list."
        Else
            Lblresult.Text = $"Number found at index{index}."
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim target As String = TextBox1.Text
        Dim index As Integer = linearsearch(target)
        If index >= 0 Then
            MessageBox.Show("item found using linear search at : " & index)
        Else
            MessageBox.Show("item not found using linear search")
        End If
    End Sub

    Public Function linearsearch(ByVal target As String) As String
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i) = target Then
                Return i
            End If
        Next
    End Function

    Public Sub binarysearch(ByVal target As String)
        Dim lowerbound As Integer = 0
        Dim upperbound As Integer = ListBox1.Items.Count - 1

        While lowerbound <= upperbound
            Dim middle As Integer = (lowerbound + upperbound) \ 2
            Dim currentitem As String = ListBox1.Items(middle)

            If currentitem = target Then
                MessageBox.Show("item found using brinary : " & currentitem)
                Exit Sub
            ElseIf currentitem < target Then
                lowerbound = middle + 1
            Else
                upperbound = middle - 1

            End If
        End While

        MessageBox.Show("item not found: " & target)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim data As List(Of String) = ListBox1.Items.Cast(Of String)().ToList()
        data.Sort()
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(data.ToArray())
        binarysearch(TextBox1.Text)

    End Sub
End Class