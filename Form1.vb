'1. Import SQL Client (Download Microsoft.Data.SqlClient from Packages using Manage NuGet Packages)
Imports Microsoft.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        '1. Create variables for the form fields
        Dim firstName As String = firstName_txtbox.Text
        Dim lastName As String = lastName_txtbox.Text
        Dim gender As String = gender_cbox.Text

        '2. Creat insert sql query
        Dim query As String = "INSERT INTO members VALUES (@firstName, @lastName, @gender)"

        '3. Create connection to SQL Server
        Using con As SqlConnection = New SqlConnection("Data Source=STC-PSONB06;Initial Catalog=memberDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")

            '4. Create SQL command using query and con values
            Using cmd As SqlCommand = New SqlCommand(query, con)

                '5. Map variables to query values
                cmd.Parameters.AddWithValue("@firstName", firstName)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@gender", gender)

                '6. Open SQL connection and execute SQL command
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                '7. Clears fields after successful insert
                firstName_txtbox.Text = ""
                lastName_txtbox.Text = ""
                gender_cbox.Text = ""

                MessageBox.Show("Successfully Inserted!")

                '8. Calls Public Sub BindData() to Reflect Inserted Record in Data Grid View
                BindData()

            End Using
        End Using
    End Sub

    Public Sub BindData()
        '1. SQL Select Query
        Dim query As String = "SELECT * FROM members"

        '2. SQL Server Connection
        Using con As SqlConnection = New SqlConnection("Data Source=STC-PSONB06;Initial Catalog=memberDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")

            '3. SQL Command using query and con values
            Using cmd As SqlCommand = New SqlCommand(query, con)

                '4. Create New SQL Data Adapter
                Using da As New SqlDataAdapter()

                    '5. Execute Select Command
                    da.SelectCommand = cmd

                    '6. Create New Data Table
                    Using dt As New DataTable()

                        '7. Fill Data Table with SQL Command result via SQL Data Adapter Select Function
                        da.Fill(dt)

                        '8. Set Data Source for Data Grid
                        search_dtgrid.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        '1. SQL Select Query
        Dim query As String = "SELECT * FROM members WHERE firstName = '" & search_txtbox.Text & "' OR lastName = '" & search_txtbox.Text & "'"

        '2. SQL Server Connection
        Using con As SqlConnection = New SqlConnection("Data Source=STC-PSONB06;Initial Catalog=memberDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")

            '3. SQL Command using query and con values
            Using cmd As SqlCommand = New SqlCommand(query, con)

                '4. Create New SQL Data Adapter
                Using da As New SqlDataAdapter()

                    '5. Execute Select Command
                    da.SelectCommand = cmd

                    '6. Create New Data Table
                    Using dt As New DataTable()

                        '7. Fill Data Table with SQL Command result via SQL Data Adapter Select Function
                        da.Fill(dt)

                        '8. Check for the results and fill appropriate text box based on the first data match, return null if there are no results found
                        If dt.Rows.Count > 0 Then
                            idValue_lbl.Text = dt.Rows(0)(0).ToString()
                            firstName_txtbox.Text = dt.Rows(0)(1).ToString()
                            lastName_txtbox.Text = dt.Rows(0)(2).ToString()
                            gender_cbox.Text = dt.Rows(0)(3).ToString()
                        Else
                            idValue_lbl.Text = ""
                            firstName_txtbox.Text = ""
                            lastName_txtbox.Text = ""
                            gender_cbox.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        '1. Create variables for the form fields
        Dim id As String = idValue_lbl.Text
        Dim firstName As String = firstName_txtbox.Text
        Dim lastName As String = lastName_txtbox.Text
        Dim gender As String = gender_cbox.Text

        '2. Creat insert sql query
        Dim query As String = "UPDATE members SET firstName = @firstName, lastName = @lastName, gender = @gender WHERE id = @id"

        '3. Create connection to SQL Server
        Using con As SqlConnection = New SqlConnection("Data Source=STC-PSONB06;Initial Catalog=memberDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")

            '4. Create SQL command using query and con values
            Using cmd As SqlCommand = New SqlCommand(query, con)

                '5. Map variables to query values
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@firstName", firstName)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@gender", gender)

                '6. Open SQL connection and execute SQL command
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                '7. Clears fields after successful insert
                idValue_lbl.Text = ""
                firstName_txtbox.Text = ""
                lastName_txtbox.Text = ""
                gender_cbox.Text = ""

                MessageBox.Show("Successfully Updated!")

                '8. Calls Public Sub BindData() to Reflect Inserted Record in Data Grid View
                BindData()

            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim id As String = idValue_lbl.Text

        '1. Creat insert sql query
        Dim query As String = "DELETE FROM members WHERE id = @id"

        '2. Create connection to SQL Server
        Using con As SqlConnection = New SqlConnection("Data Source=STC-PSONB06;Initial Catalog=memberDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")

            '3. Create SQL command using query and con values
            Using cmd As SqlCommand = New SqlCommand(query, con)

                '4. Map variables to query values
                cmd.Parameters.AddWithValue("@id", id)

                '5. Open SQL connection and execute SQL command
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                '6. Clears fields after successful insert
                idValue_lbl.Text = ""
                firstName_txtbox.Text = ""
                lastName_txtbox.Text = ""
                gender_cbox.Text = ""

                MessageBox.Show("Successfully Deleted!")

                '7. Calls Public Sub BindData() to Reflect Inserted Record in Data Grid View
                BindData()

            End Using
        End Using
    End Sub

    Private Sub search_dtgrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles search_dtgrid.CellContentClick

    End Sub
End Class
