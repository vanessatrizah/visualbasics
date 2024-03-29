<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.AddCrop = New System.Windows.Forms.Button()
        Me.DeleteCrop = New System.Windows.Forms.Button()
        Me.ViewCrop = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddCrop
        '
        Me.AddCrop.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AddCrop.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCrop.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.AddCrop.Location = New System.Drawing.Point(24, 204)
        Me.AddCrop.Name = "AddCrop"
        Me.AddCrop.Size = New System.Drawing.Size(133, 42)
        Me.AddCrop.TabIndex = 0
        Me.AddCrop.Text = "AddCrop"
        Me.AddCrop.UseVisualStyleBackColor = False
        '
        'DeleteCrop
        '
        Me.DeleteCrop.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DeleteCrop.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteCrop.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.DeleteCrop.Location = New System.Drawing.Point(289, 205)
        Me.DeleteCrop.Name = "DeleteCrop"
        Me.DeleteCrop.Size = New System.Drawing.Size(127, 41)
        Me.DeleteCrop.TabIndex = 1
        Me.DeleteCrop.Text = "DeleteCrop"
        Me.DeleteCrop.UseVisualStyleBackColor = False
        '
        'ViewCrop
        '
        Me.ViewCrop.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ViewCrop.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCrop.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ViewCrop.Location = New System.Drawing.Point(24, 304)
        Me.ViewCrop.Name = "ViewCrop"
        Me.ViewCrop.Size = New System.Drawing.Size(133, 43)
        Me.ViewCrop.TabIndex = 2
        Me.ViewCrop.Text = "ViewCrop"
        Me.ViewCrop.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnExit.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnExit.Location = New System.Drawing.Point(289, 304)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(127, 43)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.ViewCrop)
        Me.Controls.Add(Me.DeleteCrop)
        Me.Controls.Add(Me.AddCrop)
        Me.Name = "Form1"
        Me.Text = "CropManagementForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddCrop As Button
    Friend WithEvents DeleteCrop As Button
    Friend WithEvents ViewCrop As Button
    Friend WithEvents BtnExit As Button
End Class
