Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtMAC01 = New System.Windows.Forms.TextBox()
        Me.txtMAC02 = New System.Windows.Forms.TextBox()
        Me.txtMAC03 = New System.Windows.Forms.TextBox()
        Me.txtMAC04 = New System.Windows.Forms.TextBox()
        Me.txtMAC05 = New System.Windows.Forms.TextBox()
        Me.txtMAC06 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nudSSIDs = New System.Windows.Forms.NumericUpDown()
        Me.grdBSSID = New System.Windows.Forms.DataGridView()
        Me.culNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cul24GHz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cul5GHz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboModel = New System.Windows.Forms.ComboBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.sfdExport = New System.Windows.Forms.SaveFileDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudSSIDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdBSSID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMAC01
        '
        Me.txtMAC01.Location = New System.Drawing.Point(6, 20)
        Me.txtMAC01.MaxLength = 2
        Me.txtMAC01.Name = "txtMAC01"
        Me.txtMAC01.Size = New System.Drawing.Size(31, 21)
        Me.txtMAC01.TabIndex = 0
        '
        'txtMAC02
        '
        Me.txtMAC02.Location = New System.Drawing.Point(46, 20)
        Me.txtMAC02.MaxLength = 2
        Me.txtMAC02.Name = "txtMAC02"
        Me.txtMAC02.Size = New System.Drawing.Size(31, 21)
        Me.txtMAC02.TabIndex = 1
        '
        'txtMAC03
        '
        Me.txtMAC03.Location = New System.Drawing.Point(86, 20)
        Me.txtMAC03.MaxLength = 2
        Me.txtMAC03.Name = "txtMAC03"
        Me.txtMAC03.Size = New System.Drawing.Size(31, 21)
        Me.txtMAC03.TabIndex = 2
        '
        'txtMAC04
        '
        Me.txtMAC04.Location = New System.Drawing.Point(126, 20)
        Me.txtMAC04.MaxLength = 2
        Me.txtMAC04.Name = "txtMAC04"
        Me.txtMAC04.Size = New System.Drawing.Size(31, 21)
        Me.txtMAC04.TabIndex = 3
        '
        'txtMAC05
        '
        Me.txtMAC05.Location = New System.Drawing.Point(166, 20)
        Me.txtMAC05.MaxLength = 2
        Me.txtMAC05.Name = "txtMAC05"
        Me.txtMAC05.Size = New System.Drawing.Size(31, 21)
        Me.txtMAC05.TabIndex = 4
        '
        'txtMAC06
        '
        Me.txtMAC06.Location = New System.Drawing.Point(206, 20)
        Me.txtMAC06.MaxLength = 2
        Me.txtMAC06.Name = "txtMAC06"
        Me.txtMAC06.Size = New System.Drawing.Size(31, 21)
        Me.txtMAC06.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(9, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(9, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(9, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = ":"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMAC01)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMAC02)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMAC03)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMAC04)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMAC05)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMAC06)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 51)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AP MAC"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nudSSIDs)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 53)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Number of SSID"
        '
        'nudSSIDs
        '
        Me.nudSSIDs.Location = New System.Drawing.Point(6, 20)
        Me.nudSSIDs.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudSSIDs.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSSIDs.Name = "nudSSIDs"
        Me.nudSSIDs.Size = New System.Drawing.Size(120, 21)
        Me.nudSSIDs.TabIndex = 7
        Me.nudSSIDs.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grdBSSID
        '
        Me.grdBSSID.AllowUserToAddRows = False
        Me.grdBSSID.AllowUserToDeleteRows = False
        Me.grdBSSID.AllowUserToResizeRows = False
        Me.grdBSSID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdBSSID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBSSID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.culNumber, Me.cul24GHz, Me.cul5GHz})
        Me.grdBSSID.Location = New System.Drawing.Point(264, 12)
        Me.grdBSSID.Name = "grdBSSID"
        Me.grdBSSID.RowTemplate.Height = 23
        Me.grdBSSID.Size = New System.Drawing.Size(386, 383)
        Me.grdBSSID.TabIndex = 15
        '
        'culNumber
        '
        Me.culNumber.HeaderText = "SSID#"
        Me.culNumber.Name = "culNumber"
        Me.culNumber.ReadOnly = True
        Me.culNumber.Width = 63
        '
        'cul24GHz
        '
        Me.cul24GHz.HeaderText = "2.4GHz"
        Me.cul24GHz.Name = "cul24GHz"
        Me.cul24GHz.ReadOnly = True
        Me.cul24GHz.Width = 70
        '
        'cul5GHz
        '
        Me.cul5GHz.HeaderText = "5GHz"
        Me.cul5GHz.Name = "cul5GHz"
        Me.cul5GHz.ReadOnly = True
        Me.cul5GHz.Width = 60
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 185)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(117, 66)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboModel)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 51)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Model"
        '
        'cboModel
        '
        Me.cboModel.FormattingEnabled = True
        Me.cboModel.Items.AddRange(New Object() {"MR12", "MR16", "MR18", "MR24", "MR62", "MR66", "MR26", "MR32", "MR34", "MR72", "MR20", "MR30H", "MR33", "MR42", "MR42E", "MR52", "MR53", "MR53E", "MR70", "MR74", "MR84"})
        Me.cboModel.Location = New System.Drawing.Point(6, 20)
        Me.cboModel.Name = "cboModel"
        Me.cboModel.Size = New System.Drawing.Size(231, 20)
        Me.cboModel.TabIndex = 6
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(12, 257)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(117, 66)
        Me.btnExport.TabIndex = 17
        Me.btnExport.Text = "Export to CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 329)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(246, 66)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(144, 257)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(113, 66)
        Me.btnAbout.TabIndex = 18
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'sfdExport
        '
        Me.sfdExport.Filter = "CSV(*.csv)|*.csv|Text(*.txt)|*.txt|All file|*.*"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(144, 185)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 66)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 406)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grdBSSID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Meraki BSSID Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudSSIDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdBSSID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMAC01 As TextBox
    Friend WithEvents txtMAC02 As TextBox
    Friend WithEvents txtMAC03 As TextBox
    Friend WithEvents txtMAC04 As TextBox
    Friend WithEvents txtMAC05 As TextBox
    Friend WithEvents txtMAC06 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nudSSIDs As NumericUpDown
    Friend WithEvents grdBSSID As DataGridView
    Friend WithEvents btnCalculate As Button

    Private Sub txtMAC01_TextChanged(sender As Object, e As EventArgs) Handles txtMAC01.TextChanged
        If txtMAC01.Text.Length >= 2 Then
            txtMAC02.Focus()
        End If
    End Sub

    Private Sub txtMAC02_TextChanged(sender As Object, e As EventArgs) Handles txtMAC02.TextChanged
        If txtMAC02.Text.Length >= 2 Then
            txtMAC03.Focus()
        End If
    End Sub

    Private Sub txtMAC03_TextChanged(sender As Object, e As EventArgs) Handles txtMAC03.TextChanged
        If txtMAC03.Text.Length >= 2 Then
            txtMAC04.Focus()
        End If
    End Sub

    Private Sub txtMAC04_TextChanged(sender As Object, e As EventArgs) Handles txtMAC04.TextChanged
        If txtMAC04.Text.Length >= 2 Then
            txtMAC05.Focus()
        End If
    End Sub

    Private Sub txtMAC05_TextChanged(sender As Object, e As EventArgs) Handles txtMAC05.TextChanged
        If txtMAC05.Text.Length >= 2 Then
            txtMAC06.Focus()
        End If
    End Sub

    Private Sub txtMAC02_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtMAC02.KeyPress
        If e.KeyChar = ControlChars.Back And txtMAC02.Text.Length <= 1 Then
            txtMAC01.Focus()
        End If
    End Sub

    Private Sub txtMAC03_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtMAC03.KeyPress
        If e.KeyChar = ControlChars.Back And txtMAC03.Text.Length <= 1 Then
            txtMAC02.Focus()
        End If
    End Sub

    Private Sub txtMAC04_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtMAC04.KeyPress
        If e.KeyChar = ControlChars.Back And txtMAC04.Text.Length <= 1 Then
            txtMAC03.Focus()
        End If
    End Sub

    Private Sub txtMAC05_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtMAC05.KeyPress
        If e.KeyChar = ControlChars.Back And txtMAC05.Text.Length <= 1 Then
            txtMAC04.Focus()
        End If
    End Sub

    Private Sub txtMAC06_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtMAC06.KeyPress
        If e.KeyChar = ControlChars.Back And txtMAC06.Text.Length <= 1 Then
            txtMAC05.Focus()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        grdBSSID.Rows.Clear()

        If txtMAC01.Text.Length + txtMAC02.Text.Length + txtMAC03.Text.Length + txtMAC04.Text.Length + txtMAC05.Text.Length + txtMAC06.Text.Length <> 12 Then
            MsgBox("Invalid MAC!", 0, "Error!")
            Exit Sub
        End If

        If cboModel.SelectedItem Is Nothing Then
            MsgBox("Select Model!", 0, "Error!")
            Exit Sub
        End If

        Dim MACOUI(3) As Integer
        Dim Serial(3) As Integer
        Dim BSSIDOUI As String = ""
        Dim BSSIDSerial As String = ""

        Try
            MACOUI(0) = Convert.ToInt32(txtMAC01.Text, 16)
            MACOUI(1) = Convert.ToInt32(txtMAC02.Text, 16)
            MACOUI(2) = Convert.ToInt32(txtMAC03.Text, 16)
            Serial(0) = Convert.ToInt32(txtMAC04.Text, 16)
            Serial(1) = Convert.ToInt32(txtMAC05.Text, 16)
            Serial(2) = Convert.ToInt32(txtMAC06.Text, 16)

            BSSIDOUI = (txtMAC01.Text + ":" + txtMAC02.Text + ":" + txtMAC03.Text).ToUpper
            BSSIDSerial = (txtMAC04.Text + ":" + txtMAC05.Text + ":" + txtMAC06.Text).ToUpper
        Catch
            MsgBox("Invalid MAC!", 0, "Error!")
            Exit Sub
        End Try

        Dim BSSID24(15) As String
        Dim BSSID5(15) As String

        Select Case BSSIDOUI
            Case "00:18:0A"
                For i As Integer = 0 To nudSSIDs.Value - 1
                    If cboModel.SelectedIndex <= 5 Then
                        If i <= 1 Then
                            MACOUI(0) = MACOUI(0) + (&H6 * i)
                        Else
                            MACOUI(0) = MACOUI(0) + &H4
                        End If

                        BSSID24(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + MACOUI(2).ToString("X2") + ":" + BSSIDSerial

                        If i = 0 Then
                            BSSID5(i) = (MACOUI(0) + &H2).ToString("X2") + ":"
                        Else
                            BSSID5(i) = MACOUI(0).ToString("X2") + ":"
                        End If
                        BSSID5(i) = BSSID5(i) + MACOUI(1).ToString("X2") + ":" + (MACOUI(2) + &H10).ToString("X2") + ":" + BSSIDSerial
                    ElseIf cboModel.SelectedIndex >= 6 And cboModel.SelectedIndex <= 9 Then
                        If i = 0 Then
                            MACOUI(0) = MACOUI(0) + &H2
                            MACOUI(2) = MACOUI(2) + &H40
                        Else
                            Serial(2) = Serial(2) + &H1
                            BSSIDSerial = Serial(0).ToString("X2") + ":" + Serial(1).ToString("X2") + ":" + Serial(2).ToString("X2")
                        End If

                        BSSID24(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + MACOUI(2).ToString("X2") + ":" + BSSIDSerial
                        BSSID5(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + (MACOUI(2) + &H10).ToString("X2") + ":" + BSSIDSerial
                    End If

                    grdBSSID.Rows.Add({(i + 1).ToString(), BSSID24(i), BSSID5(i)})
                Next
            Case "88:15:44"
                For i As Integer = 0 To nudSSIDs.Value - 1
                    If cboModel.SelectedIndex <= 5 Then
                        Select Case i + 1
                            Case 2
                                MACOUI(0) = MACOUI(0) + &H6
                            Case 3, 7, 11, 15
                                MACOUI(0) = MACOUI(0) - &HC
                            Case 4, 8, 12, 6, 10, 14
                                MACOUI(0) = MACOUI(0) + &H4
                            Case 5, 9, 13
                                MACOUI(0) = MACOUI(0) + &H14
                        End Select

                        BSSID24(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + MACOUI(2).ToString("X2") + ":" + BSSIDSerial

                        If i = 0 Then
                            BSSID5(i) = (MACOUI(0) + &H2).ToString("X2") + ":"
                        Else
                            BSSID5(i) = MACOUI(0).ToString("X2") + ":"
                        End If
                        BSSID5(i) = BSSID5(i) + MACOUI(1).ToString("X2") + ":" + (MACOUI(2) + &H10).ToString("X2") + ":" + BSSIDSerial
                    ElseIf cboModel.SelectedIndex >= 6 And cboModel.SelectedIndex <= 9 Then
                        If i = 0 Then
                            MACOUI(0) = MACOUI(0) + &H2
                            MACOUI(2) = MACOUI(2) - &H40
                        Else
                            Serial(2) = Serial(2) + &H1
                            BSSIDSerial = Serial(0).ToString("X2") + ":" + Serial(1).ToString("X2") + ":" + Serial(2).ToString("X2")
                        End If

                        BSSID24(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + MACOUI(2).ToString("X2") + ":" + BSSIDSerial
                        BSSID5(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + (MACOUI(2) + &H10).ToString("X2") + ":" + BSSIDSerial
                    ElseIf cboModel.SelectedIndex > 9 Then
                        Select Case i + 1
                            Case 2
                                MACOUI(0) = MACOUI(0) + &H6
                            Case 3, 7, 11, 15
                                MACOUI(0) = MACOUI(0) - &HC
                            Case 4, 8, 12, 6, 10, 14
                                MACOUI(0) = MACOUI(0) + &H4
                            Case 5, 9, 13
                                MACOUI(0) = MACOUI(0) + &H14
                        End Select

                        BSSID24(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + MACOUI(2).ToString("X2") + ":" + BSSIDSerial

                        If i = 0 Then
                            BSSID5(i) = (MACOUI(0) + &H2).ToString("X2") + ":"
                        Else
                            BSSID5(i) = MACOUI(0).ToString("X2") + ":"
                        End If
                        BSSID5(i) = BSSID5(i) + MACOUI(1).ToString("X2") + ":" + (MACOUI(2) + &H10).ToString("X2") + ":" + BSSIDSerial
                    End If

                    grdBSSID.Rows.Add({(i + 1).ToString(), BSSID24(i), BSSID5(i)})
                Next
            Case "E0:55:3D"
                For i As Integer = 0 To nudSSIDs.Value - 1
                    If cboModel.SelectedIndex >= 6 And cboModel.SelectedIndex <= 9 Then
                        If i = 0 Then
                            MACOUI(0) = MACOUI(0) + &H2
                            MACOUI(2) = MACOUI(2) + &H40
                        Else
                            Serial(2) = Serial(2) + &H1
                            BSSIDSerial = Serial(0).ToString("X2") + ":" + Serial(1).ToString("X2") + ":" + Serial(2).ToString("X2")
                        End If

                        BSSID24(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + MACOUI(2).ToString("X2") + ":" + BSSIDSerial
                        BSSID5(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + (MACOUI(2) - &H10).ToString("X2") + ":" + BSSIDSerial
                    ElseIf cboModel.SelectedIndex > 9 Then
                        Select Case i + 1
                            Case 2
                                MACOUI(0) = MACOUI(0) + &H6
                            Case 3, 4, 5, 6, 7, 8
                                MACOUI(0) = MACOUI(0) + &H4
                            Case 9
                                MACOUI(0) = MACOUI(0) - &H3C
                            Case 10, 11, 12, 13, 14, 15
                                MACOUI(0) = MACOUI(0) + &H4
                        End Select

                        BSSID24(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + MACOUI(2).ToString("X2") + ":" + BSSIDSerial

                        If i = 0 Then
                            BSSID5(i) = (MACOUI(0) + &H2).ToString("X2") + ":"
                        Else
                            BSSID5(i) = MACOUI(0).ToString("X2") + ":"
                        End If
                        BSSID5(i) = BSSID5(i) + MACOUI(1).ToString("X2") + ":" + (MACOUI(2) - &H10).ToString("X2") + ":" + BSSIDSerial
                    End If

                    grdBSSID.Rows.Add({(i + 1).ToString(), BSSID24(i), BSSID5(i)})
                Next
            Case "0C:8D:DB"
                For i As Integer = 0 To nudSSIDs.Value - 1
                    Select Case i + 1
                        Case 2
                            MACOUI(0) = MACOUI(0) - &H2
                        Case 3, 4, 6, 7, 8, 10, 11, 12, 14, 15
                            MACOUI(0) = MACOUI(0) - &H4
                        Case 5, 9, 13
                            MACOUI(0) = MACOUI(0) + &H1C
                    End Select

                    BSSID24(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + MACOUI(2).ToString("X2") + ":" + BSSIDSerial

                    If i = 0 Then
                        BSSID5(i) = (MACOUI(0) + &H2).ToString("X2") + ":"
                    Else
                        BSSID5(i) = MACOUI(0).ToString("X2") + ":"
                    End If
                    BSSID5(i) = BSSID5(i) + MACOUI(1).ToString("X2") + ":" + (MACOUI(2) - &H10).ToString("X2") + ":" + BSSIDSerial

                    grdBSSID.Rows.Add({(i + 1).ToString(), BSSID24(i), BSSID5(i)})
                Next
            Case "E0:CB:BC"
                For i As Integer = 0 To nudSSIDs.Value - 1
                    Select Case i + 1
                        Case 2
                            MACOUI(0) = MACOUI(0) + &H6
                        Case 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15
                            MACOUI(0) = MACOUI(0) + &H4
                        Case 9
                            MACOUI(0) = MACOUI(0) - &H3C
                    End Select

                    BSSID24(i) = MACOUI(0).ToString("X2") + ":" + MACOUI(1).ToString("X2") + ":" + MACOUI(2).ToString("X2") + ":" + BSSIDSerial

                    If i = 0 Then
                        BSSID5(i) = (MACOUI(0) + &H2).ToString("X2") + ":"
                    Else
                        BSSID5(i) = MACOUI(0).ToString("X2") + ":"
                    End If
                    BSSID5(i) = BSSID5(i) + MACOUI(1).ToString("X2") + ":" + (MACOUI(2) - &H10).ToString("X2") + ":" + BSSIDSerial

                    grdBSSID.Rows.Add({(i + 1).ToString(), BSSID24(i), BSSID5(i)})
                Next
        End Select


    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboModel As ComboBox
    Friend WithEvents culNumber As DataGridViewTextBoxColumn
    Friend WithEvents cul24GHz As DataGridViewTextBoxColumn
    Friend WithEvents cul5GHz As DataGridViewTextBoxColumn
    Friend WithEvents btnExport As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAbout As Button

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MsgBox("Meraki BSSID Calculator v0.1" + vbCrLf + "2018.11.16" + vbCrLf + "kamome74@outlook.com", 0, "About")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        sfdExport.ShowDialog()
        Dim f As StreamWriter

        If (File.Exists(sfdExport.FileName) And sfdExport.OverwritePrompt) Then
            f = My.Computer.FileSystem.OpenTextFileWriter(sfdExport.FileName, False)
        Else
            f = My.Computer.FileSystem.OpenTextFileWriter(sfdExport.FileName, True)
        End If

        For Each item As DataGridViewRow In grdBSSID.Rows
            f.WriteLine(item.Cells(0).Value + ", " + item.Cells(1).Value + ", " + item.Cells(2).Value)
        Next

        f.Close()
    End Sub

    Friend WithEvents sfdExport As SaveFileDialog
    Friend WithEvents btnClear As Button

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMAC01.Text = ""
        txtMAC02.Text = ""
        txtMAC03.Text = ""
        txtMAC04.Text = ""
        txtMAC05.Text = ""
        txtMAC06.Text = ""

        nudSSIDs.Value = 1

        cboModel.SelectedItem = Nothing

        txtMAC01.Focus()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call btnClear_Click(sender, e)
    End Sub
End Class
