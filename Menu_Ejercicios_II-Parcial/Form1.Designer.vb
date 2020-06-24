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
        Me.Button_Clase = New System.Windows.Forms.Button()
        Me.Button_Tarea = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Clase
        '
        Me.Button_Clase.Location = New System.Drawing.Point(30, 35)
        Me.Button_Clase.Name = "Button_Clase"
        Me.Button_Clase.Size = New System.Drawing.Size(181, 142)
        Me.Button_Clase.TabIndex = 0
        Me.Button_Clase.Text = "Ejercicios Clase"
        Me.Button_Clase.UseVisualStyleBackColor = True
        '
        'Button_Tarea
        '
        Me.Button_Tarea.Location = New System.Drawing.Point(235, 35)
        Me.Button_Tarea.Name = "Button_Tarea"
        Me.Button_Tarea.Size = New System.Drawing.Size(181, 142)
        Me.Button_Tarea.TabIndex = 1
        Me.Button_Tarea.Text = "Ejercicios Tareas"
        Me.Button_Tarea.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 218)
        Me.Controls.Add(Me.Button_Tarea)
        Me.Controls.Add(Me.Button_Clase)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Clase As Button
    Friend WithEvents Button_Tarea As Button
End Class
