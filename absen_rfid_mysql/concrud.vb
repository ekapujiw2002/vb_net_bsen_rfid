Imports MySql.Data.MySqlClient
Module concrud
    'setting up your connection
    Public Function mysqlconnection() As MySqlConnection
        'Return New MySqlConnection("server=localhost;user id=root;password=1234567890;database=absen_rfid")
        Return New MySqlConnection("server=" & My.Settings.db_host & _
                                   ";user id=" & My.Settings.db_user & _
                                   ";password=" & My.Settings.db_password & _
                                   ";database=" & My.Settings.db_name)
    End Function
    Public mysql_con As MySqlConnection = mysqlconnection()

    ''declaring a string 
    Public result As String

    ''declaring the class 
    Public mysql_cmd As New MySqlCommand
    Public mysql_da As New MySqlDataAdapter
    Public mysql_dt As New DataTable
    Public mysql_data_reader As MySqlDataReader

    ''for inserting the data to the database
    Public Sub mysql_create(ByVal sql As String)

        Try
            mysql_con.Close()
            'open the connection
            mysql_con.Open()
            'holds the data 
            With mysql_cmd
                .Connection = mysql_con
                .CommandText = sql

                'execute the data
                result = mysql_cmd.ExecuteNonQuery

                If result = 0 Then
                    MsgBox("no data save", MsgBoxStyle.Information)
                Else
                    MsgBox("data save to the database")
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mysql_con.Close()
    End Sub

    'for holding the data to retrieve.
    Public Sub mysql_reload(ByVal sql As String)
        Try
            mysql_con.Close()
            mysql_dt = New DataTable
            mysql_con.Open()
            With mysql_cmd
                .Connection = mysql_con
                .CommandText = sql
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mysql_con.Close()
        mysql_da.Dispose()
    End Sub

    'filling the table and retrieving the data to the datagridview from the database
    Public Sub mysql_filltable(ByVal dtg As DataGridView)
        Try
            mysql_con.Close()
            mysql_con.Open()
            ''''''''
            '''''''''''''''fill table
            mysql_da.SelectCommand = mysql_cmd
            mysql_da.Fill(mysql_dt)
            dtg.DataSource = mysql_dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mysql_con.Close()
        mysql_da.Dispose()
    End Sub

    'updating the data from the database.
    Public Sub mysql_updates(ByVal sql As String)
        Try
            mysql_con.Close()
            mysql_con.Open()
            With mysql_cmd
                .Connection = mysql_con
                .CommandText = sql
                result = mysql_cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("no updated data", MsgBoxStyle.Information)
                Else
                    MsgBox("Data in the database has been updated")
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mysql_con.Close()
    End Sub

    'deleting the data from the database
    Public Sub mysql_delete(ByVal sql As String)
        Try
            mysql_con.Close()
            mysql_con.Open()
            With mysql_cmd
                .Connection = mysql_con
                .CommandText = sql

                result = mysql_cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Error query for deleting a data.", MsgBoxStyle.Critical)
                Else
                    MsgBox("Data in the database has been deleted")
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mysql_con.Close()
    End Sub

    'to reader
    Public Function mysql_query_to_reader(ByVal Sql As String) As Boolean
        Dim retx As Boolean = False
        Try
            mysql_con.Close()
            mysql_con.Open()

            With mysql_cmd
                .Connection = mysql_con
                .CommandText = Sql

                mysql_data_reader = mysql_cmd.ExecuteReader()

                retx = True
            End With

            'mysql_con.Close()
        Catch ex As Exception
            mysql_con.Close()
        End Try

        Return retx
    End Function


End Module
