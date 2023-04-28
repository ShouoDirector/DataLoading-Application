<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.ExportCsvButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BackupCsvButton = New System.Windows.Forms.Button()
        Me.DeleteCsvButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClearGridButton = New System.Windows.Forms.Button()
        Me.RowTextBox = New System.Windows.Forms.TextBox()
        Me.ColumnTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GoToCellButton = New System.Windows.Forms.Button()
        Me.CurrentCellTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RemoveRowButton = New System.Windows.Forms.Button()
        Me.RemoveColumnButton = New System.Windows.Forms.Button()
        Me.NewFileButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExportCsvButton
        '
        Me.ExportCsvButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ExportCsvButton.FlatAppearance.BorderSize = 0
        Me.ExportCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportCsvButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportCsvButton.ForeColor = System.Drawing.Color.White
        Me.ExportCsvButton.Location = New System.Drawing.Point(815, 160)
        Me.ExportCsvButton.Name = "ExportCsvButton"
        Me.ExportCsvButton.Size = New System.Drawing.Size(154, 41)
        Me.ExportCsvButton.TabIndex = 0
        Me.ExportCsvButton.Text = "IMPORT CSV "
        Me.ExportCsvButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExportCsvButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(54, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(713, 254)
        Me.DataGridView1.TabIndex = 1
        '
        'BackupCsvButton
        '
        Me.BackupCsvButton.BackColor = System.Drawing.Color.Green
        Me.BackupCsvButton.FlatAppearance.BorderSize = 0
        Me.BackupCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackupCsvButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupCsvButton.ForeColor = System.Drawing.Color.White
        Me.BackupCsvButton.Location = New System.Drawing.Point(815, 207)
        Me.BackupCsvButton.Name = "BackupCsvButton"
        Me.BackupCsvButton.Size = New System.Drawing.Size(154, 41)
        Me.BackupCsvButton.TabIndex = 2
        Me.BackupCsvButton.Text = "EXPORT CSV "
        Me.BackupCsvButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BackupCsvButton.UseVisualStyleBackColor = False
        '
        'DeleteCsvButton
        '
        Me.DeleteCsvButton.BackColor = System.Drawing.Color.Red
        Me.DeleteCsvButton.FlatAppearance.BorderSize = 0
        Me.DeleteCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteCsvButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteCsvButton.ForeColor = System.Drawing.Color.White
        Me.DeleteCsvButton.Location = New System.Drawing.Point(815, 254)
        Me.DeleteCsvButton.Name = "DeleteCsvButton"
        Me.DeleteCsvButton.Size = New System.Drawing.Size(154, 41)
        Me.DeleteCsvButton.TabIndex = 3
        Me.DeleteCsvButton.Text = "DELETE CSV "
        Me.DeleteCsvButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteCsvButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(54, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(713, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Data Grid View"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ClearGridButton
        '
        Me.ClearGridButton.BackColor = System.Drawing.Color.Purple
        Me.ClearGridButton.FlatAppearance.BorderSize = 0
        Me.ClearGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearGridButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearGridButton.ForeColor = System.Drawing.Color.White
        Me.ClearGridButton.Location = New System.Drawing.Point(815, 301)
        Me.ClearGridButton.Name = "ClearGridButton"
        Me.ClearGridButton.Size = New System.Drawing.Size(154, 41)
        Me.ClearGridButton.TabIndex = 5
        Me.ClearGridButton.Text = "CLEAR "
        Me.ClearGridButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClearGridButton.UseVisualStyleBackColor = False
        '
        'RowTextBox
        '
        Me.RowTextBox.BackColor = System.Drawing.Color.Black
        Me.RowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RowTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowTextBox.ForeColor = System.Drawing.Color.White
        Me.RowTextBox.Location = New System.Drawing.Point(300, 352)
        Me.RowTextBox.Name = "RowTextBox"
        Me.RowTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RowTextBox.Size = New System.Drawing.Size(67, 27)
        Me.RowTextBox.TabIndex = 6
        '
        'ColumnTextBox
        '
        Me.ColumnTextBox.BackColor = System.Drawing.Color.Black
        Me.ColumnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColumnTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColumnTextBox.ForeColor = System.Drawing.Color.White
        Me.ColumnTextBox.Location = New System.Drawing.Point(129, 353)
        Me.ColumnTextBox.Name = "ColumnTextBox"
        Me.ColumnTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ColumnTextBox.Size = New System.Drawing.Size(52, 27)
        Me.ColumnTextBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Column"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(252, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Row"
        '
        'GoToCellButton
        '
        Me.GoToCellButton.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.GoToCellButton.FlatAppearance.BorderSize = 0
        Me.GoToCellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToCellButton.ForeColor = System.Drawing.Color.White
        Me.GoToCellButton.Location = New System.Drawing.Point(635, 357)
        Me.GoToCellButton.Name = "GoToCellButton"
        Me.GoToCellButton.Size = New System.Drawing.Size(132, 32)
        Me.GoToCellButton.TabIndex = 11
        Me.GoToCellButton.Text = "GO TO CELL"
        Me.GoToCellButton.UseVisualStyleBackColor = False
        '
        'CurrentCellTextBox
        '
        Me.CurrentCellTextBox.BackColor = System.Drawing.Color.Black
        Me.CurrentCellTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrentCellTextBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentCellTextBox.ForeColor = System.Drawing.Color.White
        Me.CurrentCellTextBox.Location = New System.Drawing.Point(187, 416)
        Me.CurrentCellTextBox.Name = "CurrentCellTextBox"
        Me.CurrentCellTextBox.ReadOnly = True
        Me.CurrentCellTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CurrentCellTextBox.Size = New System.Drawing.Size(192, 23)
        Me.CurrentCellTextBox.TabIndex = 12
        Me.CurrentCellTextBox.Text = "Data First!"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(104, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 2)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(290, 380)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 2)
        Me.Button3.TabIndex = 14
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(67, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Focused Cell :"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.DataLoadingAndConversion.My.Resources.Resources.Screenshot_2023_03_28_215013
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(730, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 189)
        Me.Panel1.TabIndex = 16
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(439, 360)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(158, 20)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Tag = ""
        Me.RadioButton1.Text = "Zero-Based Indeces?"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RemoveRowButton
        '
        Me.RemoveRowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RemoveRowButton.FlatAppearance.BorderSize = 0
        Me.RemoveRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveRowButton.ForeColor = System.Drawing.Color.White
        Me.RemoveRowButton.Location = New System.Drawing.Point(439, 407)
        Me.RemoveRowButton.Name = "RemoveRowButton"
        Me.RemoveRowButton.Size = New System.Drawing.Size(161, 32)
        Me.RemoveRowButton.TabIndex = 18
        Me.RemoveRowButton.Text = "REMOVE ROW"
        Me.RemoveRowButton.UseVisualStyleBackColor = False
        '
        'RemoveColumnButton
        '
        Me.RemoveColumnButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RemoveColumnButton.FlatAppearance.BorderSize = 0
        Me.RemoveColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveColumnButton.ForeColor = System.Drawing.Color.White
        Me.RemoveColumnButton.Location = New System.Drawing.Point(606, 407)
        Me.RemoveColumnButton.Name = "RemoveColumnButton"
        Me.RemoveColumnButton.Size = New System.Drawing.Size(161, 32)
        Me.RemoveColumnButton.TabIndex = 19
        Me.RemoveColumnButton.Text = "REMOVE COLUMN"
        Me.RemoveColumnButton.UseVisualStyleBackColor = False
        '
        'NewFileButton
        '
        Me.NewFileButton.BackColor = System.Drawing.Color.Olive
        Me.NewFileButton.FlatAppearance.BorderSize = 0
        Me.NewFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewFileButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewFileButton.ForeColor = System.Drawing.Color.White
        Me.NewFileButton.Location = New System.Drawing.Point(815, 397)
        Me.NewFileButton.Name = "NewFileButton"
        Me.NewFileButton.Size = New System.Drawing.Size(154, 41)
        Me.NewFileButton.TabIndex = 20
        Me.NewFileButton.Text = "NEW CSV FILE "
        Me.NewFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewFileButton.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1004, 473)
        Me.Controls.Add(Me.NewFileButton)
        Me.Controls.Add(Me.RemoveColumnButton)
        Me.Controls.Add(Me.RemoveRowButton)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CurrentCellTextBox)
        Me.Controls.Add(Me.GoToCellButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ColumnTextBox)
        Me.Controls.Add(Me.RowTextBox)
        Me.Controls.Add(Me.ClearGridButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DeleteCsvButton)
        Me.Controls.Add(Me.BackupCsvButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ExportCsvButton)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "DataLoading"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExportCsvButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackupCsvButton As Button
    Friend WithEvents DeleteCsvButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ClearGridButton As Button
    Friend WithEvents RowTextBox As TextBox
    Friend WithEvents ColumnTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GoToCellButton As Button
    Friend WithEvents CurrentCellTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RemoveRowButton As Button
    Friend WithEvents RemoveColumnButton As Button
    Friend WithEvents NewFileButton As Button
End Class
