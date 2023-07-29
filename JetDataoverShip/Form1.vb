Imports System.CodeDom
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form1
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cn = New SqlConnection
        cn.ConnectionString = "data source=MSTAR\SQLEXPRESS; initial catalog=JetoverShip; integrated security=true"
        Dim reader As SqlDataReader

        Try
            cn.Open()
            Dim query As String
            query = "INSERT INTO JetData(Jet_Name,Pilot_Name,Pilot_Age,Fuel_Type,Date_Time,Catapult,Ship_Name,Captain_Name) 
                            VALUES('" & TextBox1.Text & "', '" & ComboBox1.SelectedItem & "' , '" & TextBox3.Text & "', 
                            '" & ComboBox2.SelectedItem & "', '" & DateTimePicker1.Text & "' , '" & TextBox2.Text & "','" & TextBox4.Text & "',
                             '" & TextBox5.Text & "')"

            cmd = New SqlCommand(query, cn)
            reader = cmd.ExecuteReader()
            MessageBox.Show("Data Saved")
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            cn.Dispose()
        End Try

    End Sub
End Class
