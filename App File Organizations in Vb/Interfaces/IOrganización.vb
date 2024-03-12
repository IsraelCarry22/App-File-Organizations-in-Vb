Public Interface IOrganización
    ReadOnly Property Count As Integer
    Sub Add(alumno As Alumno)
    Sub Delete(id As Integer)
    Sub Search(id As Integer, dataGridView As DataGridView)
    Sub Edit(id As Integer, nuevoAlumno As Alumno)
    Sub Show(dataGridView As DataGridView)
End Interface
