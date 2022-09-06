Public Class Service1
    Public timerservicio As New Timers.Timer

    Protected Overrides Sub OnStart(ByVal args() As String)
        timerservicio = New Timers.Timer
        AddHandler timerservicio.Elapsed, AddressOf Ejecutaunaaccion
        timerservicio.Interval = 60000
        timerservicio.Start()
        ' Agregue el código aquí para iniciar el servicio. Este método debería poner
        ' en movimiento los elementos para que el servicio pueda funcionar.
    End Sub
    Public Function Ejecutaunaaccion()
        Dim i As Integer
        For i = 1 To 1000
            My.Computer.FileSystem.WriteAllText("A:\INFORME.TXT", "LINEA: " & i & vbCrLf, True)

        Next
        Return True
    End Function

    Protected Overrides Sub OnStop()
        ' Agregue el código aquí para realizar cualquier anulación necesaria para detener el servicio.
        timerservicio.Close()

    End Sub
    Protected Overrides Sub OnPause()
        timerservicio.Stop()
    End Sub

    Protected Overrides Sub OnContinue()
        timerservicio.Start()
    End Sub

End Class
