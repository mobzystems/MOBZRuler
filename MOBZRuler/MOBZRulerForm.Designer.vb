<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOBZRulerForm
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MOBZRulerForm))
    Me.mainMenu = New System.Windows.Forms.MenuStrip
    Me.MenuView = New System.Windows.Forms.ToolStripMenuItem
    Me.menuItemSmallGrid = New System.Windows.Forms.ToolStripMenuItem
    Me.menuItemLargeGrid = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.menuItem640x480 = New System.Windows.Forms.ToolStripMenuItem
    Me.menuItem800x600 = New System.Windows.Forms.ToolStripMenuItem
    Me.menuItem1024x768 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
    Me.menuItemStatusBar = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.menuItemExit = New System.Windows.Forms.ToolStripMenuItem
    Me.mainStatusStrip = New System.Windows.Forms.StatusStrip
    Me.mainStatusStripLabelLink = New System.Windows.Forms.ToolStripStatusLabel
    Me.FontLabel = New System.Windows.Forms.Label
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuItemAlwaysOnTop = New System.Windows.Forms.ToolStripMenuItem
    Me.ViewPictureBox = New MOBZRuler.TransparentPictureBox
    Me.mainMenu.SuspendLayout()
    Me.mainStatusStrip.SuspendLayout()
    CType(Me.ViewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'mainMenu
    '
    Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuView})
    Me.mainMenu.Location = New System.Drawing.Point(0, 0)
    Me.mainMenu.Name = "mainMenu"
    Me.mainMenu.Size = New System.Drawing.Size(670, 24)
    Me.mainMenu.TabIndex = 0
    Me.mainMenu.Text = "MenuStrip1"
    '
    'MenuView
    '
    Me.MenuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemSmallGrid, Me.menuItemLargeGrid, Me.ToolStripSeparator1, Me.menuItem640x480, Me.menuItem800x600, Me.menuItem1024x768, Me.ToolStripMenuItem4, Me.MenuItemAlwaysOnTop, Me.ToolStripSeparator3, Me.menuItemStatusBar, Me.ToolStripSeparator2, Me.menuItemExit})
    Me.MenuView.Name = "MenuView"
    Me.MenuView.Size = New System.Drawing.Size(44, 20)
    Me.MenuView.Text = "&View"
    '
    'menuItemSmallGrid
    '
    Me.menuItemSmallGrid.CheckOnClick = True
    Me.menuItemSmallGrid.Name = "menuItemSmallGrid"
    Me.menuItemSmallGrid.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
    Me.menuItemSmallGrid.Size = New System.Drawing.Size(194, 22)
    Me.menuItemSmallGrid.Text = "&Small Grid"
    '
    'menuItemLargeGrid
    '
    Me.menuItemLargeGrid.Checked = True
    Me.menuItemLargeGrid.CheckOnClick = True
    Me.menuItemLargeGrid.CheckState = System.Windows.Forms.CheckState.Checked
    Me.menuItemLargeGrid.Name = "menuItemLargeGrid"
    Me.menuItemLargeGrid.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
    Me.menuItemLargeGrid.Size = New System.Drawing.Size(194, 22)
    Me.menuItemLargeGrid.Text = "&Large grid"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
    '
    'menuItem640x480
    '
    Me.menuItem640x480.CheckOnClick = True
    Me.menuItem640x480.Name = "menuItem640x480"
    Me.menuItem640x480.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
    Me.menuItem640x480.Size = New System.Drawing.Size(194, 22)
    Me.menuItem640x480.Text = "&1 640 x 480"
    '
    'menuItem800x600
    '
    Me.menuItem800x600.Checked = True
    Me.menuItem800x600.CheckOnClick = True
    Me.menuItem800x600.CheckState = System.Windows.Forms.CheckState.Checked
    Me.menuItem800x600.Name = "menuItem800x600"
    Me.menuItem800x600.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
    Me.menuItem800x600.Size = New System.Drawing.Size(194, 22)
    Me.menuItem800x600.Text = "&2 &800 x 600"
    '
    'menuItem1024x768
    '
    Me.menuItem1024x768.Checked = True
    Me.menuItem1024x768.CheckOnClick = True
    Me.menuItem1024x768.CheckState = System.Windows.Forms.CheckState.Checked
    Me.menuItem1024x768.Name = "menuItem1024x768"
    Me.menuItem1024x768.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
    Me.menuItem1024x768.Size = New System.Drawing.Size(194, 22)
    Me.menuItem1024x768.Text = "&3 1024 x 768"
    '
    'ToolStripMenuItem4
    '
    Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
    Me.ToolStripMenuItem4.Size = New System.Drawing.Size(191, 6)
    '
    'menuItemStatusBar
    '
    Me.menuItemStatusBar.Checked = True
    Me.menuItemStatusBar.CheckOnClick = True
    Me.menuItemStatusBar.CheckState = System.Windows.Forms.CheckState.Checked
    Me.menuItemStatusBar.Name = "menuItemStatusBar"
    Me.menuItemStatusBar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
    Me.menuItemStatusBar.Size = New System.Drawing.Size(194, 22)
    Me.menuItemStatusBar.Text = "&Status Bar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(191, 6)
    '
    'menuItemExit
    '
    Me.menuItemExit.Name = "menuItemExit"
    Me.menuItemExit.Size = New System.Drawing.Size(194, 22)
    Me.menuItemExit.Text = "E&xit"
    '
    'mainStatusStrip
    '
    Me.mainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainStatusStripLabelLink})
    Me.mainStatusStrip.Location = New System.Drawing.Point(0, 361)
    Me.mainStatusStrip.Name = "mainStatusStrip"
    Me.mainStatusStrip.Size = New System.Drawing.Size(670, 22)
    Me.mainStatusStrip.TabIndex = 1
    Me.mainStatusStrip.Text = "StatusStrip1"
    '
    'mainStatusStripLabelLink
    '
    Me.mainStatusStripLabelLink.IsLink = True
    Me.mainStatusStripLabelLink.Name = "mainStatusStripLabelLink"
    Me.mainStatusStripLabelLink.Size = New System.Drawing.Size(174, 17)
    Me.mainStatusStripLabelLink.Text = "MOBZRuler v# by MOBZystems"
    '
    'FontLabel
    '
    Me.FontLabel.AutoSize = True
    Me.FontLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FontLabel.Location = New System.Drawing.Point(425, 199)
    Me.FontLabel.Name = "FontLabel"
    Me.FontLabel.Size = New System.Drawing.Size(164, 13)
    Me.FontLabel.TabIndex = 3
    Me.FontLabel.Text = "This label defines the font to use"
    Me.FontLabel.Visible = False
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(191, 6)
    '
    'MenuItemAlwaysOnTop
    '
    Me.MenuItemAlwaysOnTop.CheckOnClick = True
    Me.MenuItemAlwaysOnTop.Name = "MenuItemAlwaysOnTop"
    Me.MenuItemAlwaysOnTop.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
    Me.MenuItemAlwaysOnTop.Size = New System.Drawing.Size(194, 22)
    Me.MenuItemAlwaysOnTop.Text = "&Always on Top"
    '
    'ViewPictureBox
    '
    Me.ViewPictureBox.BackColor = System.Drawing.Color.Purple
    Me.ViewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ViewPictureBox.Location = New System.Drawing.Point(0, 24)
    Me.ViewPictureBox.Name = "ViewPictureBox"
    Me.ViewPictureBox.Size = New System.Drawing.Size(670, 337)
    Me.ViewPictureBox.TabIndex = 2
    Me.ViewPictureBox.TabStop = False
    '
    'MOBZRulerForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(670, 383)
    Me.Controls.Add(Me.FontLabel)
    Me.Controls.Add(Me.ViewPictureBox)
    Me.Controls.Add(Me.mainStatusStrip)
    Me.Controls.Add(Me.mainMenu)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.mainMenu
    Me.Name = "MOBZRulerForm"
    Me.Text = "MOBZRuler"
    Me.TransparencyKey = System.Drawing.Color.Purple
    Me.mainMenu.ResumeLayout(False)
    Me.mainMenu.PerformLayout()
    Me.mainStatusStrip.ResumeLayout(False)
    Me.mainStatusStrip.PerformLayout()
    CType(Me.ViewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
  Friend WithEvents mainStatusStrip As System.Windows.Forms.StatusStrip
  Friend WithEvents mainStatusStripLabelLink As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents MenuView As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents menuItemSmallGrid As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents menuItemLargeGrid As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents menuItem640x480 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents menuItem800x600 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents menuItem1024x768 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents menuItemStatusBar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents menuItemExit As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ViewPictureBox As TransparentPictureBox
  Friend WithEvents FontLabel As System.Windows.Forms.Label
  Friend WithEvents MenuItemAlwaysOnTop As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
