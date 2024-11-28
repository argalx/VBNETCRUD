<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        appTitle_lbl = New Label()
        cu_panel = New Panel()
        idValue_lbl = New Label()
        Label1 = New Label()
        gender_cbox = New ComboBox()
        update_btn = New Button()
        insert_btn = New Button()
        lastName_txtbox = New TextBox()
        firstName_txtbox = New TextBox()
        gender_lbl = New Label()
        lastName_lbl = New Label()
        firstName_lbl = New Label()
        rd_panel = New Panel()
        search_dtgrid = New DataGridView()
        delete_btn = New Button()
        search_btn = New Button()
        search_txtbox = New TextBox()
        cu_panel.SuspendLayout()
        rd_panel.SuspendLayout()
        CType(search_dtgrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' appTitle_lbl
        ' 
        appTitle_lbl.AutoSize = True
        appTitle_lbl.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        appTitle_lbl.Location = New Point(231, 34)
        appTitle_lbl.Name = "appTitle_lbl"
        appTitle_lbl.Size = New Size(352, 37)
        appTitle_lbl.TabIndex = 0
        appTitle_lbl.Text = "VB.NET CRUD SQL SERVER"
        ' 
        ' cu_panel
        ' 
        cu_panel.BorderStyle = BorderStyle.FixedSingle
        cu_panel.Controls.Add(idValue_lbl)
        cu_panel.Controls.Add(Label1)
        cu_panel.Controls.Add(gender_cbox)
        cu_panel.Controls.Add(update_btn)
        cu_panel.Controls.Add(insert_btn)
        cu_panel.Controls.Add(lastName_txtbox)
        cu_panel.Controls.Add(firstName_txtbox)
        cu_panel.Controls.Add(gender_lbl)
        cu_panel.Controls.Add(lastName_lbl)
        cu_panel.Controls.Add(firstName_lbl)
        cu_panel.Location = New Point(12, 112)
        cu_panel.Name = "cu_panel"
        cu_panel.Size = New Size(383, 250)
        cu_panel.TabIndex = 1
        ' 
        ' idValue_lbl
        ' 
        idValue_lbl.AutoSize = True
        idValue_lbl.Font = New Font("Segoe UI", 12.0F)
        idValue_lbl.Location = New Point(130, 42)
        idValue_lbl.Name = "idValue_lbl"
        idValue_lbl.Size = New Size(0, 21)
        idValue_lbl.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F)
        Label1.Location = New Point(92, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 21)
        Label1.TabIndex = 11
        Label1.Text = "ID :"
        ' 
        ' gender_cbox
        ' 
        gender_cbox.FormattingEnabled = True
        gender_cbox.Items.AddRange(New Object() {"Male", "Female"})
        gender_cbox.Location = New Point(132, 158)
        gender_cbox.Name = "gender_cbox"
        gender_cbox.Size = New Size(215, 23)
        gender_cbox.TabIndex = 10
        ' 
        ' update_btn
        ' 
        update_btn.Location = New Point(272, 195)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(75, 23)
        update_btn.TabIndex = 9
        update_btn.Text = "UPDATE"
        update_btn.UseVisualStyleBackColor = True
        ' 
        ' insert_btn
        ' 
        insert_btn.Location = New Point(132, 195)
        insert_btn.Name = "insert_btn"
        insert_btn.Size = New Size(75, 23)
        insert_btn.TabIndex = 8
        insert_btn.Text = "INSERT"
        insert_btn.UseVisualStyleBackColor = True
        ' 
        ' lastName_txtbox
        ' 
        lastName_txtbox.Location = New Point(132, 120)
        lastName_txtbox.Name = "lastName_txtbox"
        lastName_txtbox.Size = New Size(215, 23)
        lastName_txtbox.TabIndex = 6
        ' 
        ' firstName_txtbox
        ' 
        firstName_txtbox.Location = New Point(132, 81)
        firstName_txtbox.Name = "firstName_txtbox"
        firstName_txtbox.Size = New Size(215, 23)
        firstName_txtbox.TabIndex = 5
        ' 
        ' gender_lbl
        ' 
        gender_lbl.AutoSize = True
        gender_lbl.Font = New Font("Segoe UI", 12.0F)
        gender_lbl.Location = New Point(47, 158)
        gender_lbl.Name = "gender_lbl"
        gender_lbl.Size = New Size(77, 21)
        gender_lbl.TabIndex = 3
        gender_lbl.Text = "GENDER :"
        ' 
        ' lastName_lbl
        ' 
        lastName_lbl.AutoSize = True
        lastName_lbl.Font = New Font("Segoe UI", 12.0F)
        lastName_lbl.Location = New Point(24, 120)
        lastName_lbl.Name = "lastName_lbl"
        lastName_lbl.Size = New Size(100, 21)
        lastName_lbl.TabIndex = 2
        lastName_lbl.Text = "LAST NAME :"
        ' 
        ' firstName_lbl
        ' 
        firstName_lbl.AutoSize = True
        firstName_lbl.Font = New Font("Segoe UI", 12.0F)
        firstName_lbl.Location = New Point(20, 81)
        firstName_lbl.Name = "firstName_lbl"
        firstName_lbl.Size = New Size(104, 21)
        firstName_lbl.TabIndex = 1
        firstName_lbl.Text = "FIRST NAME :"
        ' 
        ' rd_panel
        ' 
        rd_panel.BorderStyle = BorderStyle.FixedSingle
        rd_panel.Controls.Add(search_dtgrid)
        rd_panel.Controls.Add(delete_btn)
        rd_panel.Controls.Add(search_btn)
        rd_panel.Controls.Add(search_txtbox)
        rd_panel.Location = New Point(405, 112)
        rd_panel.Name = "rd_panel"
        rd_panel.Size = New Size(383, 250)
        rd_panel.TabIndex = 2
        ' 
        ' search_dtgrid
        ' 
        search_dtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        search_dtgrid.Location = New Point(33, 81)
        search_dtgrid.Name = "search_dtgrid"
        search_dtgrid.Size = New Size(333, 137)
        search_dtgrid.TabIndex = 11
        ' 
        ' delete_btn
        ' 
        delete_btn.Location = New Point(291, 40)
        delete_btn.Name = "delete_btn"
        delete_btn.Size = New Size(75, 23)
        delete_btn.TabIndex = 10
        delete_btn.Text = "DELETE"
        delete_btn.UseVisualStyleBackColor = True
        ' 
        ' search_btn
        ' 
        search_btn.Location = New Point(210, 40)
        search_btn.Name = "search_btn"
        search_btn.Size = New Size(75, 23)
        search_btn.TabIndex = 9
        search_btn.Text = "SEARCH"
        search_btn.UseVisualStyleBackColor = True
        ' 
        ' search_txtbox
        ' 
        search_txtbox.Location = New Point(33, 40)
        search_txtbox.Name = "search_txtbox"
        search_txtbox.Size = New Size(165, 23)
        search_txtbox.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 378)
        Controls.Add(rd_panel)
        Controls.Add(cu_panel)
        Controls.Add(appTitle_lbl)
        Name = "Form1"
        Text = "Form1"
        cu_panel.ResumeLayout(False)
        cu_panel.PerformLayout()
        rd_panel.ResumeLayout(False)
        rd_panel.PerformLayout()
        CType(search_dtgrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents appTitle_lbl As Label
    Friend WithEvents cu_panel As Panel
    Friend WithEvents rd_panel As Panel
    Friend WithEvents update_btn As Button
    Friend WithEvents insert_btn As Button
    Friend WithEvents lastName_txtbox As TextBox
    Friend WithEvents firstName_txtbox As TextBox
    Friend WithEvents gender_lbl As Label
    Friend WithEvents lastName_lbl As Label
    Friend WithEvents firstName_lbl As Label
    Friend WithEvents search_dtgrid As DataGridView
    Friend WithEvents delete_btn As Button
    Friend WithEvents search_btn As Button
    Friend WithEvents search_txtbox As TextBox
    Friend WithEvents gender_cbox As ComboBox
    Friend WithEvents idValue_lbl As Label
    Friend WithEvents Label1 As Label

End Class
