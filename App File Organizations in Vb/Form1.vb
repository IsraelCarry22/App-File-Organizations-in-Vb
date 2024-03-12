Public Class Form1
    Public filePath As String
    Public Alumnos As IOrganización

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If NombreTXTisNull() AndAlso ApellidoTXTisNull() Then
            Return
        End If

        If Unidad1TXTisNull() AndAlso Unidad2TXTisNull() AndAlso Unidad3TXTisNull() Then
            Return
        End If

        Dim alumno As New Alumno()

        alumno.Id = ListFilesData.RowCount
        alumno.Nombre = NombreTXT.Text
        alumno.Apellido = ApellidoTXT.Text
        alumno.Unidad1 = Integer.Parse(Unidad1TXT.Text)
        alumno.Unidad2 = Integer.Parse(Unidad2TXT.Text)
        alumno.Unidad3 = Integer.Parse(Unidad3TXT.Text)

        Alumnos.Add(alumno)

        ListFilesData.Rows.Add(alumno.Id, alumno.Nombre, alumno.Apellido, alumno.Unidad1, alumno.Unidad2, alumno.Unidad3, alumno.Promedio)

        IDTXT.Clear()
        NombreTXT.Clear()
        ApellidoTXT.Clear()
        Unidad1TXT.Clear()
        Unidad2TXT.Clear()
        Unidad3TXT.Clear()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim IdDelete As Integer
        If Integer.TryParse(IDTXT.Text, IdDelete) Then
            Alumnos.Delete(IdDelete)
        ElseIf Alumnos.Count > 0 Then
            Alumnos.Delete(Alumnos.Count - 1)
        End If
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim IdEdit As Integer
        If Integer.TryParse(IDTXT.Text, IdEdit) Then
            Dim alumno As New Alumno()

            alumno.Nombre = NombreTXT.Text
            alumno.Apellido = ApellidoTXT.Text
            alumno.Unidad1 = Integer.Parse(Unidad1TXT.Text)
            alumno.Unidad2 = Integer.Parse(Unidad2TXT.Text)
            alumno.Unidad3 = Integer.Parse(Unidad3TXT.Text)

            Alumnos.Edit(IdEdit, alumno)

            IDTXT.Clear()
            NombreTXT.Clear()
            ApellidoTXT.Clear()
            Unidad1TXT.Clear()
            Unidad2TXT.Clear()
            Unidad3TXT.Clear()
        End If
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        Dim IdSearch As Integer
        If Integer.TryParse(IDTXT.Text, IdSearch) Then
            ListFilesData.Rows.Clear()

            Alumnos.Search(IdSearch, ListFilesData)

            IDTXT.Clear()
        End If
    End Sub

    Private Sub ViewAll_Click(sender As Object, e As EventArgs) Handles ViewAll.Click
        ListFilesData.Rows.Clear()

        Alumnos.Show(ListFilesData)
    End Sub

    Public Function Dialog(IsOpenOrSave As Boolean, ByRef filePath As String, filter As String) As Boolean
        If IsOpenOrSave Then
            Dim fileDialog As New OpenFileDialog With {.Filter = filter}

            If fileDialog.ShowDialog() <> DialogResult.OK Then
                Return True
            End If

            filePath = fileDialog.FileName

            Return False
        Else
            Dim saveFileTem As New SaveFileDialog With {.Filter = filter}

            If saveFileTem.ShowDialog() <> DialogResult.OK Then
                MessageBox.Show("Operación Cancelada por el usuario", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Return True
            End If

            filePath = saveFileTem.FileName

            Return False
        End If
    End Function

    Private Sub OpenMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ListFilesData.Rows.Clear()
        ListFilesData.Columns.Clear()

        If Dialog(True, filePath, "Archivos CSV (*.csv)|*.csv") Then
            Return
        End If

        Open_Save.GetFileExtension(True, filePath, ListFilesData)
    End Sub

    Private Sub SaveMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If ListFilesData.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(filePath) Then
            If Dialog(False, filePath, "Archivos CSV (*.csv)|*.csv") Then
                Return
            End If

            Open_Save.GetFileExtension(False, filePath, ListFilesData)
        Else
            Open_Save.GetFileExtension(False, filePath, ListFilesData)
        End If

    End Sub

    Private Sub SaveHowMenuItem_Click(sender As Object, e As EventArgs) Handles SaveHowToolStripMenuItem.Click
        If ListFilesData.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Dialog(False, filePath, "Archivos CSV (*.csv)|*.csv") Then
            Return
        End If

        Open_Save.GetFileExtension(False, filePath, ListFilesData)
    End Sub

    Private Sub SecuancialsMenuItem_Click(sender As Object, e As EventArgs) Handles SecuencialsToolStripMenuItem.Click
        Alumnos = New OrganizaciónSecuencial()

        Alumnos.Show(ListFilesData)
    End Sub

    Private Sub HashMenuItem_Click(sender As Object, e As EventArgs) Handles HashToolStripMenuItem.Click
        Alumnos = New OrganizaciónHash()

        Alumnos.Show(ListFilesData)
    End Sub

    Private Sub AccesoAleatorioMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoAleatorioToolStripMenuItem.Click
        Alumnos = New OrganizaciónAccesoAleatorio()

        Alumnos.Show(ListFilesData)
    End Sub

    Public Function NombreTXTisNull() As Boolean
        Return String.IsNullOrEmpty(NombreTXT.Text)
    End Function

    Public Function ApellidoTXTisNull() As Boolean
        Return String.IsNullOrEmpty(ApellidoTXT.Text)
    End Function

    Public Function Unidad1TXTisNull() As Boolean
        Return String.IsNullOrEmpty(Unidad1TXT.Text)
    End Function

    Public Function Unidad2TXTisNull() As Boolean
        Return String.IsNullOrEmpty(Unidad2TXT.Text)
    End Function

    Public Function Unidad3TXTisNull() As Boolean
        Return String.IsNullOrEmpty(Unidad3TXT.Text)
    End Function
End Class
