<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbrir
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
        Me.cmbRecorrido = New System.Windows.Forms.ComboBox
        Me.Abrir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbRecorrido
        '
        Me.cmbRecorrido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecorrido.FormattingEnabled = True
        Me.cmbRecorrido.Location = New System.Drawing.Point(155, 15)
        Me.cmbRecorrido.Name = "cmbRecorrido"
        Me.cmbRecorrido.Size = New System.Drawing.Size(162, 21)
        Me.cmbRecorrido.TabIndex = 1
        '
        'Abrir
        '
        Me.Abrir.Location = New System.Drawing.Point(155, 81)
        Me.Abrir.Name = "Abrir"
        Me.Abrir.Size = New System.Drawing.Size(67, 23)
        Me.Abrir.TabIndex = 1
        Me.Abrir.Text = "Abrir"
        Me.Abrir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione un recorrido"
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(250, 81)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(67, 23)
        Me.Cancelar.TabIndex = 3
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 112)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Abrir)
        Me.Controls.Add(Me.cmbRecorrido)
        Me.Name = "Form2"
        Me.Text = "Seleccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbRecorrido As System.Windows.Forms.ComboBox
    Friend WithEvents Abrir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cancelar As System.Windows.Forms.Button
End Class
