Public Class MOBZRulerForm
  Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    MyBase.OnLoad(e)

    Dim v As New Version(Application.ProductVersion)
    mainStatusStripLabelLink.Text = mainStatusStripLabelLink.Text.Replace("#", v.Major.ToString() + "." + v.Minor.ToString() + "." + v.Build.ToString())
  End Sub

  Private Sub mainStatusStripLabelLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainStatusStripLabelLink.Click
    Process.Start("http://www.mobzystems.com/tools/MOBZRuler.aspx")
  End Sub

  Private Sub menuItemStatusBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemStatusBar.Click
    mainStatusStrip.Visible = menuItemStatusBar.Checked
  End Sub

  Private Sub menuItem1024x768_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem1024x768.Click
    ViewPictureBox.Invalidate()
  End Sub

  Private Sub menuItem800x600_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem800x600.Click
    ViewPictureBox.Invalidate()
  End Sub

  Private Sub menuItem640x480_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem640x480.Click
    ViewPictureBox.Invalidate()
  End Sub

  Private Sub menuItemSmallGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemSmallGrid.Click
    ViewPictureBox.Invalidate()
  End Sub

  Private Sub menuItemLargeGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemLargeGrid.Click
    ViewPictureBox.Invalidate()
  End Sub

  Private Sub Repaint(ByVal G As Graphics)
    G.Clear(Me.TransparencyKey)
    G.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit

    If menuItemSmallGrid.Checked Then
      DrawGrid(G, 25, Pens.Black, False)
    End If
    If menuItemLargeGrid.Checked Then
      DrawGrid(G, 100, Pens.Red, True)
    End If

    If menuItem640x480.Checked Then
      DrawRect(G, 640, 480, Pens.Blue)
    End If
    If menuItem800x600.Checked Then
      DrawRect(G, 800, 600, Pens.Blue)
    End If
    If menuItem1024x768.Checked Then
      DrawRect(G, 1024, 768, Pens.Blue)
    End If
  End Sub

  Private Sub DrawGrid(ByVal G As Graphics, ByVal Size As Integer, ByVal Pen As Pen, ByVal ShowNumbers As Boolean)
    Dim Height As Integer = ViewPictureBox.Height
    For X As Integer = 0 To ViewPictureBox.Width - 1 Step Size
      G.DrawLine(Pen, X, 0, X, Height - 1)
      If ShowNumbers And X <> 0 Then
        Dim S As String = X.ToString()
        G.DrawString(S, FontLabel.Font, Pen.Brush, X + 2, 1)
      End If
    Next

    Dim Width As Integer = ViewPictureBox.Width
    For Y As Integer = 0 To ViewPictureBox.Height - 1 Step Size
      G.DrawLine(Pen, 0, Y, Width - 1, Y)
      If ShowNumbers And Y <> 0 Then
        Dim S As String = Y.ToString()
        G.DrawString(S, FontLabel.Font, Pen.Brush, 2, Y + 1)
      End If
    Next
  End Sub

  Private Sub DrawRect(ByVal G As Graphics, ByVal Width As Integer, ByVal Height As Integer, ByVal Pen As Pen)
    G.DrawRectangle(Pen, 0, 0, Width, Height)

    Dim S As String = Width.ToString() + "x" + Height.ToString()
    Dim TextSize As SizeF = G.MeasureString(S, FontLabel.Font)
    G.DrawString(S, FontLabel.Font, Pen.Brush, Width - TextSize.Width, Height - TextSize.Height)
  End Sub

  Private Sub ViewPictureBox_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ViewPictureBox.Paint
    Repaint(e.Graphics)
  End Sub

  Private Sub menuItemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemExit.Click
    Close()
  End Sub

  Private Sub MenuItemAlwaysOnTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAlwaysOnTop.Click
    Me.TopMost = MenuItemAlwaysOnTop.Checked
  End Sub
End Class
