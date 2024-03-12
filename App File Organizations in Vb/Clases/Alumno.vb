Public Class Alumno
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Unidad1 As Integer
    Public Property Unidad2 As Integer
    Public Property Unidad3 As Integer

    Public ReadOnly Property Promedio As Decimal
        Get
            Return (Unidad1 + Unidad2 + Unidad3) / 3
        End Get
    End Property
End Class