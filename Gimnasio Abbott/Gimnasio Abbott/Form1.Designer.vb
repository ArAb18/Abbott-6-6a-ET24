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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_GYM = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.txt_ejercicio = New System.Windows.Forms.TextBox()
        Me.txt_reps = New System.Windows.Forms.TextBox()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.txt_semana = New System.Windows.Forms.TextBox()
        Me.txt_iddatos = New System.Windows.Forms.TextBox()
        Me.s = New System.Windows.Forms.Label()
        CType(Me.DGV_GYM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gimnasio"
        '
        'DGV_GYM
        '
        Me.DGV_GYM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_GYM.Location = New System.Drawing.Point(340, 109)
        Me.DGV_GYM.Name = "DGV_GYM"
        Me.DGV_GYM.Size = New System.Drawing.Size(420, 262)
        Me.DGV_GYM.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EJERCICIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "REPETICIONES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "PESO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "SEMANA"
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(58, 348)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(127, 43)
        Me.btn_insertar.TabIndex = 6
        Me.btn_insertar.Text = "Insertar Datos"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'txt_ejercicio
        '
        Me.txt_ejercicio.Location = New System.Drawing.Point(157, 163)
        Me.txt_ejercicio.Name = "txt_ejercicio"
        Me.txt_ejercicio.Size = New System.Drawing.Size(100, 20)
        Me.txt_ejercicio.TabIndex = 7
        '
        'txt_reps
        '
        Me.txt_reps.Location = New System.Drawing.Point(157, 205)
        Me.txt_reps.Name = "txt_reps"
        Me.txt_reps.Size = New System.Drawing.Size(100, 20)
        Me.txt_reps.TabIndex = 8
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(157, 250)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(100, 20)
        Me.txt_peso.TabIndex = 9
        '
        'txt_semana
        '
        Me.txt_semana.Location = New System.Drawing.Point(157, 287)
        Me.txt_semana.Name = "txt_semana"
        Me.txt_semana.Size = New System.Drawing.Size(100, 20)
        Me.txt_semana.TabIndex = 10
        '
        'txt_iddatos
        '
        Me.txt_iddatos.Location = New System.Drawing.Point(157, 120)
        Me.txt_iddatos.Name = "txt_iddatos"
        Me.txt_iddatos.Size = New System.Drawing.Size(100, 20)
        Me.txt_iddatos.TabIndex = 12
        '
        's
        '
        Me.s.AutoSize = True
        Me.s.Location = New System.Drawing.Point(55, 123)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(18, 13)
        Me.s.TabIndex = 11
        Me.s.Text = "ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_iddatos)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.txt_semana)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.txt_reps)
        Me.Controls.Add(Me.txt_ejercicio)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_GYM)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV_GYM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_GYM As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_insertar As Button
    Friend WithEvents txt_ejercicio As TextBox
    Friend WithEvents txt_reps As TextBox
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents txt_semana As TextBox
    Friend WithEvents txt_iddatos As TextBox
    Friend WithEvents s As Label
End Class
