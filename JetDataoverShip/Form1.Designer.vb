<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        TextBox1 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Label10 = New Label()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.IndianRed
        Label1.Location = New Point(341, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "Jet BoxData"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(219, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(247, 23)
        TextBox1.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(219, 348)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(247, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.GhostWhite
        Label2.Location = New Point(46, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 4
        Label2.Text = "Jet Name :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.GhostWhite
        Label3.Location = New Point(46, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 5
        Label3.Text = "Pilot Name : "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Ali", "Abdullah", "Asim", "Sheraz", "Saim Khan", "Asma Batool"})
        ComboBox1.Location = New Point(219, 129)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(247, 23)
        ComboBox1.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.GhostWhite
        Label5.Location = New Point(46, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 9
        Label5.Text = "Fuel Type :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.GhostWhite
        Label6.Location = New Point(46, 214)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 15)
        Label6.TabIndex = 10
        Label6.Text = "Pilot Age :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(219, 206)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(247, 23)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(219, 482)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(247, 23)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(219, 553)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(247, 23)
        TextBox5.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.GhostWhite
        Label7.Location = New Point(47, 490)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 15)
        Label7.TabIndex = 14
        Label7.Text = "Ship Name : "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.GhostWhite
        Label8.Location = New Point(46, 561)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 15)
        Label8.TabIndex = 15
        Label8.Text = "Captain Name :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.GhostWhite
        Label9.Location = New Point(46, 356)
        Label9.Name = "Label9"
        Label9.Size = New Size(91, 15)
        Label9.TabIndex = 16
        Label9.Text = "Date And Time :"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Jet A-1", "Jet A", "Jet B"})
        ComboBox2.Location = New Point(219, 280)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(247, 23)
        ComboBox2.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Desktop
        Button1.ForeColor = Color.FloralWhite
        Button1.Location = New Point(362, 627)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 37)
        Button1.TabIndex = 18
        Button1.Text = "Send Data"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.InactiveCaptionText
        Button2.ForeColor = Color.FloralWhite
        Button2.Location = New Point(646, 627)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 21
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.GhostWhite
        Label10.Location = New Point(12, 423)
        Label10.Name = "Label10"
        Label10.Size = New Size(177, 15)
        Label10.TabIndex = 22
        Label10.Text = "Catapult Officer Satisfy his Work"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(219, 415)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(247, 23)
        TextBox2.TabIndex = 23
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkTurquoise
        ClientSize = New Size(943, 662)
        Controls.Add(TextBox2)
        Controls.Add(Label10)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Jett"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
