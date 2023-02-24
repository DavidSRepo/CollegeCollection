Friend Class Form1
    Inherits System.Windows.Forms.Form
    ' Intro Graphics Demo -- for student experiments
    ' by Lemery and ???
    ' Date:  ???
    ' Goal:  Mess with rectangles, circles, etc.

    Private Sub cmdDraw_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDraw.Click
        ' draws various shapes

        Dim x As Integer
        Dim y As Integer

        With picA.CreateGraphics

            ' DrawRectangle takes 5 parameters:
            '                pen color, x, y, width, height

            .DrawRectangle(Pens.Blue, 100, 50, 200, 200)
            ' experiment - make new rectangles
            '    with other colors, locations, sizes.



            .DrawEllipse(Pens.Gray, 100, 50, 200, 200)
            ' experiment - make new ellipses with other features



            y = 300
            For x = 150 To 300 Step 50
                .DrawRectangle(Pens.Purple, x, 100, 50, 60)
            Next x
            ' experiment with changing the code above
            ' change stepsize, y, width, etc. 



        End With
    End Sub
End Class