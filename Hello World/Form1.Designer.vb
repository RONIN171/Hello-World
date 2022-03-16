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
        Me.lblTopic = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtShow = New System.Windows.Forms.TextBox()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTopic
        '
        Me.lblTopic.AutoSize = True
        Me.lblTopic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTopic.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTopic.Location = New System.Drawing.Point(192, 31)
        Me.lblTopic.Name = "lblTopic"
        Me.lblTopic.Size = New System.Drawing.Size(417, 29)
        Me.lblTopic.TabIndex = 0
        Me.lblTopic.Text = "Welcome to My First Form in VB "
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Magenta
        Me.btnShow.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnShow.Location = New System.Drawing.Point(297, 80)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(175, 43)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "SHOW POP UP"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(57, 184)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(182, 21)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "ENTER YOUR NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(245, 166)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(323, 47)
        Me.txtName.TabIndex = 4
        '
        'txtShow
        '
        Me.txtShow.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtShow.Location = New System.Drawing.Point(245, 314)
        Me.txtShow.Name = "txtShow"
        Me.txtShow.Size = New System.Drawing.Size(323, 47)
        Me.txtShow.TabIndex = 5
        '
        'btnPop
        '
        Me.btnPop.BackColor = System.Drawing.Color.Fuchsia
        Me.btnPop.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPop.Location = New System.Drawing.Point(267, 243)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(103, 37)
        Me.btnPop.TabIndex = 6
        Me.btnPop.Text = "POP UP"
        Me.btnPop.UseVisualStyleBackColor = False
        '
        'btnText
        '
        Me.btnText.BackColor = System.Drawing.Color.Fuchsia
        Me.btnText.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnText.Location = New System.Drawing.Point(424, 243)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(134, 37)
        Me.btnText.TabIndex = 7
        Me.btnText.Text = "TEXTBOX"
        Me.btnText.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.HotPink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.txtShow)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblTopic)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTopic As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtShow As TextBox
    Friend WithEvents btnPop As Button
    Friend WithEvents btnText As Button
End Class
