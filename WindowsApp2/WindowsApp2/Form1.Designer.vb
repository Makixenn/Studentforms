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
        Me.L_name = New System.Windows.Forms.TextBox()
        Me.Lname_label = New System.Windows.Forms.Label()
        Me.F_name = New System.Windows.Forms.TextBox()
        Me.Fname_label = New System.Windows.Forms.Label()
        Me.Mname_label = New System.Windows.Forms.Label()
        Me.M_name = New System.Windows.Forms.TextBox()
        Me.Ages = New System.Windows.Forms.TextBox()
        Me.Age_label = New System.Windows.Forms.Label()
        Me.Bday = New System.Windows.Forms.TextBox()
        Me.Bday_label = New System.Windows.Forms.Label()
        Me.Home = New System.Windows.Forms.TextBox()
        Me.home_label = New System.Windows.Forms.Label()
        Me.G_level = New System.Windows.Forms.TextBox()
        Me.Glevel_label = New System.Windows.Forms.Label()
        Me.U_case = New System.Windows.Forms.Button()
        Me.L_case = New System.Windows.Forms.Button()
        Me.Hide_all = New System.Windows.Forms.Button()
        Me.Show_all = New System.Windows.Forms.Button()
        Me.Message = New System.Windows.Forms.RichTextBox()
        Me.Red_BG = New System.Windows.Forms.Button()
        Me.Blue_BG = New System.Windows.Forms.Button()
        Me.Green_BG = New System.Windows.Forms.Button()
        Me.White_BG = New System.Windows.Forms.Button()
        Me.Generate = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.txtFsize = New System.Windows.Forms.TextBox()
        Me.Fsizes = New System.Windows.Forms.Label()
        Me.GotoGeo = New System.Windows.Forms.Button()
        Me.Enabling = New System.Windows.Forms.Button()
        Me.Disabling = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L_name
        '
        Me.L_name.Location = New System.Drawing.Point(129, 98)
        Me.L_name.Name = "L_name"
        Me.L_name.Size = New System.Drawing.Size(165, 20)
        Me.L_name.TabIndex = 0
        '
        'Lname_label
        '
        Me.Lname_label.AutoSize = True
        Me.Lname_label.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lname_label.Location = New System.Drawing.Point(49, 99)
        Me.Lname_label.Name = "Lname_label"
        Me.Lname_label.Size = New System.Drawing.Size(79, 18)
        Me.Lname_label.TabIndex = 1
        Me.Lname_label.Text = "Last Name :"
        '
        'F_name
        '
        Me.F_name.Location = New System.Drawing.Point(129, 124)
        Me.F_name.Name = "F_name"
        Me.F_name.Size = New System.Drawing.Size(165, 20)
        Me.F_name.TabIndex = 2
        '
        'Fname_label
        '
        Me.Fname_label.AutoSize = True
        Me.Fname_label.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname_label.Location = New System.Drawing.Point(42, 124)
        Me.Fname_label.Name = "Fname_label"
        Me.Fname_label.Size = New System.Drawing.Size(81, 18)
        Me.Fname_label.TabIndex = 3
        Me.Fname_label.Text = "First Name :"
        '
        'Mname_label
        '
        Me.Mname_label.AutoSize = True
        Me.Mname_label.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mname_label.Location = New System.Drawing.Point(33, 151)
        Me.Mname_label.Name = "Mname_label"
        Me.Mname_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Mname_label.Size = New System.Drawing.Size(95, 18)
        Me.Mname_label.TabIndex = 4
        Me.Mname_label.Text = "Middle Name :"
        '
        'M_name
        '
        Me.M_name.Location = New System.Drawing.Point(129, 150)
        Me.M_name.Name = "M_name"
        Me.M_name.Size = New System.Drawing.Size(165, 20)
        Me.M_name.TabIndex = 5
        '
        'Ages
        '
        Me.Ages.Location = New System.Drawing.Point(129, 176)
        Me.Ages.Name = "Ages"
        Me.Ages.Size = New System.Drawing.Size(165, 20)
        Me.Ages.TabIndex = 6
        '
        'Age_label
        '
        Me.Age_label.AutoSize = True
        Me.Age_label.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age_label.Location = New System.Drawing.Point(89, 177)
        Me.Age_label.Name = "Age_label"
        Me.Age_label.Size = New System.Drawing.Size(37, 18)
        Me.Age_label.TabIndex = 7
        Me.Age_label.Text = "Age :"
        '
        'Bday
        '
        Me.Bday.Location = New System.Drawing.Point(129, 202)
        Me.Bday.Name = "Bday"
        Me.Bday.Size = New System.Drawing.Size(165, 20)
        Me.Bday.TabIndex = 8
        '
        'Bday_label
        '
        Me.Bday_label.AutoSize = True
        Me.Bday_label.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bday_label.Location = New System.Drawing.Point(58, 202)
        Me.Bday_label.Name = "Bday_label"
        Me.Bday_label.Size = New System.Drawing.Size(68, 18)
        Me.Bday_label.TabIndex = 9
        Me.Bday_label.Text = "Birthday :"
        '
        'Home
        '
        Me.Home.Location = New System.Drawing.Point(129, 228)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(165, 20)
        Me.Home.TabIndex = 10
        '
        'home_label
        '
        Me.home_label.AutoSize = True
        Me.home_label.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_label.Location = New System.Drawing.Point(59, 230)
        Me.home_label.Name = "home_label"
        Me.home_label.Size = New System.Drawing.Size(64, 18)
        Me.home_label.TabIndex = 11
        Me.home_label.Text = "Address :"
        '
        'G_level
        '
        Me.G_level.Location = New System.Drawing.Point(129, 254)
        Me.G_level.Name = "G_level"
        Me.G_level.Size = New System.Drawing.Size(165, 20)
        Me.G_level.TabIndex = 12
        '
        'Glevel_label
        '
        Me.Glevel_label.AutoSize = True
        Me.Glevel_label.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Glevel_label.Location = New System.Drawing.Point(42, 254)
        Me.Glevel_label.Name = "Glevel_label"
        Me.Glevel_label.Size = New System.Drawing.Size(86, 18)
        Me.Glevel_label.TabIndex = 13
        Me.Glevel_label.Text = "Grade Level :"
        '
        'U_case
        '
        Me.U_case.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_case.Location = New System.Drawing.Point(563, 287)
        Me.U_case.Name = "U_case"
        Me.U_case.Size = New System.Drawing.Size(75, 23)
        Me.U_case.TabIndex = 14
        Me.U_case.Text = "Upper Case"
        Me.U_case.UseVisualStyleBackColor = True
        '
        'L_case
        '
        Me.L_case.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_case.Location = New System.Drawing.Point(563, 316)
        Me.L_case.Name = "L_case"
        Me.L_case.Size = New System.Drawing.Size(75, 23)
        Me.L_case.TabIndex = 15
        Me.L_case.Text = "Lower Case"
        Me.L_case.UseVisualStyleBackColor = True
        '
        'Hide_all
        '
        Me.Hide_all.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hide_all.Location = New System.Drawing.Point(347, 287)
        Me.Hide_all.Name = "Hide_all"
        Me.Hide_all.Size = New System.Drawing.Size(75, 23)
        Me.Hide_all.TabIndex = 16
        Me.Hide_all.Text = "Hide"
        Me.Hide_all.UseVisualStyleBackColor = True
        '
        'Show_all
        '
        Me.Show_all.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_all.Location = New System.Drawing.Point(347, 316)
        Me.Show_all.Name = "Show_all"
        Me.Show_all.Size = New System.Drawing.Size(75, 23)
        Me.Show_all.TabIndex = 17
        Me.Show_all.Text = "Show"
        Me.Show_all.UseVisualStyleBackColor = True
        '
        'Message
        '
        Me.Message.Location = New System.Drawing.Point(347, 98)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(287, 176)
        Me.Message.TabIndex = 18
        Me.Message.Text = ""
        '
        'Red_BG
        '
        Me.Red_BG.BackColor = System.Drawing.Color.Red
        Me.Red_BG.ForeColor = System.Drawing.Color.Wheat
        Me.Red_BG.Location = New System.Drawing.Point(409, 69)
        Me.Red_BG.Name = "Red_BG"
        Me.Red_BG.Size = New System.Drawing.Size(25, 23)
        Me.Red_BG.TabIndex = 19
        Me.Red_BG.UseVisualStyleBackColor = False
        '
        'Blue_BG
        '
        Me.Blue_BG.BackColor = System.Drawing.Color.Blue
        Me.Blue_BG.Location = New System.Drawing.Point(454, 69)
        Me.Blue_BG.Name = "Blue_BG"
        Me.Blue_BG.Size = New System.Drawing.Size(25, 23)
        Me.Blue_BG.TabIndex = 20
        Me.Blue_BG.UseVisualStyleBackColor = False
        '
        'Green_BG
        '
        Me.Green_BG.BackColor = System.Drawing.Color.Lime
        Me.Green_BG.Location = New System.Drawing.Point(501, 69)
        Me.Green_BG.Name = "Green_BG"
        Me.Green_BG.Size = New System.Drawing.Size(25, 23)
        Me.Green_BG.TabIndex = 21
        Me.Green_BG.UseVisualStyleBackColor = False
        '
        'White_BG
        '
        Me.White_BG.BackColor = System.Drawing.Color.White
        Me.White_BG.Location = New System.Drawing.Point(545, 69)
        Me.White_BG.Name = "White_BG"
        Me.White_BG.Size = New System.Drawing.Size(25, 23)
        Me.White_BG.TabIndex = 22
        Me.White_BG.UseVisualStyleBackColor = False
        '
        'Generate
        '
        Me.Generate.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Generate.Location = New System.Drawing.Point(431, 280)
        Me.Generate.Name = "Generate"
        Me.Generate.Size = New System.Drawing.Size(116, 36)
        Me.Generate.TabIndex = 23
        Me.Generate.Text = "Generate Output"
        Me.Generate.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title.Font = New System.Drawing.Font("Palatino Linotype", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Title.Location = New System.Drawing.Point(264, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(244, 50)
        Me.Title.TabIndex = 25
        Me.Title.Text = "Student Form"
        '
        'txtFsize
        '
        Me.txtFsize.Location = New System.Drawing.Point(640, 97)
        Me.txtFsize.Name = "txtFsize"
        Me.txtFsize.Size = New System.Drawing.Size(35, 20)
        Me.txtFsize.TabIndex = 26
        '
        'Fsizes
        '
        Me.Fsizes.AutoSize = True
        Me.Fsizes.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fsizes.Location = New System.Drawing.Point(681, 97)
        Me.Fsizes.Name = "Fsizes"
        Me.Fsizes.Size = New System.Drawing.Size(68, 18)
        Me.Fsizes.TabIndex = 27
        Me.Fsizes.Text = ": Font Size"
        '
        'GotoGeo
        '
        Me.GotoGeo.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GotoGeo.Location = New System.Drawing.Point(643, 360)
        Me.GotoGeo.Name = "GotoGeo"
        Me.GotoGeo.Size = New System.Drawing.Size(146, 59)
        Me.GotoGeo.TabIndex = 28
        Me.GotoGeo.Text = "Go to Geometry Class"
        Me.GotoGeo.UseVisualStyleBackColor = True
        '
        'Enabling
        '
        Me.Enabling.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enabling.Location = New System.Drawing.Point(578, 396)
        Me.Enabling.Name = "Enabling"
        Me.Enabling.Size = New System.Drawing.Size(56, 23)
        Me.Enabling.TabIndex = 29
        Me.Enabling.Text = "Enable"
        Me.Enabling.UseVisualStyleBackColor = True
        '
        'Disabling
        '
        Me.Disabling.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Disabling.Location = New System.Drawing.Point(578, 362)
        Me.Disabling.Name = "Disabling"
        Me.Disabling.Size = New System.Drawing.Size(56, 26)
        Me.Disabling.TabIndex = 30
        Me.Disabling.Text = "Disable"
        Me.Disabling.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 431)
        Me.Controls.Add(Me.Disabling)
        Me.Controls.Add(Me.Enabling)
        Me.Controls.Add(Me.GotoGeo)
        Me.Controls.Add(Me.Fsizes)
        Me.Controls.Add(Me.txtFsize)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Generate)
        Me.Controls.Add(Me.White_BG)
        Me.Controls.Add(Me.Green_BG)
        Me.Controls.Add(Me.Blue_BG)
        Me.Controls.Add(Me.Red_BG)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.Show_all)
        Me.Controls.Add(Me.Hide_all)
        Me.Controls.Add(Me.L_case)
        Me.Controls.Add(Me.U_case)
        Me.Controls.Add(Me.Glevel_label)
        Me.Controls.Add(Me.G_level)
        Me.Controls.Add(Me.home_label)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.Bday_label)
        Me.Controls.Add(Me.Bday)
        Me.Controls.Add(Me.Age_label)
        Me.Controls.Add(Me.Ages)
        Me.Controls.Add(Me.M_name)
        Me.Controls.Add(Me.Mname_label)
        Me.Controls.Add(Me.Fname_label)
        Me.Controls.Add(Me.F_name)
        Me.Controls.Add(Me.Lname_label)
        Me.Controls.Add(Me.L_name)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_name As TextBox
    Friend WithEvents Lname_label As Label
    Friend WithEvents F_name As TextBox
    Friend WithEvents Fname_label As Label
    Friend WithEvents Mname_label As Label
    Friend WithEvents M_name As TextBox
    Friend WithEvents Ages As TextBox
    Friend WithEvents Age_label As Label
    Friend WithEvents Bday As TextBox
    Friend WithEvents Bday_label As Label
    Friend WithEvents Home As TextBox
    Friend WithEvents home_label As Label
    Friend WithEvents G_level As TextBox
    Friend WithEvents Glevel_label As Label

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Ages.TextChanged

    End Sub

    Friend WithEvents U_case As Button

    Private Sub U_case_Click(sender As Object, e As EventArgs) Handles U_case.Click
        Message.Text = Message.Text.ToUpper()
    End Sub

    Friend WithEvents L_case As Button

    Private Sub Low_case_Click(sender As Object, e As EventArgs) Handles L_case.Click
        Message.Text = Message.Text.ToLower()

    End Sub

    Friend WithEvents Hide_all As Button

    Private Sub Hide_all_Click(sender As Object, e As EventArgs) Handles Hide_all.Click
        Enabling.Visible = False
        Disabling.Visible = False
        GotoGeo.Visible = False
        Title.Visible = False
        Fsizes.Visible = False
        txtFsize.Visible = False
        Blue_BG.Visible = False
        White_BG.Visible = False
        Green_BG.Visible = False
        Red_BG.Visible = False
        Generate.Visible = False
        Message.Visible = False
        U_case.Visible = False
        L_case.Visible = False
        Lname_label.Visible = False
        Fname_label.Visible = False
        Mname_label.Visible = False
        Age_label.Visible = False
        Bday_label.Visible = False
        home_label.Visible = False
        Glevel_label.Visible = False
        L_name.Visible = False
        F_name.Visible = False
        M_name.Visible = False
        Ages.Visible = False
        Bday.Visible = False
        Home.Visible = False
        G_level.Visible = False
    End Sub

    Friend WithEvents Show_all As Button

    Private Sub Show_all_Click(sender As Object, e As EventArgs) Handles Show_all.Click
        Enabling.Visible = True
        Disabling.Visible = True
        GotoGeo.Visible = True
        Title.Visible = True
        Fsizes.Visible = True
        txtFsize.Visible = True
        Blue_BG.Visible = True
        White_BG.Visible = True
        Green_BG.Visible = True
        Red_BG.Visible = True
        Generate.Visible = True
        Message.Visible = True
        U_case.Visible = True
        L_case.Visible = True
        Lname_label.Visible = True
        Fname_label.Visible = True
        Mname_label.Visible = True
        Age_label.Visible = True
        Bday_label.Visible = True
        home_label.Visible = True
        Glevel_label.Visible = True
        L_name.Visible = True
        F_name.Visible = True
        M_name.Visible = True
        Ages.Visible = True
        Bday.Visible = True
        Home.Visible = True
        G_level.Visible = True
    End Sub

    Friend WithEvents Message As RichTextBox
    Friend WithEvents Red_BG As Button
    Friend WithEvents Blue_BG As Button
    Friend WithEvents Green_BG As Button
    Friend WithEvents White_BG As Button
    Friend WithEvents Generate As Button

    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles Generate.Click

        Message.Text = L_name.Text + "," + F_name.Text + " " + M_name.Text + "," + Ages.Text + " " + Bday.Text + " " + Home.Text + " " + G_level.Text

        Dim fsize As Integer
        Integer.TryParse(txtFsize.Text, fsize)

        Message.Font = New Font(Message.Font.Name, fsize, Message.Font.Style, Message.Font.Unit)
    End Sub

    Private Sub Message_TextChanged(sender As Object, e As EventArgs) Handles Message.TextChanged
    End Sub

    Private Sub Red_BG_Click(sender As Object, e As EventArgs) Handles Red_BG.Click
        Message.BackColor = Color.Red
    End Sub

    Private Sub Blue_BG_Click(sender As Object, e As EventArgs) Handles Blue_BG.Click
        Message.BackColor = Color.Blue
    End Sub

    Private Sub Green_BG_Click(sender As Object, e As EventArgs) Handles Green_BG.Click
        Message.BackColor = Color.Green
    End Sub

    Private Sub White_BG_Click(sender As Object, e As EventArgs) Handles White_BG.Click
        Message.BackColor = Color.White
    End Sub

    Private Sub FontSize_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents txtFsize As TextBox

    Private Sub txtfsize_TextChanged(sender As Object, e As EventArgs) Handles txtFsize.TextChanged

    End Sub

    Friend WithEvents Fsizes As Label
    Friend WithEvents GotoGeo As Button
    Friend WithEvents Enabling As Button
    Friend WithEvents Disabling As Button

    Private Sub Enabling_Click(sender As Object, e As EventArgs) Handles Enabling.Click
        GotoGeo.Enabled = True
    End Sub

    Private Sub Disabling_Click(sender As Object, e As EventArgs) Handles Disabling.Click
        GotoGeo.Enabled = False
    End Sub

    Private Sub GotoGeo_Click(sender As Object, e As EventArgs) Handles GotoGeo.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
