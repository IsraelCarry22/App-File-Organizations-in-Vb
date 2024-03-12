Imports System.IO

Public Module Open_Save
    Public Sub GetFileExtension(ByVal isOpen As Boolean, ByRef filePath As String, ByVal ListFilesData As DataGridView)
        If isOpen Then
            Select Case Path.GetExtension(filePath).ToLower()
                Case ".csv"
                    OpenFileCSV(filePath, ListFilesData)
            End Select
        Else
            Select Case Path.GetExtension(filePath).ToLower()
                Case ".csv"
                    SaveFileCSV(filePath, ListFilesData)
            End Select
        End If
    End Sub

    Public Sub OpenFileCSV(ByRef filePath As String, ByVal ListFilesData As DataGridView)
        Using CSVReader As New StreamReader(filePath)
            Dim primeraLinea As String = CSVReader.ReadLine()

            If primeraLinea Is Nothing Then
                Return
            End If

            Dim encabezados As String() = primeraLinea.Split(","c)

            ListFilesData.Columns.Clear()

            For Each encabezado In encabezados
                ListFilesData.Columns.Add(encabezado, encabezado)
            Next

            While Not CSVReader.EndOfStream
                Dim line As String = CSVReader.ReadLine()
                Dim propertyless As String() = line.Split(","c)

                ListFilesData.Rows.Add(propertyless)
            End While

            MessageBox.Show("Datos cargados desde el archivo CSV correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    Public Sub SaveFileCSV(ByRef filePath As String, ByVal ListFilesData As DataGridView)
        Using CSVwriter As New StreamWriter(filePath)
            For i As Integer = 0 To ListFilesData.Columns.Count - 1
                CSVwriter.Write(ListFilesData.Columns(i).HeaderText)

                If i < ListFilesData.Columns.Count - 1 Then
                    CSVwriter.Write(",")
                End If
            Next

            CSVwriter.WriteLine()

            For i As Integer = 0 To ListFilesData.Rows.Count - 1
                For j As Integer = 0 To ListFilesData.Columns.Count - 1
                    CSVwriter.Write(ListFilesData.Rows(i).Cells(j).Value)

                    If j < ListFilesData.Columns.Count - 1 Then
                        CSVwriter.Write(",")
                    End If
                Next

                CSVwriter.WriteLine()
            Next
        End Using

        MessageBox.Show("Archivo CSV guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
