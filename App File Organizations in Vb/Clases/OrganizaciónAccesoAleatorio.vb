Public Class OrganizaciónAccesoAleatorio
    Implements IOrganización

    Private ReadOnly organizationsHash As OrganizaciónHash

    Public Sub New()
        organizationsHash = New OrganizaciónHash()
    End Sub

    Public ReadOnly Property Count As Integer Implements IOrganización.Count
        Get
            Return organizationsHash.Count
        End Get
    End Property

    Public Sub Add(alumno As Alumno) Implements IOrganización.Add
        organizationsHash.Add(alumno)
        Update()
    End Sub

    Public Sub Delete(id As Integer) Implements IOrganización.Delete
        organizationsHash.Delete(id)
        Update()
    End Sub

    Public Sub Search(id As Integer, dataGridView As DataGridView) Implements IOrganización.Search
        organizationsHash.Search(id, dataGridView)
    End Sub

    Public Sub Edit(id As Integer, nuevoAlumno As Alumno) Implements IOrganización.Edit
        organizationsHash.Edit(id, nuevoAlumno)
    End Sub

    Public Sub Show(dataGridView As DataGridView) Implements IOrganización.Show
        organizationsHash.Show(dataGridView)
    End Sub

    Private Sub Update()
        organizationsHash.Update()
    End Sub
End Class
