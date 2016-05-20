Public Class Form1

    Private Sub btnO_1_Click(sender As Object, e As EventArgs) Handles btnO_1.Click
        'Big O 1.
        Dim mewnbwn As String
        Dim Presennol As Boolean = True

        mewnbwn = txtMewnbwn.Text
        If mewnbwn = "" Then
            Presennol = False
            MsgBox("Angen data")
        Else
            Presennol = True
            MsgBox("Data yno")
        End If
    End Sub


    Private Sub btn_O_N_Click(sender As Object, e As EventArgs) Handles btn_O_N.Click
        Dim Mewnbwn As Integer
        Dim i As Integer

        Mewnbwn = CInt(txtMewnbwn.Text)

        For i = 0 To Mewnbwn
            lblAllbwn.Text = lblAllbwn.Text & vbCrLf & "Gwneud hyn " & i & " o weithiau!" & vbCrLf
        Next

    End Sub

    Private Sub btnO_N2_Click(sender As Object, e As EventArgs) Handles btnO_N2.Click
        Dim Mewnbwn As Integer
        Dim i As Integer
        Dim j As Integer

        Mewnbwn = CInt(txtMewnbwn.Text)
       
        For j = 0 To Mewnbwn
            lblAllbwn.Text = lblAllbwn.Text & vbCrLf & "Ar gyfer grwp " & j
            For i = 0 To Mewnbwn
                lblAllbwn.Text = lblAllbwn.Text & vbCrLf & "Gwneud hyn " & i & " o weithiau!"
            Next i
        Next j
        lblAllbwn.Text = lblAllbwn.Text & vbCrLf & "Wedi gwneud hyn " & (i * j) & " o weithiau!"
    End Sub

    Private Sub btnO_2N_Click(sender As Object, e As EventArgs) Handles btnO_2N.Click
        Dim Mewnbwn As Integer
        Dim Ateb As Integer
        Dim Nifer As Integer = 0
        
        Mewnbwn = CInt(txtMewnbwn.Text)
        If Mewnbwn < 2 Then
            MsgBox("rhaid cael o leiaf 2 rhif i gychwyn cyfres Fibonacci")
        Else

            Ateb = Fibonacci(Mewnbwn, Nifer)

            lblAllbwn.Text = lblAllbwn.Text & vbCrLf & Ateb & " wedi gwneud " & Nifer & " o weithiau"
        End If
    End Sub
    Private Function Fibonacci(ByVal Rhif As Integer, ByRef n As Integer) As Integer
        'lblAllbwn.Text = lblAllbwn.Text & vbCrLf & (Rhif - 1) & " , "
        n = n + 1
        If Rhif <= 1 Then
            Return Rhif
        Else
            Return Fibonacci(Rhif - 2, n) + Fibonacci(Rhif - 1, n)
        End If
    End Function
   

End Class
