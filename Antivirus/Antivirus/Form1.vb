Public Class Form1

   

    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Public Sub cheack()
        If GunaCheckBox1.Checked = False And GunaCheckBox2.Checked = False And GunaCheckBox3.Checked = False And GunaCheckBox4.Checked = False Then
            Button1.BackColor = Color.Red
            PictureBox1.BackColor = Color.Red
            Label1.BackColor = Color.Red
            Label3.BackColor = Color.Red
            Label4.BackColor = Color.Red
            Label5.BackColor = Color.Red
            Label6.BackColor = Color.Red

            GunaCheckBox1.BackColor = Color.Red
            GunaCheckBox2.BackColor = Color.Red
            GunaCheckBox3.BackColor = Color.Red
            GunaCheckBox4.BackColor = Color.Red

            Button1.FlatAppearance.MouseDownBackColor = Color.Red
            Button1.FlatAppearance.MouseOverBackColor = Color.Red

            Label53.Visible = True
            Label54.Visible = True

            Label19.Visible = False

            Label56.Visible = False
        ElseIf GunaCheckBox1.Checked = True And GunaCheckBox2.Checked = True And GunaCheckBox3.Checked = True And GunaCheckBox4.Checked = True Then

            Button1.BackColor = Label35.ForeColor
            PictureBox1.BackColor = Label35.ForeColor
            Label1.BackColor = Label35.ForeColor
            Label3.BackColor = Label35.ForeColor
            Label4.BackColor = Label35.ForeColor
            Label5.BackColor = Label35.ForeColor
            Label6.BackColor = Label35.ForeColor
            GunaCheckBox1.BackColor = Label35.ForeColor
            GunaCheckBox2.BackColor = Label35.ForeColor
            GunaCheckBox3.BackColor = Label35.ForeColor
            GunaCheckBox4.BackColor = Label35.ForeColor

            Button1.FlatAppearance.MouseDownBackColor = Label35.ForeColor
            Button1.FlatAppearance.MouseOverBackColor = Label35.ForeColor

            Label53.Visible = False
            Label54.Visible = False

            Label19.Visible = True

            Label56.Visible = False
        End If
    End Sub
    Public Sub check_P()
        If GunaCheckBox1.Checked = False Or GunaCheckBox2.Checked = False Or GunaCheckBox3.Checked = False Or GunaCheckBox4.Checked = False Then
            Label19.Visible = False
            Label53.Visible = False
            Label54.Visible = False
            Label55.Visible = False

            Label56.Visible = True

            Button1.BackColor = Label56.ForeColor
            PictureBox1.BackColor = Label56.ForeColor
            Label1.BackColor = Label56.ForeColor
            Label3.BackColor = Label56.ForeColor
            Label4.BackColor = Label56.ForeColor
            Label5.BackColor = Label56.ForeColor
            Label6.BackColor = Label56.ForeColor
            GunaCheckBox1.BackColor = Label56.ForeColor
            GunaCheckBox2.BackColor = Label56.ForeColor
            GunaCheckBox3.BackColor = Label56.ForeColor
            GunaCheckBox4.BackColor = Label56.ForeColor

            Button1.FlatAppearance.MouseDownBackColor = Label56.ForeColor
            Button1.FlatAppearance.MouseOverBackColor = Label56.ForeColor

        End If
    End Sub

    Public Sub mouseUP_X()
        drag = False
    End Sub
    Public Sub mouseDown_X()
        drag = True
        mouseX = Windows.Forms.Cursor.Position.X - Me.Left
        mouseY = Windows.Forms.Cursor.Position.Y - Me.Top

    End Sub
    Public Sub mouseMove_X()
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - mouseY
        End If
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        mouseDown_X()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        mouseMove_X()
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        mouseUP_X()
    End Sub

    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = Label35.ForeColor
        PictureBox1.BackColor = Label35.ForeColor
        Label1.BackColor = Label35.ForeColor
        Label3.BackColor = Label35.ForeColor
        Label4.BackColor = Label35.ForeColor
        Label5.BackColor = Label35.ForeColor
        Label6.BackColor = Label35.ForeColor
        GunaCheckBox1.BackColor = Label35.ForeColor
        GunaCheckBox2.BackColor = Label35.ForeColor
        GunaCheckBox3.BackColor = Label35.ForeColor
        GunaCheckBox4.BackColor = Label35.ForeColor

        Button1.FlatAppearance.MouseDownBackColor = Label35.ForeColor
        Button1.FlatAppearance.MouseOverBackColor = Label35.ForeColor
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouseDown_X()
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        mouseMove_X()
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mouseUP_X()
    End Sub

    

    Private Sub Label41_MouseHover(sender As Object, e As EventArgs) Handles Label41.MouseHover
        Label51.Visible = True
    End Sub

    Private Sub Label41_MouseLeave(sender As Object, e As EventArgs) Handles Label41.MouseLeave
        Label51.Visible = False
    End Sub



    Private Sub Label38_MouseHover(sender As Object, e As EventArgs) Handles Label38.MouseHover
        Label50.Visible = True
    End Sub

    Private Sub Label38_MouseLeave(sender As Object, e As EventArgs) Handles Label38.MouseLeave
        Label50.Visible = False
    End Sub

   

    Private Sub Label37_MouseHover(sender As Object, e As EventArgs) Handles Label37.MouseHover
        Label49.Visible = True
    End Sub

    Private Sub Label37_MouseLeave(sender As Object, e As EventArgs) Handles Label37.MouseLeave
        Label49.Visible = False
    End Sub

   

    Private Sub Label7_MouseHover(sender As Object, e As EventArgs) Handles Label7.MouseHover
        Label48.Visible = True
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label48.Visible = False
    End Sub

   

    Private Sub Label8_MouseHover(sender As Object, e As EventArgs) Handles Label8.MouseHover
        Label47.Visible = True
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label47.Visible = False
    End Sub

  

    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover
        Label46.Visible = True
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label46.Visible = False
    End Sub


    Private Sub Label10_MouseHover(sender As Object, e As EventArgs) Handles Label10.MouseHover
        Label45.Visible = True
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave
        Label45.Visible = False
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Label23.Visible = True
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Label23.Visible = False
        Label24.Visible = True
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = True
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = True
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = True
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = True
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = True
        Label30.Visible = False
        Label31.Visible = False
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = True
        Label31.Visible = False
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Button5.Text = "ON") Then
            Button5.Text = "OFF"

            Button5.BackColor = Label32.ForeColor
        ElseIf Button5.Text = "OFF" Then
            Button5.Text = "ON"
            Button5.BackColor = Label36.ForeColor
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Button6.Text = "ON") Then
            Button6.Text = "OFF"

            Button6.BackColor = Label32.ForeColor
            Label33.ForeColor = Label32.ForeColor
        ElseIf Button6.Text = "OFF" Then
            Button6.Text = "ON"
            Button6.BackColor = Color.Red
            Label33.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click
        If Label36.Text = "few moment ago" Then
            Label36.Text = "up to date"
        ElseIf Label36.Text = "up to date" Then
            Label36.Text = "few moment ago"
        End If
    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox1.CheckedChanged
        check_P()
        cheack()
    End Sub

    Private Sub GunaCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox2.CheckedChanged
        check_P()
        cheack()
    End Sub

    Private Sub GunaCheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox3.CheckedChanged
        check_P()
        cheack()
    End Sub

    Private Sub GunaCheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox4.CheckedChanged
        check_P()
        cheack()
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click
        Try
            Process.Start("https://rahedmir.github.io")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Try
            Process.Start("https://twitter.com/rahed_mir")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Try
            Process.Start("https://www.youtube.com/channel/UCtLpmx-8qNG4m-6it076-7w")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click
        Try
            Process.Start("https://blog.emsisoft.com/en/35235/ransomware-data-exfiltration-detection-and-mitigation-strategies/facebook-1-3/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click
        Try
            Process.Start("https://blog.emsisoft.com/en/35879/pwndlocker-ransomware-decryption-now-available/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Label43.Visible = True
        Label52.Visible = False
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Label43.Visible = False
        Label52.Visible = True
    End Sub

    

    Private Sub Label54_MouseHover(sender As Object, e As EventArgs) Handles Label54.MouseHover
        Label55.Visible = True
    End Sub

    Private Sub Label54_MouseLeave(sender As Object, e As EventArgs) Handles Label54.MouseLeave
        Label55.Visible = False
    End Sub

    
    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click
        GunaCheckBox1.Checked = True
        GunaCheckBox2.Checked = True
        GunaCheckBox3.Checked = True
        GunaCheckBox4.Checked = True


        Button1.BackColor = Label35.ForeColor
        PictureBox1.BackColor = Label35.ForeColor
        Label1.BackColor = Label35.ForeColor
        Label3.BackColor = Label35.ForeColor
        Label4.BackColor = Label35.ForeColor
        Label5.BackColor = Label35.ForeColor
        Label6.BackColor = Label35.ForeColor
        GunaCheckBox1.BackColor = Label35.ForeColor
        GunaCheckBox2.BackColor = Label35.ForeColor
        GunaCheckBox3.BackColor = Label35.ForeColor
        GunaCheckBox4.BackColor = Label35.ForeColor

        Button1.FlatAppearance.MouseDownBackColor = Label35.ForeColor
        Button1.FlatAppearance.MouseOverBackColor = Label35.ForeColor

        Label53.Visible = False
        Label54.Visible = False

        Label19.Visible = True
    End Sub
End Class
