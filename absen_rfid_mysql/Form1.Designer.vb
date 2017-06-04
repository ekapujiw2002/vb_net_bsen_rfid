<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPortRFID = New System.IO.Ports.SerialPort(Me.components)
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageAbsen = New System.Windows.Forms.TabPage()
        Me.DataGridViewMain = New System.Windows.Forms.DataGridView()
        Me.LabelSystemStatus = New System.Windows.Forms.Label()
        Me.LabelInfoAbsen = New System.Windows.Forms.Label()
        Me.TabPageMasterData = New System.Windows.Forms.TabPage()
        Me.DataGridViewMasterData = New System.Windows.Forms.DataGridView()
        Me.GroupBoxDataItem = New System.Windows.Forms.GroupBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonDeleteMasterData = New System.Windows.Forms.Button()
        Me.ButtonUpdateMasterData = New System.Windows.Forms.Button()
        Me.ButtonMasterDataInsert = New System.Windows.Forms.Button()
        Me.TextBoxDataNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDATAID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageLaporan = New System.Windows.Forms.TabPage()
        Me.DataGridViewReport = New System.Windows.Forms.DataGridView()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.DateTimePickerReport = New System.Windows.Forms.DateTimePicker()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.TabPageInfo = New System.Windows.Forms.TabPage()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.TabControlMain.SuspendLayout()
        Me.TabPageAbsen.SuspendLayout()
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMasterData.SuspendLayout()
        CType(Me.DataGridViewMasterData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDataItem.SuspendLayout()
        Me.TabPageLaporan.SuspendLayout()
        CType(Me.DataGridViewReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPortRFID
        '
        Me.SerialPortRFID.ReadTimeout = 5000
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageAbsen)
        Me.TabControlMain.Controls.Add(Me.TabPageMasterData)
        Me.TabControlMain.Controls.Add(Me.TabPageLaporan)
        Me.TabControlMain.Controls.Add(Me.TabPageInfo)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlMain.Location = New System.Drawing.Point(0, 0)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(558, 410)
        Me.TabControlMain.TabIndex = 0
        '
        'TabPageAbsen
        '
        Me.TabPageAbsen.Controls.Add(Me.DataGridViewMain)
        Me.TabPageAbsen.Controls.Add(Me.LabelSystemStatus)
        Me.TabPageAbsen.Controls.Add(Me.LabelInfoAbsen)
        Me.TabPageAbsen.Location = New System.Drawing.Point(4, 24)
        Me.TabPageAbsen.Name = "TabPageAbsen"
        Me.TabPageAbsen.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAbsen.Size = New System.Drawing.Size(550, 382)
        Me.TabPageAbsen.TabIndex = 0
        Me.TabPageAbsen.Text = "ABSEN"
        Me.TabPageAbsen.UseVisualStyleBackColor = True
        '
        'DataGridViewMain
        '
        Me.DataGridViewMain.AllowUserToAddRows = False
        Me.DataGridViewMain.AllowUserToDeleteRows = False
        Me.DataGridViewMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMain.Location = New System.Drawing.Point(3, 179)
        Me.DataGridViewMain.Name = "DataGridViewMain"
        Me.DataGridViewMain.ReadOnly = True
        Me.DataGridViewMain.Size = New System.Drawing.Size(544, 154)
        Me.DataGridViewMain.TabIndex = 2
        '
        'LabelSystemStatus
        '
        Me.LabelSystemStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelSystemStatus.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSystemStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelSystemStatus.Location = New System.Drawing.Point(3, 336)
        Me.LabelSystemStatus.Name = "LabelSystemStatus"
        Me.LabelSystemStatus.Size = New System.Drawing.Size(544, 43)
        Me.LabelSystemStatus.TabIndex = 1
        Me.LabelSystemStatus.Text = "00-00-0000 00:00:00"
        Me.LabelSystemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelInfoAbsen
        '
        Me.LabelInfoAbsen.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelInfoAbsen.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoAbsen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelInfoAbsen.Location = New System.Drawing.Point(3, 3)
        Me.LabelInfoAbsen.Name = "LabelInfoAbsen"
        Me.LabelInfoAbsen.Size = New System.Drawing.Size(544, 173)
        Me.LabelInfoAbsen.TabIndex = 0
        Me.LabelInfoAbsen.Text = "READY"
        Me.LabelInfoAbsen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPageMasterData
        '
        Me.TabPageMasterData.Controls.Add(Me.DataGridViewMasterData)
        Me.TabPageMasterData.Controls.Add(Me.GroupBoxDataItem)
        Me.TabPageMasterData.Location = New System.Drawing.Point(4, 24)
        Me.TabPageMasterData.Name = "TabPageMasterData"
        Me.TabPageMasterData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMasterData.Size = New System.Drawing.Size(550, 382)
        Me.TabPageMasterData.TabIndex = 3
        Me.TabPageMasterData.Text = "MASTER DATA"
        Me.TabPageMasterData.UseVisualStyleBackColor = True
        '
        'DataGridViewMasterData
        '
        Me.DataGridViewMasterData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMasterData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMasterData.Location = New System.Drawing.Point(8, 126)
        Me.DataGridViewMasterData.Name = "DataGridViewMasterData"
        Me.DataGridViewMasterData.ReadOnly = True
        Me.DataGridViewMasterData.Size = New System.Drawing.Size(534, 248)
        Me.DataGridViewMasterData.TabIndex = 1
        '
        'GroupBoxDataItem
        '
        Me.GroupBoxDataItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDataItem.Controls.Add(Me.ButtonRefresh)
        Me.GroupBoxDataItem.Controls.Add(Me.ButtonDeleteMasterData)
        Me.GroupBoxDataItem.Controls.Add(Me.ButtonUpdateMasterData)
        Me.GroupBoxDataItem.Controls.Add(Me.ButtonMasterDataInsert)
        Me.GroupBoxDataItem.Controls.Add(Me.TextBoxDataNama)
        Me.GroupBoxDataItem.Controls.Add(Me.Label2)
        Me.GroupBoxDataItem.Controls.Add(Me.TextBoxDATAID)
        Me.GroupBoxDataItem.Controls.Add(Me.Label1)
        Me.GroupBoxDataItem.Location = New System.Drawing.Point(8, 6)
        Me.GroupBoxDataItem.Name = "GroupBoxDataItem"
        Me.GroupBoxDataItem.Size = New System.Drawing.Size(534, 114)
        Me.GroupBoxDataItem.TabIndex = 0
        Me.GroupBoxDataItem.TabStop = False
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(293, 80)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 7
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonDeleteMasterData
        '
        Me.ButtonDeleteMasterData.Enabled = False
        Me.ButtonDeleteMasterData.Location = New System.Drawing.Point(212, 80)
        Me.ButtonDeleteMasterData.Name = "ButtonDeleteMasterData"
        Me.ButtonDeleteMasterData.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDeleteMasterData.TabIndex = 6
        Me.ButtonDeleteMasterData.Text = "Hapus"
        Me.ButtonDeleteMasterData.UseVisualStyleBackColor = True
        '
        'ButtonUpdateMasterData
        '
        Me.ButtonUpdateMasterData.Enabled = False
        Me.ButtonUpdateMasterData.Location = New System.Drawing.Point(131, 80)
        Me.ButtonUpdateMasterData.Name = "ButtonUpdateMasterData"
        Me.ButtonUpdateMasterData.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdateMasterData.TabIndex = 5
        Me.ButtonUpdateMasterData.Text = "Update"
        Me.ButtonUpdateMasterData.UseVisualStyleBackColor = True
        '
        'ButtonMasterDataInsert
        '
        Me.ButtonMasterDataInsert.Enabled = False
        Me.ButtonMasterDataInsert.Location = New System.Drawing.Point(50, 80)
        Me.ButtonMasterDataInsert.Name = "ButtonMasterDataInsert"
        Me.ButtonMasterDataInsert.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMasterDataInsert.TabIndex = 4
        Me.ButtonMasterDataInsert.Text = "Tambah"
        Me.ButtonMasterDataInsert.UseVisualStyleBackColor = True
        '
        'TextBoxDataNama
        '
        Me.TextBoxDataNama.Location = New System.Drawing.Point(50, 51)
        Me.TextBoxDataNama.Name = "TextBoxDataNama"
        Me.TextBoxDataNama.Size = New System.Drawing.Size(478, 23)
        Me.TextBoxDataNama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAMA"
        '
        'TextBoxDATAID
        '
        Me.TextBoxDATAID.Location = New System.Drawing.Point(50, 22)
        Me.TextBoxDATAID.Name = "TextBoxDATAID"
        Me.TextBoxDATAID.ReadOnly = True
        Me.TextBoxDATAID.Size = New System.Drawing.Size(198, 23)
        Me.TextBoxDATAID.TabIndex = 1
        Me.TextBoxDATAID.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'TabPageLaporan
        '
        Me.TabPageLaporan.Controls.Add(Me.DataGridViewReport)
        Me.TabPageLaporan.Controls.Add(Me.WebBrowser1)
        Me.TabPageLaporan.Controls.Add(Me.DateTimePickerReport)
        Me.TabPageLaporan.Controls.Add(Me.ButtonPrint)
        Me.TabPageLaporan.Location = New System.Drawing.Point(4, 24)
        Me.TabPageLaporan.Name = "TabPageLaporan"
        Me.TabPageLaporan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageLaporan.Size = New System.Drawing.Size(550, 382)
        Me.TabPageLaporan.TabIndex = 1
        Me.TabPageLaporan.Text = "LAPORAN"
        Me.TabPageLaporan.UseVisualStyleBackColor = True
        '
        'DataGridViewReport
        '
        Me.DataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReport.Location = New System.Drawing.Point(222, 6)
        Me.DataGridViewReport.Name = "DataGridViewReport"
        Me.DataGridViewReport.Size = New System.Drawing.Size(96, 60)
        Me.DataGridViewReport.TabIndex = 3
        Me.DataGridViewReport.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(8, 35)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(534, 339)
        Me.WebBrowser1.TabIndex = 2
        '
        'DateTimePickerReport
        '
        Me.DateTimePickerReport.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerReport.Location = New System.Drawing.Point(6, 6)
        Me.DateTimePickerReport.Name = "DateTimePickerReport"
        Me.DateTimePickerReport.Size = New System.Drawing.Size(115, 23)
        Me.DateTimePickerReport.TabIndex = 1
        Me.DateTimePickerReport.Value = New Date(2017, 6, 2, 11, 43, 58, 0)
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(127, 6)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrint.TabIndex = 0
        Me.ButtonPrint.Text = "Cetak"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'TabPageInfo
        '
        Me.TabPageInfo.Location = New System.Drawing.Point(4, 24)
        Me.TabPageInfo.Name = "TabPageInfo"
        Me.TabPageInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInfo.Size = New System.Drawing.Size(550, 382)
        Me.TabPageInfo.TabIndex = 2
        Me.TabPageInfo.Text = "INFO"
        Me.TabPageInfo.UseVisualStyleBackColor = True
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 410)
        Me.Controls.Add(Me.TabControlMain)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABSENSI RFID"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageAbsen.ResumeLayout(False)
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMasterData.ResumeLayout(False)
        CType(Me.DataGridViewMasterData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDataItem.ResumeLayout(False)
        Me.GroupBoxDataItem.PerformLayout()
        Me.TabPageLaporan.ResumeLayout(False)
        CType(Me.DataGridViewReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPortRFID As System.IO.Ports.SerialPort
    Friend WithEvents TabControlMain As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAbsen As System.Windows.Forms.TabPage
    Friend WithEvents TabPageLaporan As System.Windows.Forms.TabPage
    Friend WithEvents TabPageInfo As System.Windows.Forms.TabPage
    Friend WithEvents LabelInfoAbsen As System.Windows.Forms.Label
    Friend WithEvents LabelSystemStatus As System.Windows.Forms.Label
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents DataGridViewMain As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePickerReport As System.Windows.Forms.DateTimePicker
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPageMasterData As System.Windows.Forms.TabPage
    Friend WithEvents GroupBoxDataItem As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxDataNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDATAID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonUpdateMasterData As System.Windows.Forms.Button
    Friend WithEvents ButtonMasterDataInsert As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteMasterData As System.Windows.Forms.Button
    Friend WithEvents DataGridViewMasterData As System.Windows.Forms.DataGridView
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents DataGridViewReport As System.Windows.Forms.DataGridView

End Class
