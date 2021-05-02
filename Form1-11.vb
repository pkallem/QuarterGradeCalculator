Public Class frmAverageGrade
    Private Sub btnCalculateTheAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateTheAverage.Click
        Dim dblGradeYouEntered As Double
        Dim dblAverage As Double

        For intCount = 1 To 5

            dblGradeYouEntered = Convert.ToDouble(InputBox("Enter your first grade here", "Enter your numbers"))

            lblLabel.Text &= "Grade Entered: " & dblGradeYouEntered & vbCrLf
            dblAverage += dblGradeYouEntered

        Next intCount



        lblLabel.Text &= "Grade Average:  " & dblAverage / 5
    End Sub
End Class
