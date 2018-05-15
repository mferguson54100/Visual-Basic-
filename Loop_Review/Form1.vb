Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intNumber As Integer
        Dim strNumber As String
        Dim intCount As Integer


        If Integer.TryParse(intNumber, strNumber) Then
            If intNumber >= 0 Then
                intCount = 1
                For intCount = 1 To 5 'test the condition
                    strNumber = InputBox("Please enter number.")
                    lstNumber.Items.Add(strNumber)
                Next

            Else
                MessageBox.Show("Please enter a positive number.")
            End If

        Else
            MessageBox.Show("Please enter a number.")

        End If
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intAverage As Integer
        Dim intCount As Integer

        intCount = 1
        Do While lstNumber.Items.Count > intCount
            intAverage += lstNumber.Items(intCount)
            intCount += 1



        Loop
        MessageBox.Show("The average is " & intAverage / 5)
    End Sub

    Private Sub ctnClear_Click(sender As Object, e As EventArgs) Handles ctnClear.Click
        lstNumber.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class