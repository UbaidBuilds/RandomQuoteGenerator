<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMotivational = New System.Windows.Forms.Button()
        Me.btnJokes = New System.Windows.Forms.Button()
        Me.btnFacts = New System.Windows.Forms.Button()
        Me.lblSubheading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(94, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(376, 73)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "QuotePortal"
        '
        'btnMotivational
        '
        Me.btnMotivational.Location = New System.Drawing.Point(42, 174)
        Me.btnMotivational.Name = "btnMotivational"
        Me.btnMotivational.Size = New System.Drawing.Size(150, 50)
        Me.btnMotivational.TabIndex = 3
        Me.btnMotivational.Text = "Motivational"
        Me.btnMotivational.UseVisualStyleBackColor = True
        '
        'btnJokes
        '
        Me.btnJokes.Location = New System.Drawing.Point(206, 174)
        Me.btnJokes.Name = "btnJokes"
        Me.btnJokes.Size = New System.Drawing.Size(150, 50)
        Me.btnJokes.TabIndex = 4
        Me.btnJokes.Text = "Jokes"
        Me.btnJokes.UseVisualStyleBackColor = True
        '
        'btnFacts
        '
        Me.btnFacts.Location = New System.Drawing.Point(372, 174)
        Me.btnFacts.Name = "btnFacts"
        Me.btnFacts.Size = New System.Drawing.Size(150, 50)
        Me.btnFacts.TabIndex = 5
        Me.btnFacts.Text = "Facts"
        Me.btnFacts.UseVisualStyleBackColor = True
        '
        'lblSubheading
        '
        Me.lblSubheading.AutoSize = True
        Me.lblSubheading.Location = New System.Drawing.Point(102, 118)
        Me.lblSubheading.Name = "lblSubheading"
        Me.lblSubheading.Size = New System.Drawing.Size(345, 25)
        Me.lblSubheading.TabIndex = 6
        Me.lblSubheading.Text = "Choose the type of quote you want"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 265)
        Me.Controls.Add(Me.lblSubheading)
        Me.Controls.Add(Me.btnFacts)
        Me.Controls.Add(Me.btnJokes)
        Me.Controls.Add(Me.btnMotivational)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMotivational As Button
    Friend WithEvents btnJokes As Button
    Friend WithEvents btnFacts As Button
    Friend WithEvents lblSubheading As Label
End Class
