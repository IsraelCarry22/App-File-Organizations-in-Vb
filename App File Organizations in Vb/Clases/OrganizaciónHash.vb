Public Class OrganizaciónHash
    Implements IOrganización

    Private ReadOnly hashTable As Dictionary(Of Integer, Alumno)

    Public Sub New()
        hashTable = New Dictionary(Of Integer, Alumno)()
    End Sub

    Public ReadOnly Property Count As Integer Implements IOrganización.Count
        Get
            Return hashTable.Count
        End Get
    End Property

    Public Sub Add(alumno As Alumno) Implements IOrganización.Add
        hashTable.Add(alumno.Id, alumno)
        Update()
    End Sub

    Public Sub Delete(id As Integer) Implements IOrganización.Delete
        If hashTable.ContainsKey(id) Then
            hashTable.Remove(id)
            Update()
        End If
    End Sub

    Public Sub Search(id As Integer, dataGridView As DataGridView) Implements IOrganización.Search
        dataGridView.Rows.Clear()

        Dim alumnoEncontrado As Alumno = Nothing
        If hashTable.TryGetValue(id, alumnoEncontrado) Then
            dataGridView.Rows.Add(alumnoEncontrado.Id, alumnoEncontrado.Nombre, alumnoEncontrado.Apellido, alumnoEncontrado.Unidad1, alumnoEncontrado.Unidad2, alumnoEncontrado.Unidad3, alumnoEncontrado.Promedio)
        End If
    End Sub

    Public Sub Edit(id As Integer, nuevoAlumno As Alumno) Implements IOrganización.Edit
        If hashTable.ContainsKey(id) Then
            hashTable(id) = nuevoAlumno
        End If
    End Sub

    Public Sub Show(dataGridView As DataGridView) Implements IOrganización.Show
        dataGridView.Rows.Clear()

        For Each alumno As Alumno In hashTable.Values
            dataGridView.Rows.Add(alumno.Id, alumno.Nombre, alumno.Apellido, alumno.Unidad1, alumno.Unidad2, alumno.Unidad3, alumno.Promedio)
        Next
    End Sub

    Public Sub Update()
        Dim id As Integer = 0
        For Each alumno As Alumno In hashTable.Values
            alumno.Id = id
            id += 1
        Next
    End Sub
End Class
