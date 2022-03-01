<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reg_data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reg_data))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.new_btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.save_btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.info_grpbx = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comment_txtbx = New System.Windows.Forms.TextBox()
        Me.email_txtbx = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.addy_txtbx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cell_txtbx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tel_txtbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ln_txtbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fn_txtbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_txtbx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.info_grpbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.new_btn, Me.ToolStripSeparator1, Me.save_btn, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(522, 70)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'new_btn
        '
        Me.new_btn.Image = CType(resources.GetObject("new_btn.Image"), System.Drawing.Image)
        Me.new_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.new_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.new_btn.Name = "new_btn"
        Me.new_btn.Size = New System.Drawing.Size(102, 67)
        Me.new_btn.Text = "new record"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'save_btn
        '
        Me.save_btn.Enabled = False
        Me.save_btn.Image = CType(resources.GetObject("save_btn.Image"), System.Drawing.Image)
        Me.save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.save_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(66, 67)
        Me.save_btn.Text = "save"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 70)
        '
        'info_grpbx
        '
        Me.info_grpbx.Controls.Add(Me.Label8)
        Me.info_grpbx.Controls.Add(Me.comment_txtbx)
        Me.info_grpbx.Controls.Add(Me.email_txtbx)
        Me.info_grpbx.Controls.Add(Me.Label7)
        Me.info_grpbx.Controls.Add(Me.addy_txtbx)
        Me.info_grpbx.Controls.Add(Me.Label6)
        Me.info_grpbx.Controls.Add(Me.cell_txtbx)
        Me.info_grpbx.Controls.Add(Me.Label5)
        Me.info_grpbx.Controls.Add(Me.tel_txtbx)
        Me.info_grpbx.Controls.Add(Me.Label4)
        Me.info_grpbx.Controls.Add(Me.ln_txtbx)
        Me.info_grpbx.Controls.Add(Me.Label3)
        Me.info_grpbx.Controls.Add(Me.fn_txtbx)
        Me.info_grpbx.Controls.Add(Me.Label2)
        Me.info_grpbx.Controls.Add(Me.id_txtbx)
        Me.info_grpbx.Controls.Add(Me.Label1)
        Me.info_grpbx.Location = New System.Drawing.Point(12, 79)
        Me.info_grpbx.Name = "info_grpbx"
        Me.info_grpbx.Size = New System.Drawing.Size(496, 536)
        Me.info_grpbx.TabIndex = 1
        Me.info_grpbx.TabStop = False
        Me.info_grpbx.Text = "information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "comment:"
        '
        'comment_txtbx
        '
        Me.comment_txtbx.Location = New System.Drawing.Point(144, 373)
        Me.comment_txtbx.Multiline = True
        Me.comment_txtbx.Name = "comment_txtbx"
        Me.comment_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.comment_txtbx.Size = New System.Drawing.Size(296, 142)
        Me.comment_txtbx.TabIndex = 14
        '
        'email_txtbx
        '
        Me.email_txtbx.Location = New System.Drawing.Point(144, 269)
        Me.email_txtbx.Name = "email_txtbx"
        Me.email_txtbx.Size = New System.Drawing.Size(296, 23)
        Me.email_txtbx.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "address:"
        '
        'addy_txtbx
        '
        Me.addy_txtbx.Location = New System.Drawing.Point(144, 323)
        Me.addy_txtbx.Name = "addy_txtbx"
        Me.addy_txtbx.Size = New System.Drawing.Size(296, 23)
        Me.addy_txtbx.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "email:"
        '
        'cell_txtbx
        '
        Me.cell_txtbx.Location = New System.Drawing.Point(144, 217)
        Me.cell_txtbx.Name = "cell_txtbx"
        Me.cell_txtbx.Size = New System.Drawing.Size(296, 23)
        Me.cell_txtbx.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "cell number:"
        '
        'tel_txtbx
        '
        Me.tel_txtbx.Location = New System.Drawing.Point(144, 168)
        Me.tel_txtbx.Name = "tel_txtbx"
        Me.tel_txtbx.Size = New System.Drawing.Size(296, 23)
        Me.tel_txtbx.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "tel:"
        '
        'ln_txtbx
        '
        Me.ln_txtbx.Location = New System.Drawing.Point(144, 128)
        Me.ln_txtbx.Name = "ln_txtbx"
        Me.ln_txtbx.Size = New System.Drawing.Size(296, 23)
        Me.ln_txtbx.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "last name:"
        '
        'fn_txtbx
        '
        Me.fn_txtbx.Location = New System.Drawing.Point(144, 85)
        Me.fn_txtbx.Name = "fn_txtbx"
        Me.fn_txtbx.Size = New System.Drawing.Size(296, 23)
        Me.fn_txtbx.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "first name:"
        '
        'id_txtbx
        '
        Me.id_txtbx.Location = New System.Drawing.Point(144, 42)
        Me.id_txtbx.Name = "id_txtbx"
        Me.id_txtbx.Size = New System.Drawing.Size(296, 23)
        Me.id_txtbx.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'reg_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 627)
        Me.Controls.Add(Me.info_grpbx)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "reg_data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register data"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.info_grpbx.ResumeLayout(False)
        Me.info_grpbx.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents new_btn As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents save_btn As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents info_grpbx As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents comment_txtbx As TextBox
    Friend WithEvents email_txtbx As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents addy_txtbx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cell_txtbx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tel_txtbx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ln_txtbx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fn_txtbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents id_txtbx As TextBox
    Friend WithEvents Label1 As Label
End Class
