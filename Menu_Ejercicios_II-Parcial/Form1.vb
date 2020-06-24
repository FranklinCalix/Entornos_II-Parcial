Public Class Form1
    Private Sub Button_Clase_Click(sender As Object, e As EventArgs) Handles Button_Clase.Click
        Ejercicios_Clase.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Tarea_Click(sender As Object, e As EventArgs) Handles Button_Tarea.Click
        Ejercicios_Tareas.Show()
        Me.Hide()
    End Sub
End Class
