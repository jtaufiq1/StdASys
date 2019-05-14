<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainFrm
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
        Me.gitBtn = New System.Windows.Forms.Button()
        Me.githubBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'gitBtn
        '
        Me.gitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gitBtn.Image = Global.TestGitEx.My.Resources.Resources.Git
        Me.gitBtn.Location = New System.Drawing.Point(47, 110)
        Me.gitBtn.Name = "gitBtn"
        Me.gitBtn.Size = New System.Drawing.Size(82, 40)
        Me.gitBtn.TabIndex = 0
        Me.gitBtn.Text = "Git"
        Me.gitBtn.UseVisualStyleBackColor = True
        '
        'githubBtn
        '
        Me.githubBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.githubBtn.Image = Global.TestGitEx.My.Resources.Resources.GitHub_Mark
        Me.githubBtn.Location = New System.Drawing.Point(527, 110)
        Me.githubBtn.Name = "githubBtn"
        Me.githubBtn.Size = New System.Drawing.Size(82, 40)
        Me.githubBtn.TabIndex = 1
        Me.githubBtn.Text = "Github"
        Me.githubBtn.UseVisualStyleBackColor = True
        '
        'mainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TestGitEx.My.Resources.Resources.Git
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(669, 446)
        Me.Controls.Add(Me.githubBtn)
        Me.Controls.Add(Me.gitBtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "mainFrm"
        Me.Text = "Git And Github Test"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gitBtn As Button
    Friend WithEvents githubBtn As Button
End Class
