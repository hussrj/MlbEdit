<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.InputButton = New System.Windows.Forms.Button()
        Me.TextPanel = New System.Windows.Forms.Panel()
        Me.TextSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TransTextBox = New System.Windows.Forms.TextBox()
        Me.MlbTextBox = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.TextPanel.SuspendLayout()
        CType(Me.TextSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TextSplitContainer.Panel1.SuspendLayout()
        Me.TextSplitContainer.Panel2.SuspendLayout()
        Me.TextSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.InputTextBox)
        Me.Panel1.Controls.Add(Me.InputButton)
        Me.Panel1.Location = New System.Drawing.Point(10, 305)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 77)
        Me.Panel1.TabIndex = 0
        '
        'InputTextBox
        '
        Me.InputTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InputTextBox.Location = New System.Drawing.Point(3, 44)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(169, 20)
        Me.InputTextBox.TabIndex = 0
        '
        'InputButton
        '
        Me.InputButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InputButton.Location = New System.Drawing.Point(178, 38)
        Me.InputButton.Name = "InputButton"
        Me.InputButton.Size = New System.Drawing.Size(102, 31)
        Me.InputButton.TabIndex = 1
        Me.InputButton.Text = "Input"
        Me.InputButton.UseVisualStyleBackColor = True
        '
        'TextPanel
        '
        Me.TextPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPanel.Controls.Add(Me.TextSplitContainer)
        Me.TextPanel.Location = New System.Drawing.Point(10, 12)
        Me.TextPanel.Name = "TextPanel"
        Me.TextPanel.Size = New System.Drawing.Size(478, 287)
        Me.TextPanel.TabIndex = 1
        '
        'TextSplitContainer
        '
        Me.TextSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.TextSplitContainer.Name = "TextSplitContainer"
        '
        'TextSplitContainer.Panel1
        '
        Me.TextSplitContainer.Panel1.Controls.Add(Me.MlbTextBox)
        '
        'TextSplitContainer.Panel2
        '
        Me.TextSplitContainer.Panel2.Controls.Add(Me.TransTextBox)
        Me.TextSplitContainer.Size = New System.Drawing.Size(478, 287)
        Me.TextSplitContainer.SplitterDistance = 239
        Me.TextSplitContainer.TabIndex = 0
        '
        'TransTextBox
        '
        Me.TransTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransTextBox.Location = New System.Drawing.Point(0, 0)
        Me.TransTextBox.Multiline = True
        Me.TransTextBox.Name = "TransTextBox"
        Me.TransTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TransTextBox.Size = New System.Drawing.Size(235, 287)
        Me.TransTextBox.TabIndex = 3
        '
        'MlbTextBox
        '
        Me.MlbTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MlbTextBox.Location = New System.Drawing.Point(0, 0)
        Me.MlbTextBox.Name = "MlbTextBox"
        Me.MlbTextBox.Size = New System.Drawing.Size(239, 287)
        Me.MlbTextBox.TabIndex = 0
        Me.MlbTextBox.Text = ""
        '
        'MainForm
        '
        Me.AcceptButton = Me.InputButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 394)
        Me.Controls.Add(Me.TextPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainForm"
        Me.Text = "MLB Edit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TextPanel.ResumeLayout(False)
        Me.TextSplitContainer.Panel1.ResumeLayout(False)
        Me.TextSplitContainer.Panel2.ResumeLayout(False)
        Me.TextSplitContainer.Panel2.PerformLayout()
        CType(Me.TextSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TextSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextPanel As System.Windows.Forms.Panel
    Friend WithEvents TextSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents TransTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InputButton As System.Windows.Forms.Button
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MlbTextBox As System.Windows.Forms.RichTextBox

End Class
