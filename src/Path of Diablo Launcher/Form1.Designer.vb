﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.playBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.skipChk = New System.Windows.Forms.CheckBox()
        Me.aspectChk = New System.Windows.Forms.CheckBox()
        Me.nsChk = New System.Windows.Forms.CheckBox()
        Me.dfxChk = New System.Windows.Forms.CheckBox()
        Me.directcbox = New System.Windows.Forms.CheckBox()
        Me.wChk = New System.Windows.Forms.CheckBox()
        Me.advancedChk = New System.Windows.Forms.CheckBox()
        Me.txtcbox = New System.Windows.Forms.CheckBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.downloadcfg = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lootfilterurl = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LogBox = New System.Windows.Forms.ListBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.filterlibBtn = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playBtn
        '
        Me.playBtn.Enabled = False
        Me.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.playBtn.Location = New System.Drawing.Point(812, 3)
        Me.playBtn.Name = "playBtn"
        Me.playBtn.Size = New System.Drawing.Size(169, 55)
        Me.playBtn.TabIndex = 1
        Me.playBtn.Text = "Checking for Updates"
        Me.playBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(627, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 117)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Launch Flags"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.skipChk, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.aspectChk, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nsChk, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dfxChk, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.directcbox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.wChk, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.advancedChk, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtcbox, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(356, 92)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'skipChk
        '
        Me.skipChk.AutoSize = True
        Me.skipChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxSkipToBnet
        Me.skipChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.skipChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxSkipToBnet", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.skipChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.skipChk.Location = New System.Drawing.Point(181, 3)
        Me.skipChk.Name = "skipChk"
        Me.skipChk.Size = New System.Drawing.Size(78, 17)
        Me.skipChk.TabIndex = 1
        Me.skipChk.Text = "-skiptobnet"
        Me.skipChk.UseVisualStyleBackColor = True
        '
        'aspectChk
        '
        Me.aspectChk.AutoSize = True
        Me.aspectChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxNoFixAspect
        Me.aspectChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxNoFixAspect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.aspectChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.aspectChk.Location = New System.Drawing.Point(3, 49)
        Me.aspectChk.Name = "aspectChk"
        Me.aspectChk.Size = New System.Drawing.Size(83, 17)
        Me.aspectChk.TabIndex = 4
        Me.aspectChk.Text = "-nofixaspect"
        Me.aspectChk.UseVisualStyleBackColor = True
        '
        'nsChk
        '
        Me.nsChk.AutoSize = True
        Me.nsChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxNs
        Me.nsChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxNs", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nsChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.nsChk.Location = New System.Drawing.Point(3, 72)
        Me.nsChk.Name = "nsChk"
        Me.nsChk.Size = New System.Drawing.Size(93, 17)
        Me.nsChk.TabIndex = 2
        Me.nsChk.Text = "-ns (no sound)"
        Me.nsChk.UseVisualStyleBackColor = True
        '
        'dfxChk
        '
        Me.dfxChk.AutoSize = True
        Me.dfxChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkbox3dfx
        Me.dfxChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkbox3dfx", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dfxChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.dfxChk.Location = New System.Drawing.Point(3, 26)
        Me.dfxChk.Name = "dfxChk"
        Me.dfxChk.Size = New System.Drawing.Size(143, 17)
        Me.dfxChk.TabIndex = 3
        Me.dfxChk.Text = "-3dfx (glide wrapper only)"
        Me.dfxChk.UseVisualStyleBackColor = True
        '
        'directcbox
        '
        Me.directcbox.AutoSize = True
        Me.directcbox.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxDirect
        Me.directcbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxDirect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.directcbox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.directcbox.Location = New System.Drawing.Point(181, 26)
        Me.directcbox.Name = "directcbox"
        Me.directcbox.Size = New System.Drawing.Size(55, 17)
        Me.directcbox.TabIndex = 6
        Me.directcbox.Text = "-direct"
        Me.directcbox.UseVisualStyleBackColor = True
        Me.directcbox.Visible = False
        '
        'wChk
        '
        Me.wChk.AutoSize = True
        Me.wChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.wChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.wChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxW", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.wChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.wChk.Location = New System.Drawing.Point(3, 3)
        Me.wChk.Name = "wChk"
        Me.wChk.Size = New System.Drawing.Size(111, 17)
        Me.wChk.TabIndex = 0
        Me.wChk.Text = "-w (window mode)"
        Me.wChk.UseVisualStyleBackColor = True
        '
        'advancedChk
        '
        Me.advancedChk.AutoSize = True
        Me.advancedChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxAdvanced
        Me.advancedChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxAdvanced", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.advancedChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.advancedChk.Location = New System.Drawing.Point(181, 72)
        Me.advancedChk.Name = "advancedChk"
        Me.advancedChk.Size = New System.Drawing.Size(75, 17)
        Me.advancedChk.TabIndex = 8
        Me.advancedChk.Text = "Advanced"
        Me.advancedChk.UseVisualStyleBackColor = True
        '
        'txtcbox
        '
        Me.txtcbox.AutoSize = True
        Me.txtcbox.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxTxt
        Me.txtcbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxTxt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtcbox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtcbox.Location = New System.Drawing.Point(181, 49)
        Me.txtcbox.Name = "txtcbox"
        Me.txtcbox.Size = New System.Drawing.Size(40, 17)
        Me.txtcbox.TabIndex = 7
        Me.txtcbox.Text = "-txt"
        Me.txtcbox.UseVisualStyleBackColor = True
        Me.txtcbox.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 155)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(609, 278)
        Me.WebBrowser1.TabIndex = 9
        Me.WebBrowser1.Url = New System.Uri("https://pathofdiablo.com/p/?getnewsembed", System.UriKind.Absolute)
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Location = New System.Drawing.Point(3, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Donate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.Location = New System.Drawing.Point(149, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Forums"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button3.Location = New System.Drawing.Point(295, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Wiki"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button4.Location = New System.Drawing.Point(587, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Server List"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button5.Location = New System.Drawing.Point(441, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Rules"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'downloadcfg
        '
        Me.downloadcfg.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.downloadcfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.downloadcfg.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.downloadcfg.Location = New System.Drawing.Point(241, 15)
        Me.downloadcfg.Name = "downloadcfg"
        Me.downloadcfg.Size = New System.Drawing.Size(90, 25)
        Me.downloadcfg.TabIndex = 21
        Me.downloadcfg.Text = "Download"
        Me.downloadcfg.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.filterlibBtn)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.lootfilterurl)
        Me.GroupBox5.Controls.Add(Me.downloadcfg)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(627, 278)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(368, 49)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Loot Filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "URL:"
        '
        'lootfilterurl
        '
        Me.lootfilterurl.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lootfilterurl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lootfilterurl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lootfilterurl.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lootfilterurl.Location = New System.Drawing.Point(44, 19)
        Me.lootfilterurl.Name = "lootfilterurl"
        Me.lootfilterurl.Size = New System.Drawing.Size(191, 20)
        Me.lootfilterurl.TabIndex = 22
        Me.lootfilterurl.Text = "http://pathofdiablo.com/item.filter"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LogBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(627, 333)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 100)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Log"
        '
        'LogBox
        '
        Me.LogBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.LogBox.FormattingEnabled = True
        Me.LogBox.HorizontalScrollbar = True
        Me.LogBox.Location = New System.Drawing.Point(6, 16)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.Size = New System.Drawing.Size(356, 78)
        Me.LogBox.TabIndex = 0
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(3, 61)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(978, 23)
        Me.ProgressBar.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.playBtn)
        Me.Panel1.Controls.Add(Me.ProgressBar)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(12, 439)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 87)
        Me.Panel1.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.banner2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(983, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'filterlibBtn
        '
        Me.filterlibBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.filterlibBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filterlibBtn.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.filterlibBtn.Location = New System.Drawing.Point(337, 15)
        Me.filterlibBtn.Name = "filterlibBtn"
        Me.filterlibBtn.Size = New System.Drawing.Size(25, 25)
        Me.filterlibBtn.TabIndex = 24
        Me.filterlibBtn.Text = "+"
        Me.filterlibBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 538)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path of Diablo Launcher"
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents playBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents aspectChk As System.Windows.Forms.CheckBox
    Friend WithEvents dfxChk As System.Windows.Forms.CheckBox
    Friend WithEvents nsChk As System.Windows.Forms.CheckBox
    Friend WithEvents txtChk As System.Windows.Forms.CheckBox
    Friend WithEvents txtcbox As System.Windows.Forms.CheckBox
    Friend WithEvents directcbox As System.Windows.Forms.CheckBox
    Friend WithEvents directChk As System.Windows.Forms.CheckBox
    Friend WithEvents skipChk As System.Windows.Forms.CheckBox
    Friend WithEvents wChk As System.Windows.Forms.CheckBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents downloadcfg As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lootfilterurl As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LogBox As ListBox
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents advancedChk As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents filterlibBtn As Button
End Class
