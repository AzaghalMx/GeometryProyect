<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picOut = New System.Windows.Forms.PictureBox()
        Me.lblNumPoints = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ScanToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.picOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picOut
        '
        Me.picOut.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picOut.Location = New System.Drawing.Point(39, 50)
        Me.picOut.Name = "picOut"
        Me.picOut.Size = New System.Drawing.Size(661, 307)
        Me.picOut.TabIndex = 0
        Me.picOut.TabStop = False
        '
        'lblNumPoints
        '
        Me.lblNumPoints.AutoSize = True
        Me.lblNumPoints.Location = New System.Drawing.Point(48, 379)
        Me.lblNumPoints.Name = "lblNumPoints"
        Me.lblNumPoints.Size = New System.Drawing.Size(221, 13)
        Me.lblNumPoints.TabIndex = 1
        Me.lblNumPoints.Text = "Presiona Sobre el Cuadro Balnco para dibujar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(763, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ScanToolStripMenuItem
        '
        Me.ScanToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ScanToolStripMenuItem.Image = Global.Geometry_Proyect.My.Resources.Resources.ConvexHull_svg
        Me.ScanToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ScanToolStripMenuItem.Name = "ScanToolStripMenuItem"
        Me.ScanToolStripMenuItem.Size = New System.Drawing.Size(23, 22)
        Me.ScanToolStripMenuItem.Text = "ToolStripButton1"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearToolStripMenuItem.Image = Global.Geometry_Proyect.My.Resources.Resources.TrashIcon2
        Me.ClearToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(23, 22)
        Me.ClearToolStripMenuItem.Text = "ToolStripButton2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 412)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblNumPoints)
        Me.Controls.Add(Me.picOut)
        Me.Name = "Form1"
        Me.Text = "tools"
        CType(Me.picOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picOut As System.Windows.Forms.PictureBox
    Friend WithEvents lblNumPoints As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ScanToolStripMenuItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripButton

End Class
