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
        Me.cmdadditem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbxmenu = New System.Windows.Forms.ListBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'cmdadditem
        '
        Me.cmdadditem.Location = New System.Drawing.Point(220, 14)
        Me.cmdadditem.Name = "cmdadditem"
        Me.cmdadditem.Size = New System.Drawing.Size(142, 23)
        Me.cmdadditem.TabIndex = 0
        Me.cmdadditem.Text = "Add Menu Item"
        Me.cmdadditem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Price"
        '
        'txtitem
        '
        Me.txtitem.Location = New System.Drawing.Point(88, 14)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(100, 20)
        Me.txtitem.TabIndex = 3
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(88, 57)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 20)
        Me.txtprice.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Menu"
        '
        'lbxmenu
        '
        Me.lbxmenu.FormattingEnabled = True
        Me.lbxmenu.Location = New System.Drawing.Point(88, 136)
        Me.lbxmenu.Name = "lbxmenu"
        Me.lbxmenu.Size = New System.Drawing.Size(274, 251)
        Me.lbxmenu.TabIndex = 7
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(220, 56)
        Me.MaskedTextBox1.Mask = "99999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 8
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 413)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.lbxmenu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdadditem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdadditem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtitem As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbxmenu As System.Windows.Forms.ListBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox

End Class
