Option Strict On
Option Explicit On
Public Class Form1
    Private m_Backbuffer As Bitmap

    Private m_Points As New List(Of Point)

    Private Sub Form1_Load(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Load

        m_Backbuffer = New Bitmap(picOut.Width, picOut.Height)
    End Sub

    Private Sub picOut_Paint(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.PaintEventArgs) Handles picOut.Paint

        Call e.Graphics.DrawImage(m_Backbuffer, New Point(0, 0))
    End Sub

    Private Sub DrawPolygon(ByVal Polygon As Point(), _
        ByVal Color As Color, _
        ByVal Clear As Boolean, _
        Optional ByVal Size As Integer = 1)

        Using g = Graphics.FromImage(m_Backbuffer), Pen = New Pen(Color, Size)
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            If Clear Then Call g.Clear(Color.White)
            If Polygon.Length >= 2 Then Call g.DrawPolygon(Pen, Polygon)
        End Using

        Call picOut.Invalidate()
    End Sub

    Private Sub picOut_MouseDown(ByVal sender As System.Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) Handles picOut.MouseDown

        Call m_Points.Add(e.Location)

        Call DrawPolygon(m_Points.ToArray(), _
            Color.FromArgb(75, Color.Blue), True)
        lblNumPoints.Text = String.Format("Polygono: {0} Punto(e)", _
            m_Points.Count)
    End Sub

    Private Sub ScanToolStripMenuItem_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles ScanToolStripMenuItem.Click

        Dim Ret = GrahamScan.ConvexHull(m_Points)

        Call DrawPolygon(Ret.ToArray(), Color.Green, False, 2)
        lblNumPoints.Text = String.Format("Cascara Convexa: {0} Punto(e)", Ret.Count)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click

        m_Points = New List(Of Point)

        Call DrawPolygon(m_Points.ToArray(), Nothing, True)
        lblNumPoints.Text = String.Format("Polygono: {0} Punto(e)", m_Points.Count)
    End Sub

    Private Sub lblNumPoints_Click(sender As Object, e As EventArgs) Handles lblNumPoints.Click

    End Sub

    Private Sub picOut_Click(sender As Object, e As EventArgs) Handles picOut.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class
