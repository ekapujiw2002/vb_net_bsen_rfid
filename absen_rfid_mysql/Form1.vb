Imports MySql.Data.MySqlClient

Public Class Form1

    Dim colRemovedTabs As New Collection()

    Dim buffer_serial_port As String

    Const query_absen_hari_ini As String = "SELECT `NAMA`, `WAKTU MASUK`, `STATUS` " & _
        "FROM " & _
        "( " & _
        "SELECT DISTINCT(regx.id_user) ID, regx.nama NAMA,  " & _
        "IFNULL(logx.waktu_masuk,'???') 'WAKTU MASUK', " & _
        "(IF(ISNULL(logx.waktu_masuk),'TIDAK ADA','ADA')) 'STATUS' " & _
        "FROM registrasi regx " & _
        "LEFT JOIN  " & _
        "( " & _
        "SELECT *  " & _
        "FROM log_absensi " & _
        "WHERE DATE(waktu)=CURRENT_DATE() " & _
        ") logx " & _
        "ON regx.id_user=logx.id_user " & _
        "ORDER BY regx.nama " & _
        ") absen"


    Sub CreateReportAbsen(ByVal datex As DateTime, ByRef dgx As DataGridView, ByRef viewer As WebBrowser)
        Try
            Dim query_absen_report As String = "SELECT `NAMA`, `WAKTU MASUK`, `WAKTU KELUAR`, `STATUS` " & _
        "FROM " & _
        "( " & _
        "SELECT DISTINCT(regx.id_user) ID, regx.nama NAMA,  " & _
        "IFNULL(logx.waktu_masuk,'???') 'WAKTU MASUK', " & _
        "IFNULL(logx.waktu_keluar,'???') 'WAKTU KELUAR', " & _
        "(IF(ISNULL(logx.waktu_masuk),'TIDAK ADA','ADA')) 'STATUS' " & _
        "FROM registrasi regx " & _
        "LEFT JOIN  " & _
        "( " & _
        "SELECT *  " & _
        "FROM log_absensi " & _
        "WHERE DATE(waktu)='" & datex.ToString("yyyy-MM-dd") & "' " & _
        ") logx " & _
        "ON regx.id_user=logx.id_user " & _
        "ORDER BY regx.nama " & _
        ") absen"

            Dim filex As System.IO.StreamWriter = New System.IO.StreamWriter("report.html")
            Dim repx As String = "<!doctype html><html><head><title> LAPORAN ABSEN " & datex.ToString("dd-MM-yyyy") & "</title>" & _
                "<style>table {border-collapse: collapse;} table,td,th {border: 1px  solid black; padding: 5px;} th {text-align: center; font-weight: bold;} tbody {text-align: left;}</style>" & _
                "</head><body>" & _
                "<center><h1>LAPORAN ABSENSI</h1>" & _
                "<h3>" & datex.ToString("dd-MM-yyyy") & "</h3></center>"

            If Not IsNothing(dgx) Then
                'fill the datagridview
                mysql_reload(query_absen_report)
                mysql_filltable(dgx)

                'build table
                Dim sLine As String = "<center><table>"

                'build header
                Dim c As Integer, r As Integer
                sLine &= "<thead><tr>"
                For c = 0 To (dgx.ColumnCount - 1)
                    sLine &= "<th>" & dgx.Columns(c).HeaderText & "</th>"
                Next
                sLine &= "</tr></thead>"

                'build content
                'loop all rows
                sLine &= "<tbody>"
                'MsgBox(dgx.RowCount)
                For r = 0 To (dgx.RowCount - 2)
                    sLine &= "<tr>"

                    'loop all column
                    For c = 0 To (dgx.ColumnCount - 1)
                        sLine &= "<td>" & dgx.Rows(r).Cells(c).Value & "</td>"
                    Next

                    sLine &= "</tr>"
                Next
                sLine &= "</tbody>"

                sLine &= "</table></center>"
                repx &= sLine
            End If

            repx &= "</body></html>"

            With filex
                .Write(repx)
                .Close()
            End With

            If Not IsNothing(viewer) Then
                With viewer
                    '.Navigate("about:blank")
                    '.Document.Write(IO.File.ReadAllText("report.html"))
                    .Navigate("file:///" & IO.Path.GetFullPath(".\report.html"))
                End With
            End If

        Catch ex As Exception
            MsgBox("Error create report : " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    ''' <summary>
    ''' show hide tab pages
    ''' </summary>
    ''' <param name="page"></param>
    ''' <remarks></remarks>
    Sub ShowHideTabPage(ByVal page As TabPage)
        If TabControlMain.Contains(TabPageInfo) Then
            colRemovedTabs.Add(page, page.Name)
            TabControlMain.Controls.Remove(page)
        Else
            TabControlMain.Controls.Add(page)
            colRemovedTabs.Remove(page.Name)
        End If
    End Sub

    ''' <summary>
    ''' query to datagridview
    ''' </summary>
    ''' <param name="query"></param>
    ''' <param name="dtgrid"></param>
    ''' <remarks></remarks>
    Sub ShowQueryResultToDataGrid(ByVal query As String, ByRef dtgrid As DataGridView)
        Try
            mysql_reload(query)
            mysql_filltable(dtgrid)
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' user pilih index tab beda
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TabControlMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlMain.SelectedIndexChanged
        'MessageBox.Show(TabControlMain.SelectedIndex.ToString())
        Try
            mysql_con.Close()
            ShowQueryResultToDataGrid(query_absen_hari_ini, DataGridViewMain)
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' aplikasi loading
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            CheckForIllegalCrossThreadCalls = False

            DateTimePickerReport.Value = Now

            'ShowHideTabPage(TabPageKonfigurasi)
            LabelInfoAbsen.Text = "SYSTEM" & vbCrLf & "READY"

            DataGridViewMain.Font = New Font("Arial", 18)

            ShowQueryResultToDataGrid(query_absen_hari_ini, DataGridViewMain)

            ButtonRefresh_Click(Nothing, Nothing)

            With SerialPortRFID
                .PortName = My.Settings.port_reader
                .Open()
            End With

        Catch ex As Exception
            MessageBox.Show("Error at : " & ex.Message())
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrint.Click
        Try
            WebBrowser1.ShowPrintPreviewDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    ''' <summary>
    ''' timer tick per 1sec
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TimerMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMain.Tick
        Try
            LabelSystemStatus.Text = Now.ToString("dd-MM-yyyy hh:mm:ss")
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' serial port receive data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SerialPortRFID_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPortRFID.DataReceived
        Dim do_absen As Boolean = False
        Dim str_query As String

        Try

            buffer_serial_port = SerialPortRFID.ReadTo(vbCr)

            If SerialPortRFID.ReadExisting.Length = 0 Then
                Me.Invoke(
                Sub()
                    'update content
                    TextBoxDATAID.Text = buffer_serial_port
                    TextBoxDataNama.Clear()
                    LabelInfoAbsen.Text = buffer_serial_port & vbCrLf & "???"

                    'check the new data
                    If mysql_query_to_reader("select nama from registrasi where id_user='" & buffer_serial_port & "'") Then

                        'update it if got any data on the database
                        If mysql_data_reader.Read() Then
                            TextBoxDataNama.Text = mysql_data_reader.GetString(0)
                            LabelInfoAbsen.Text = buffer_serial_port & vbCrLf & mysql_data_reader.GetString(0)

                            'add ke absen
                            do_absen = True
                        End If
                        mysql_data_reader.Close()
                        mysql_con.Close()

                        'add ke absen
                        If do_absen Then

                            If mysql_query_to_reader("SELECT count(nama) FROM log_absensi WHERE DATE(waktu)=CURRENT_DATE() AND id_user='" & buffer_serial_port & "'") Then

                                If mysql_data_reader.Read Then

                                    If mysql_data_reader.GetUInt16(0) = 1 Then
                                        'update pulang
                                        str_query = "update log_absensi set waktu_keluar='" & Now.ToString("hh:mm:ss") & "', nama='" & TextBoxDataNama.Text & "' where id_user='" & buffer_serial_port & "' and DATE(waktu)=CURRENT_DATE()"
                                    Else
                                        'add masuk
                                        str_query = "insert into log_absensi(id_user,nama,waktu_masuk) values('" & buffer_serial_port & "','" & TextBoxDataNama.Text & "','" & Now.ToString("hh:mm:ss") & "')"
                                    End If
                                    mysql_data_reader.Close()
                                    mysql_con.Close()

                                    'MsgBox(str_query)

                                    If mysql_con.State = ConnectionState.Closed Then
                                        mysql_con.Open()
                                    End If

                                    With mysql_cmd
                                        .Connection = mysql_con
                                        .CommandText = str_query


                                        If mysql_cmd.ExecuteNonQuery <> 0 Then
                                            LabelInfoAbsen.Text = LabelInfoAbsen.Text & vbCrLf & "OK"

                                            mysql_con.Close()
                                            ShowQueryResultToDataGrid(query_absen_hari_ini, DataGridViewMain)
                                        Else
                                            LabelInfoAbsen.Text = LabelInfoAbsen.Text & vbCrLf & "ERROR"
                                        End If

                                    End With
                                End If


                            End If
                            mysql_data_reader.Close()
                            mysql_con.Close()

                        End If
                    End If

                    buffer_serial_port = ""
                End Sub
                )

            End If

        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' refresh master data view
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        Try
            ShowQueryResultToDataGrid("select no as NO, waktu as WAKTU, id_user as ID,nama as NAMA from registrasi order by no", DataGridViewMasterData)
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' add new user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonMasterDataInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMasterDataInsert.Click
        Try
            mysql_create("insert into registrasi(id_user,nama) values('" & TextBoxDATAID.Text & "','" & TextBoxDataNama.Text & "')")

            TextBoxDATAID.Clear()
            TextBoxDataNama.Clear()

            ButtonRefresh_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>
    ''' update selected data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonUpdateMasterData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdateMasterData.Click
        Try
            mysql_updates("update registrasi set nama='" & TextBoxDataNama.Text & "' where id_user='" & TextBoxDATAID.Text & "'")

            TextBoxDATAID.Clear()
            TextBoxDataNama.Clear()

            ButtonRefresh_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>
    ''' delete selected data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonDeleteMasterData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteMasterData.Click
        Try
            mysql_delete("delete from registrasi where id_user='" & TextBoxDATAID.Text & "'")

            TextBoxDATAID.Clear()
            TextBoxDataNama.Clear()

            ButtonRefresh_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>
    ''' got data entered
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TextBoxDATAID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDATAID.TextChanged
        Try
            ButtonMasterDataInsert.Enabled = TextBoxDATAID.TextLength > 0
            ButtonDeleteMasterData.Enabled = TextBoxDATAID.TextLength > 0
            ButtonUpdateMasterData.Enabled = TextBoxDATAID.TextLength > 0
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' master data double clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataGridViewMasterData_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewMasterData.DoubleClick
        Try
            TextBoxDATAID.Text = DataGridViewMasterData.CurrentRow.Cells(2).Value
            TextBoxDataNama.Text = DataGridViewMasterData.CurrentRow.Cells(3).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePickerReport_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerReport.ValueChanged
        Try
            CreateReportAbsen(DateTimePickerReport.Value, DataGridViewReport, WebBrowser1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
