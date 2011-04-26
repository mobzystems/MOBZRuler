'Namespace MOBZRuler
Public Class TransparentPictureBox
  Inherits PictureBox

  Protected Overrides Sub OnCreateControl()
    Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
    Me.SetStyle(ControlStyles.UserPaint, True)
    MyBase.OnCreateControl()
  End Sub
End Class
'End Namespace
