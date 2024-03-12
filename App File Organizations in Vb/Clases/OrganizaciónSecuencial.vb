Public Class OrganizaciónSecuencial
    Implements IOrganización

    Private ReadOnly alumnos As List(Of Alumno)

    Public Sub New()
        alumnos = New List(Of Alumno)()
    End Sub

    Public ReadOnly Property Count As Integer Implements IOrganización.Count
        Get
            Return alumnos.Count
        End Get
    End Property

    Public Sub Add(alumno As Alumno) Implements IOrganización.Add
        alumnos.Add(alumno)
        Update()
    End Sub

    Public Sub Delete(id As Integer) Implements IOrganización.Delete
        Dim alumno As Alumno = alumnos.Find(Function(a) a.Id = id)
        If alumno IsNot Nothing Then
            alumnos.Remove(alumno)
            Update()
        End If
    End Sub

    Public Sub Search(id As Integer, dataGridView As DataGridView) Implements IOrganización.Search
        dataGridView.Rows.Clear()

        Dim alumnoEncontrado As Alumno = alumnos.Find(Function(a) a.Id = id)
        If alumnoEncontrado IsNot Nothing Then
            dataGridView.Rows.Add(alumnoEncontrado.Id, alumnoEncontrado.Nombre, alumnoEncontrado.Apellido, alumnoEncontrado.Unidad1, alumnoEncontrado.Unidad2, alumnoEncontrado.Unidad3, alumnoEncontrado.Promedio)
        End If
    End Sub

    Public Sub Edit(id As Integer, nuevoAlumno As Alumno) Implements IOrganización.Edit
        Dim index As Integer = alumnos.FindIndex(Function(a) a.Id = id)
        If index <> -1 Then
            alumnos(index) = nuevoAlumno
        End If
    End Sub

    Public Sub Show(dataGridView As DataGridView) Implements IOrganización.Show
        dataGridView.Rows.Clear()

        For Each alumno As Alumno In alumnos
            dataGridView.Rows.Add(alumno.Id, alumno.Nombre, alumno.Apellido, alumno.Unidad1, alumno.Unidad2, alumno.Unidad3, alumno.Promedio)
        Next
    End Sub

    Private Sub Update()
        For i As Integer = 0 To alumnos.Count - 1
            alumnos(i).Id = i
        Next
    End Sub
End Class
