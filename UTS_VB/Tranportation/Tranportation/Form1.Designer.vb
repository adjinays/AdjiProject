<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.DTPdate = New System.Windows.Forms.DateTimePicker()
        Me.TBrequestid = New System.Windows.Forms.TextBox()
        Me.LVreq = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTupdate = New System.Windows.Forms.Button()
        Me.BTsend = New System.Windows.Forms.Button()
        Me.TBtransportation = New System.Windows.Forms.TextBox()
        Me.CBtransportation = New System.Windows.Forms.ComboBox()
        Me.TBphone = New System.Windows.Forms.TextBox()
        Me.TBac = New System.Windows.Forms.TextBox()
        Me.TBdestination = New System.Windows.Forms.TextBox()
        Me.TBinstruction = New System.Windows.Forms.TextBox()
        Me.TBunit = New System.Windows.Forms.TextBox()
        Me.TBid = New System.Windows.Forms.TextBox()
        Me.TBname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTPdate
        '
        Me.DTPdate.CustomFormat = "MM/dd/yyyy HH:mm:ss"
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(161, 121)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(200, 20)
        Me.DTPdate.TabIndex = 47
        Me.DTPdate.Value = New Date(2018, 10, 19, 14, 32, 13, 0)
        '
        'TBrequestid
        '
        Me.TBrequestid.Location = New System.Drawing.Point(703, 268)
        Me.TBrequestid.Name = "TBrequestid"
        Me.TBrequestid.ShortcutsEnabled = False
        Me.TBrequestid.Size = New System.Drawing.Size(23, 20)
        Me.TBrequestid.TabIndex = 46
        '
        'LVreq
        '
        Me.LVreq.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LVreq.Location = New System.Drawing.Point(30, 295)
        Me.LVreq.Name = "LVreq"
        Me.LVreq.Size = New System.Drawing.Size(696, 182)
        Me.LVreq.TabIndex = 44
        Me.LVreq.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'BTupdate
        '
        Me.BTupdate.Location = New System.Drawing.Point(390, 268)
        Me.BTupdate.Name = "BTupdate"
        Me.BTupdate.Size = New System.Drawing.Size(129, 23)
        Me.BTupdate.TabIndex = 45
        Me.BTupdate.Text = "Update Request"
        Me.BTupdate.UseVisualStyleBackColor = True
        '
        'BTsend
        '
        Me.BTsend.Location = New System.Drawing.Point(161, 266)
        Me.BTsend.Name = "BTsend"
        Me.BTsend.Size = New System.Drawing.Size(129, 23)
        Me.BTsend.TabIndex = 43
        Me.BTsend.Text = "Send Request"
        Me.BTsend.UseVisualStyleBackColor = True
        '
        'TBtransportation
        '
        Me.TBtransportation.Location = New System.Drawing.Point(590, 82)
        Me.TBtransportation.Name = "TBtransportation"
        Me.TBtransportation.Size = New System.Drawing.Size(100, 20)
        Me.TBtransportation.TabIndex = 42
        '
        'CBtransportation
        '
        Me.CBtransportation.FormattingEnabled = True
        Me.CBtransportation.Location = New System.Drawing.Point(484, 82)
        Me.CBtransportation.Name = "CBtransportation"
        Me.CBtransportation.Size = New System.Drawing.Size(100, 21)
        Me.CBtransportation.TabIndex = 40
        '
        'TBphone
        '
        Me.TBphone.Location = New System.Drawing.Point(484, 115)
        Me.TBphone.Name = "TBphone"
        Me.TBphone.Size = New System.Drawing.Size(100, 20)
        Me.TBphone.TabIndex = 41
        '
        'TBac
        '
        Me.TBac.Location = New System.Drawing.Point(484, 47)
        Me.TBac.Name = "TBac"
        Me.TBac.Size = New System.Drawing.Size(100, 20)
        Me.TBac.TabIndex = 39
        '
        'TBdestination
        '
        Me.TBdestination.Location = New System.Drawing.Point(484, 9)
        Me.TBdestination.Name = "TBdestination"
        Me.TBdestination.Size = New System.Drawing.Size(100, 20)
        Me.TBdestination.TabIndex = 38
        '
        'TBinstruction
        '
        Me.TBinstruction.Location = New System.Drawing.Point(161, 153)
        Me.TBinstruction.Multiline = True
        Me.TBinstruction.Name = "TBinstruction"
        Me.TBinstruction.Size = New System.Drawing.Size(565, 107)
        Me.TBinstruction.TabIndex = 37
        '
        'TBunit
        '
        Me.TBunit.Location = New System.Drawing.Point(161, 79)
        Me.TBunit.Name = "TBunit"
        Me.TBunit.Size = New System.Drawing.Size(100, 20)
        Me.TBunit.TabIndex = 36
        '
        'TBid
        '
        Me.TBid.Location = New System.Drawing.Point(161, 47)
        Me.TBid.Name = "TBid"
        Me.TBid.Size = New System.Drawing.Size(100, 20)
        Me.TBid.TabIndex = 35
        '
        'TBname
        '
        Me.TBname.Location = New System.Drawing.Point(161, 12)
        Me.TBname.Name = "TBname"
        Me.TBname.Size = New System.Drawing.Size(100, 20)
        Me.TBname.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(387, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Transportation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(387, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Ext, Phone/HP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(387, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "A/C Reg"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(387, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "to Unit/Destination"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Instructions"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Date of Issue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Unit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ID Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Name of Requestor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 506)
        Me.Controls.Add(Me.DTPdate)
        Me.Controls.Add(Me.TBrequestid)
        Me.Controls.Add(Me.LVreq)
        Me.Controls.Add(Me.BTupdate)
        Me.Controls.Add(Me.BTsend)
        Me.Controls.Add(Me.TBtransportation)
        Me.Controls.Add(Me.CBtransportation)
        Me.Controls.Add(Me.TBphone)
        Me.Controls.Add(Me.TBac)
        Me.Controls.Add(Me.TBdestination)
        Me.Controls.Add(Me.TBinstruction)
        Me.Controls.Add(Me.TBunit)
        Me.Controls.Add(Me.TBid)
        Me.Controls.Add(Me.TBname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTPdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TBrequestid As System.Windows.Forms.TextBox
    Friend WithEvents LVreq As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTupdate As System.Windows.Forms.Button
    Friend WithEvents BTsend As System.Windows.Forms.Button
    Friend WithEvents TBtransportation As System.Windows.Forms.TextBox
    Friend WithEvents CBtransportation As System.Windows.Forms.ComboBox
    Friend WithEvents TBphone As System.Windows.Forms.TextBox
    Friend WithEvents TBac As System.Windows.Forms.TextBox
    Friend WithEvents TBdestination As System.Windows.Forms.TextBox
    Friend WithEvents TBinstruction As System.Windows.Forms.TextBox
    Friend WithEvents TBunit As System.Windows.Forms.TextBox
    Friend WithEvents TBid As System.Windows.Forms.TextBox
    Friend WithEvents TBname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
