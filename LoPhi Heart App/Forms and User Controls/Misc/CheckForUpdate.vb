Imports System.IO
Imports System.Net

Partial Public Class ECG_MainForm
    Private Sub CheckAndUpdate()
        Try
            Dim request As HttpWebRequest = WebRequest.Create(UpdateUrl)
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

            Using reader As New StreamReader(response.GetResponseStream())
                Dim updateInfo As String = reader.ReadToEnd()
                Dim parts() As String = updateInfo.Split(";;")

                If parts.Length >= 2 Then
                    Dim updateVersionString As String = parts(0).Trim()
                    Dim downloadUrl As String = parts(1).Trim()

                    If Version.TryParse(updateVersionString, Nothing) AndAlso CurrentVersion < New Version(updateVersionString) Then
                        MessageBox.Show("A new update is available. Please update the software to continue.", "Update Required", MessageBoxButtons.OK)
                        Try
                            Process.Start(New ProcessStartInfo(downloadUrl) With {.UseShellExecute = True})
                        Catch ex As Exception
                            MessageBox.Show("Error opening the download URL: " & ex.Message, "Error")
                        End Try

                        Application.Exit() ' Close the application
                    Else
                        'MessageBox.Show("Your software is up to date.", "No Update Required")
                    End If
                Else
                    MessageBox.Show("Update information not found or in an unexpected format.", "Error")
                    Application.Exit()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking for updates: " & ex.Message, "Error")
            Application.Exit()
        End Try
    End Sub

    Private Sub checksettings()
        If My.Settings.UpgradeRequired Then
            My.Settings.Upgrade()
            My.Settings.UpgradeRequired = False
            My.Settings.Save()
        End If
    End Sub
End Class
