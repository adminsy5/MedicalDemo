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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCondition = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ComboBoxType = New System.Windows.Forms.ComboBox()
        Me.TextBoxRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCompany = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewReader = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxCondition)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Controls.Add(Me.ButtonDelete)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ComboBoxType)
        Me.GroupBox1.Controls.Add(Me.TextBoxRate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxCompany)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxMid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1070, 552)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mahavir Medical "
        '
        'CheckBoxCondition
        '
        Me.CheckBoxCondition.AutoSize = True
        Me.CheckBoxCondition.Location = New System.Drawing.Point(373, 466)
        Me.CheckBoxCondition.Name = "CheckBoxCondition"
        Me.CheckBoxCondition.Size = New System.Drawing.Size(287, 36)
        Me.CheckBoxCondition.TabIndex = 20
        Me.CheckBoxCondition.Text = "Syrup Rates Below 500"
        Me.CheckBoxCondition.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(723, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 32)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "₹"
        '
        'ButtonClear
        '
        Me.ButtonClear.Image = Global.MedicalDemo.My.Resources.Resources.clear_32
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(467, 387)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(110, 46)
        Me.ButtonClear.TabIndex = 18
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Image = Global.MedicalDemo.My.Resources.Resources.update_32
        Me.ButtonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUpdate.Location = New System.Drawing.Point(197, 456)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(134, 46)
        Me.ButtonUpdate.TabIndex = 17
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Image = Global.MedicalDemo.My.Resources.Resources.refresh_32
        Me.ButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefresh.Location = New System.Drawing.Point(620, 387)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(134, 46)
        Me.ButtonRefresh.TabIndex = 16
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Image = Global.MedicalDemo.My.Resources.Resources.remove_32
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(714, 456)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(125, 46)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Image = Global.MedicalDemo.My.Resources.Resources.save_32
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(306, 387)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(110, 46)
        Me.ButtonSave.TabIndex = 14
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ComboBoxType
        '
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.Items.AddRange(New Object() {"- Choose Item -", "tablet", "capsule", "syrup "})
        Me.ComboBoxType.Location = New System.Drawing.Point(165, 225)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(242, 40)
        Me.ComboBoxType.TabIndex = 12
        '
        'TextBoxRate
        '
        Me.TextBoxRate.Location = New System.Drawing.Point(756, 172)
        Me.TextBoxRate.Name = "TextBoxRate"
        Me.TextBoxRate.Size = New System.Drawing.Size(220, 39)
        Me.TextBoxRate.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(620, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Rate"
        '
        'TextBoxCompany
        '
        Me.TextBoxCompany.Location = New System.Drawing.Point(756, 102)
        Me.TextBoxCompany.Name = "TextBoxCompany"
        Me.TextBoxCompany.Size = New System.Drawing.Size(220, 39)
        Me.TextBoxCompany.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(611, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Company"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(165, 163)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(412, 39)
        Me.TextBoxName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'TextBoxMid
        '
        Me.TextBoxMid.Location = New System.Drawing.Point(165, 102)
        Me.TextBoxMid.Name = "TextBoxMid"
        Me.TextBoxMid.Size = New System.Drawing.Size(231, 39)
        Me.TextBoxMid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mid"
        '
        'DataGridViewReader
        '
        Me.DataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReader.Location = New System.Drawing.Point(63, 628)
        Me.DataGridViewReader.Name = "DataGridViewReader"
        Me.DataGridViewReader.RowHeadersWidth = 82
        Me.DataGridViewReader.RowTemplate.Height = 41
        Me.DataGridViewReader.Size = New System.Drawing.Size(1070, 597)
        Me.DataGridViewReader.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(393, 1253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(397, 32)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "© 2021-2023 Sutex Developers, Inc."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(800, 1297)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(84, 32)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Admin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 1297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(530, 32)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "If you have any questions, please let me know ~"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 1369)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridViewReader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "tblMedicine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewReader As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ComboBoxType As ComboBox
    Friend WithEvents TextBoxRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCompany As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxCondition As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label8 As Label
End Class
