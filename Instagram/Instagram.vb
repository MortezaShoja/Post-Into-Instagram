Imports System.Text
Imports System.IO
Imports System.ComponentModel
Imports System.Net

Public Class Instagram
    Private LastLink As String = String.Empty

    Private Sub Instagram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not System.IO.Directory.Exists("C:\InstagramMessaging") Then
            System.IO.Directory.CreateDirectory("C:\InstagramMessaging")
        End If

        If Not System.IO.Directory.Exists("C:\InstagramMessaging\System") Then
            System.IO.Directory.CreateDirectory("C:\InstagramMessaging\System")
        End If

        If Not System.IO.Directory.Exists("C:\InstagramMessaging\Images") Then
            System.IO.Directory.CreateDirectory("C:\InstagramMessaging\Images")
        End If

        If Not System.IO.File.Exists("C:\InstagramMessaging\System\Settings.sys") Then
            Dim SW As New System.IO.StreamWriter("C:\InstagramMessaging\System\Settings.sys")
            SW.WriteLine("30,Women,579,681,700,191,550,230,10,10,20,20")

            SW.Flush()
            SW.Close()
        End If

        LoadSettings()

    End Sub

    Private Sub LoadSettings()
        Try
            Dim SR As New System.IO.StreamReader("C:\InstagramMessaging\System\Settings.sys")
            Dim Settings() As String = SR.ReadToEnd.ToString.Split(",")
            SR.Close()

            Me.NuDelay.Value = Settings(0)
            Me.cboGender.Text = Settings(1)

            Me.NuAddPhotoX.Value = Settings(2)
            Me.NuAddPhotoY.Value = Settings(3)

            Me.NuNextShareX.Value = Settings(4)
            Me.NuNextShareY.Value = Settings(5)

            Me.NuCaptionX.Value = Settings(6)
            Me.NuCaptionY.Value = Settings(7)


        Catch ex As Exception
            Me.txtError.Text += "3_" & ex.Message.ToString & vbCrLf
        End Try
    End Sub

    Private Sub btnSaveLocations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveLocations.Click
        Dim SW As New System.IO.StreamWriter("C:\InstagramMessaging\System\Settings.sys")
        SW.WriteLine(Me.NuDelay.Value & "," & Me.cboGender.Text & "," & Me.NuAddPhotoX.Value & "," & Me.NuAddPhotoY.Value & "," & Me.NuNextShareX.Value & "," & Me.NuNextShareY.Value & "," & Me.NuCaptionX.Value & "," & Me.NuCaptionY.Value)
        SW.Flush()
        SW.Close()
    End Sub

    Private Sub TimerPointing_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPointing.Tick
        Dim MousePosition As Point
        MousePosition = Cursor.Position
        Me.lblMouseX.Text = MousePosition.X.ToString
        Me.lblMouseY.Text = MousePosition.Y.ToString
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Me.TimerDelay.Interval = Integer.Parse(Me.NuDelay.Value) * 60000
        Me.TimerDelay.Enabled = True
        NextPost()
    End Sub

    Private Sub DoPost(ByVal ProductCode As Integer, ByVal Message As String, ByVal ImageAddress As String)

        MoveCursor(Me.NuAddPhotoX.Value, Me.NuAddPhotoY.Value) ' AddPhoto
        Win32.mouse_event(Win32.MOUSEEVENTF_LEFTDOWN, 50, 50, 50, 50)
        Threading.Thread.Sleep(100)
        Win32.mouse_event(Win32.MOUSEEVENTF_LEFTUP, 50, 50, 50, 50)
        Threading.Thread.Sleep(1000)

        'C:\Users\Morteza\OneDrive\Pictures\Texture\e8aa6277941794ba79005e43d9e5d2ad-colorful-crystal-polygonal-background.jpg
        My.Computer.Clipboard.SetText(ImageAddress)
        SendKeys.SendWait("^(v)") ' Paste Address
        Threading.Thread.Sleep(100)
        SendKeys.SendWait("{ENTER}")
        Threading.Thread.Sleep(5000)
        'SendKeys.SendWait("{ENTER}")
        'Threading.Thread.Sleep(1000)
        My.Computer.Clipboard.Clear()


        MoveCursor(Me.NuNextShareX.Value, Me.NuNextShareY.Value) ' Next And Share
        Win32.mouse_event(Win32.MOUSEEVENTF_LEFTDOWN, 50, 50, 50, 50)
        Threading.Thread.Sleep(100)
        Win32.mouse_event(Win32.MOUSEEVENTF_LEFTUP, 50, 50, 50, 50)
        Threading.Thread.Sleep(3000)

        MoveCursor(Me.NuCaptionX.Value, Me.NuCaptionY.Value) ' SelectCaption
        Win32.mouse_event(Win32.MOUSEEVENTF_LEFTDOWN, 50, 50, 50, 50)
        Threading.Thread.Sleep(100)
        Win32.mouse_event(Win32.MOUSEEVENTF_LEFTUP, 50, 50, 50, 50)
        Threading.Thread.Sleep(3000)

        'My.Computer.Clipboard.SetText("---------------------------")

        Dim tmpMessage() As String = Message.Split(vbCrLf)
        For I As Integer = 0 To tmpMessage.Length - 1
            Try
                My.Computer.Clipboard.Clear()
                Dim tmpCurrentMessageLine As String = tmpMessage(I).Replace(vbLf, "")
                My.Computer.Clipboard.SetText(tmpCurrentMessageLine)
                SendKeys.SendWait("^(v)") ' Paste Caption
                Threading.Thread.Sleep(100)
                SendKeys.SendWait("{ENTER}")
                Threading.Thread.Sleep(100)
                'SendKeys.SendWait("{ENTER}")
                'Threading.Thread.Sleep(100)
            Catch ex As Exception
                SendKeys.SendWait("{ENTER}")
                Threading.Thread.Sleep(100)
            End Try
        Next

        Threading.Thread.Sleep(1000)
        'Message = Message.Replace(vbLf, vbCrLf)

        'My.Computer.Clipboard.Clear()
        'My.Computer.Clipboard.SetText(Message)
        'SendKeys.SendWait("^(v)") ' Paste Caption
        'SendKeys.SendWait("{ENTER}")
        'Threading.Thread.Sleep(1000)

        'SendKeys.SendWait("{ENTER}")
        'Threading.Thread.Sleep(1000)

        MoveCursor(Me.NuNextShareX.Value, Me.NuNextShareY.Value) ' Next And Share
        Win32.mouse_event(Win32.MOUSEEVENTF_LEFTDOWN, 50, 50, 50, 50)
        Threading.Thread.Sleep(100)
        Win32.mouse_event(Win32.MOUSEEVENTF_LEFTUP, 50, 50, 50, 50)
        Threading.Thread.Sleep(15000)

        My.Computer.Clipboard.Clear()

        Dim SqlCon As New SqlConnectionShop
        Dim Cmd As New SqlClient.SqlCommand
        Try
            Cmd.Parameters.Add("@Row", SqlDbType.Int).Value = ProductCode
            Cmd.Parameters.Add("@InstagramSentTime", SqlDbType.DateTime).Value = Now.ToString
            Cmd.CommandText = "Update Products set InstagramSentTime=@InstagramSentTime Where Row=@Row"
            Cmd.Connection = SqlCon.SqlCon
            SqlCon.SqlCon.Open()
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Me.txtError.Text += "2_" & ex.Message.ToString & vbCrLf
        Finally
            SqlCon.SqlCon.Close()
        End Try

    End Sub

    Private Sub MoveCursor(ByVal X As Integer, ByVal Y As Integer)
        ' Set the Current cursor, move the cursor's Position, 
        ' and set its clipping rectangle to the form.  

        Me.Cursor = New Cursor(Cursor.Current.Handle)
        Cursor.Position = New Point(X, Y)
        ' Cursor.Clip = New Rectangle(Me.Location, Me.Size)
    End Sub


    Private Sub TimerDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDelay.Tick

        NextPost()

    End Sub

    Private Sub NextPost()

        Dim ProductCode As Integer = 0

        Me.TimerDelay.Enabled = False

        'For Each _file As String In Directory.GetFiles("C:\Users\Morteza\Pictures\Camera Roll")
        '    File.Delete(_file)
        'Next

        Dim SqlCon As New SqlConnectionShop
        Dim Cmd As New SqlClient.SqlCommand

        Dim tmpWebSiteName() As String = SqlCon.SqlCon.ConnectionString.ToString.Split(";")
        Dim WebSiteName() As String = tmpWebSiteName(0).Split("=")
        Try
            Cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = Me.cboGender.Text
            Cmd.CommandText = "Select Row,InstagramMessage from Products where InstagramSentTime is null and InstagramMessage is not null and Gender=@Gender"
            Cmd.Connection = SqlCon.SqlCon
            SqlCon.SqlCon.Open()
            Dim sdr As SqlClient.SqlDataReader = Cmd.ExecuteReader
            While sdr.Read

                ProductCode = sdr(0).ToString

                Dim SourceImageURL As String = "http://www." & WebSiteName(1) & "/WaterMark/Instagram_" & ProductCode & ".jpg"
                Dim DestinationFile As String = "C:\InstagramMessaging\Images\Instagram_" & ProductCode & ".jpg"

                Dim Client As New WebClient
                Client.DownloadFile(SourceImageURL, DestinationFile)
                Client.Dispose()
                'Threading.Thread.Sleep(5000)

                'My.Computer.Clipboard.SetText(sdr(1).ToString)
                DoPost(sdr(0), sdr(1).ToString.Replace("%23", "#"), DestinationFile)
            End While
        Catch ex As Exception
            Me.txtError.Text += "1_" & ex.Message.ToString & vbCrLf
        Finally
            SqlCon.SqlCon.Close()
        End Try


        Me.TimerDelay.Enabled = True
    End Sub

    Private Sub Instagram_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Me.Location = New Point(90, 50)
    End Sub
End Class