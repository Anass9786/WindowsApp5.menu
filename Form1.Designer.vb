<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExàToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EX04ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EX05ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EX06ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EX07ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExàToolStripMenuItem, Me.FfToolStripMenuItem, Me.FToolStripMenuItem, Me.EX04ToolStripMenuItem, Me.EX05ToolStripMenuItem, Me.EX06ToolStripMenuItem, Me.EX07ToolStripMenuItem, Me.QuiterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExàToolStripMenuItem
        '
        Me.ExàToolStripMenuItem.Name = "ExàToolStripMenuItem"
        Me.ExàToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.ExàToolStripMenuItem.Text = "EX01"
        '
        'FfToolStripMenuItem
        '
        Me.FfToolStripMenuItem.Name = "FfToolStripMenuItem"
        Me.FfToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.FfToolStripMenuItem.Text = "EX02"
        '
        'FToolStripMenuItem
        '
        Me.FToolStripMenuItem.Name = "FToolStripMenuItem"
        Me.FToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.FToolStripMenuItem.Text = "EX03"
        '
        'EX04ToolStripMenuItem
        '
        Me.EX04ToolStripMenuItem.Name = "EX04ToolStripMenuItem"
        Me.EX04ToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.EX04ToolStripMenuItem.Text = "EX04"
        '
        'EX05ToolStripMenuItem
        '
        Me.EX05ToolStripMenuItem.Name = "EX05ToolStripMenuItem"
        Me.EX05ToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.EX05ToolStripMenuItem.Text = "EX05"
        '
        'EX06ToolStripMenuItem
        '
        Me.EX06ToolStripMenuItem.Name = "EX06ToolStripMenuItem"
        Me.EX06ToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.EX06ToolStripMenuItem.Text = "EX06"
        '
        'EX07ToolStripMenuItem
        '
        Me.EX07ToolStripMenuItem.Name = "EX07ToolStripMenuItem"
        Me.EX07ToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.EX07ToolStripMenuItem.Text = "EX07"
        '
        'QuiterToolStripMenuItem
        '
        Me.QuiterToolStripMenuItem.Name = "QuiterToolStripMenuItem"
        Me.QuiterToolStripMenuItem.Size = New System.Drawing.Size(77, 29)
        Me.QuiterToolStripMenuItem.Text = "Quiter"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExàToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EX04ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EX05ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EX06ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EX07ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuiterToolStripMenuItem As ToolStripMenuItem
End Class
