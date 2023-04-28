Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class Form2
    Private Sub ExportCsvButton_Click(sender As Object, e As EventArgs) Handles ExportCsvButton.Click
        ' Create an OpenFileDialog to allow the user to select a CSV file
        Dim openFileDialog1 As New OpenFileDialog With {
        .Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        }

        ' If the user selects a file, parse it in the background using a BackgroundWorker
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog1.FileName
            Dim bgWorker As New BackgroundWorker()
            AddHandler bgWorker.DoWork, AddressOf ParseCsvFile
            AddHandler bgWorker.RunWorkerCompleted, AddressOf LoadCsvData
            bgWorker.RunWorkerAsync(fileName)
        End If
    End Sub

    Private Sub ParseCsvFile(sender As Object, e As DoWorkEventArgs)
        ' This method is run on a background thread and parses the CSV file
        Dim fileName As String = DirectCast(e.Argument, String)
        Dim csvData As New List(Of String())
        Using reader As New StreamReader(fileName)
            While Not reader.EndOfStream
                ' Read each line of the CSV file and split it into fields
                Dim line As String = reader.ReadLine()
                Dim fields As String() = line.Split(","c)
                ' Add the fields to the csvData list
                csvData.Add(fields)
            End While
        End Using
        ' Set the result of the background worker to the csvData list
        e.Result = csvData
    End Sub

    Private Sub LoadCsvData(sender As Object, e As RunWorkerCompletedEventArgs)
        ' This method is run on the UI thread and loads the CSV data into a DataGridView
        Dim csvData As List(Of String()) = DirectCast(e.Result, List(Of String()))
        Dim header As String() = csvData(0)
        ' Create a new DataTable and add columns for each field in the header row
        Dim dt As New DataTable()
        For Each colName As String In header
            dt.Columns.Add(New DataColumn(colName, GetType(String)))
        Next
        ' Add each row of data to the DataTable
        For i As Integer = 1 To csvData.Count - 1
            Dim fields As String() = csvData(i)
            Dim row As DataRow = dt.NewRow()
            row.ItemArray = fields
            dt.Rows.Add(row)
        Next
        ' Set the DataSource property of the DataGridView to the DataTable
        DataGridView1.DataSource = dt
    End Sub


    Public Sub BackupCsvButton_Click(sender As Object, e As EventArgs) Handles BackupCsvButton.Click
        'Check if there are any rows in the DataGridView
        If DataGridView1.Rows.Count = 0 Then
            'Ask the user if they still want to create a backup
            Dim result As DialogResult = MessageBox.Show("The DataGridView is empty. Do you still want to create a backup?", "Backup Empty DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                'Return if the user doesn't want to create a backup
                Return
            End If
        End If
        'Create a new SaveFileDialog instance
        Dim saveFileDialog1 As New SaveFileDialog()
        'Set the filter for the file dialog to CSV files
        saveFileDialog1.Filter = "CSV Files (.csv)|.csv|All Files (.)|."
        'Show the save file dialog and continue if the user clicked OK
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            'Get the selected file name
            Dim fileName As String = saveFileDialog1.FileName
            'Use a Using statement to automatically dispose of the StreamWriter object
            Using writer As New StreamWriter(fileName)
                'Create a list to hold the header names
                Dim headers As New List(Of String)
                'Loop through each column in the DataGridView and add the header name to the list
                For Each column As DataGridViewColumn In DataGridView1.Columns
                    headers.Add(column.HeaderText)
                Next
                'Write the header names to the CSV file
                writer.WriteLine(String.Join(",", headers))
                'Loop through each row in the DataGridView
                For Each row As DataGridViewRow In DataGridView1.Rows
                    'Create a StringBuilder to concatenate the field values
                    Dim fields As New StringBuilder()
                    'Loop through each cell in the row and add the value to the StringBuilder
                    For Each cell As DataGridViewCell In row.Cells
                        'Check if the cell value is not null or empty
                        If Not String.IsNullOrWhiteSpace(cell.Value?.ToString()) Then
                            'Append the cell value to the StringBuilder
                            fields.Append(cell.Value.ToString())
                        End If
                        'Add a comma after each cell value
                        fields.Append(",")
                    Next
                    'Write the row values to the CSV file and trim the last comma
                    writer.WriteLine(fields.ToString().TrimEnd(","))
                Next
            End Using
            'Show a success message to the user
            MessageBox.Show("Backup saved successfully!")
        End If
    End Sub

    ' Declare a new instance of the OpenFileDialog class
    Private openFileDialog1 As New OpenFileDialog()

    ' Define constants for the file filter and title of the file selection dialog
    Private Const FILE_FILTER As String = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
    Private Const FILE_SELECT_TITLE As String = "Select a CSV file to delete"

    ' Event handler for the Delete CSV button click event
    Private Sub DeleteCsvButton_Click(sender As Object, e As EventArgs) Handles DeleteCsvButton.Click
        ' Set the filter and title for the file selection dialog
        openFileDialog1.Filter = FILE_FILTER
        openFileDialog1.Title = FILE_SELECT_TITLE
        openFileDialog1.Multiselect = False

        ' Show the file selection dialog and return if the user cancels
        If openFileDialog1.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        ' Get the path and file name of the selected file
        Dim filePath As String = openFileDialog1.FileName
        Dim fileName As String = Path.GetFileName(filePath)

        ' Display a confirmation message box to ensure the user wants to delete the selected file
        Dim confirmResult = MessageBox.Show($"Are you sure you want to delete the file {fileName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        ' Return if the user cancels the confirmation
        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        ' Attempt to delete the selected file and handle any exceptions that may occur
        Try
            File.Delete(filePath)
            MessageBox.Show("File deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As IOException
            MessageBox.Show($"An error occurred while deleting the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show($"You don't have permission to delete the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        ' Get the current cell of the DataGridView
        Dim currentCell As DataGridViewCell = DataGridView1.CurrentCell

        ' Check if the current cell is not null and its RowIndex and ColumnIndex are not null
        If currentCell?.RowIndex IsNot Nothing AndAlso currentCell?.ColumnIndex IsNot Nothing Then
            ' Get the row and column number of the current cell, and format them to two digits with leading zeros
            Dim row As String = (currentCell.RowIndex + 1).ToString("D2")
            Dim column As String = (currentCell.ColumnIndex + 1).ToString("D2")

            ' Set the text of the CurrentCellTextBox to show the row and column number of the current cell
            CurrentCellTextBox.Text = $"Row {row}, Column {column}"
        Else
            ' If the current cell is null or its RowIndex and ColumnIndex are null, clear the text of the CurrentCellTextBox
            CurrentCellTextBox.Text = ""
        End If
    End Sub

    ' This event handler is triggered when the "ClearGridButton" is clicked
    Private Sub ClearGridButton_Click(sender As Object, e As EventArgs) Handles ClearGridButton.Click

        ' Check if the DataGridView is already empty
        If DataGridView1.Rows.Count = 0 AndAlso DataGridView1.Columns.Count = 0 Then
            ' Display a message box informing the user that the DataGridView is already empty
            MessageBox.Show("The DataGridView is already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Store the number of rows and columns in the DataGridView
        Dim rowCount As Integer = DataGridView1.Rows.Count
        Dim columnCount As Integer = DataGridView1.Columns.Count

        ' Create a message string to confirm the deletion of the DataGridView
        Dim message As String = $"Are you sure you want to clear the DataGridView?{vbCrLf}This will delete {rowCount} rows and {columnCount} columns."

        ' Display a message box to confirm the deletion of the DataGridView
        Dim result = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user confirms the deletion, set the DataGridView's data source to null
        If result = DialogResult.Yes Then
            DataGridView1.DataSource = Nothing
        End If

    End Sub

    Private Sub GoToCellButton_Click(sender As Object, e As EventArgs) Handles GoToCellButton.Click
        ' Check if the DataGridView is empty or row/column numbers are not specified
        If DataGridView1.RowCount = 0 OrElse DataGridView1.ColumnCount = 0 OrElse String.IsNullOrEmpty(RowTextBox.Text) OrElse String.IsNullOrEmpty(ColumnTextBox.Text) Then
            ' Set the default values to 1 for row and column numbers
            RowTextBox.Text = "1"
            ColumnTextBox.Text = "1"
            Return
        End If

        ' Get the row and column numbers from the text boxes
        Dim row As Integer = CInt(RowTextBox.Text)
        Dim column As Integer = CInt(ColumnTextBox.Text)

        ' Check if the row and column numbers are valid
        If row > 0 AndAlso row <= DataGridView1.RowCount AndAlso column > 0 AndAlso column <= DataGridView1.ColumnCount Then
            ' Set the current cell and scroll to it
            DataGridView1.CurrentCell = DataGridView1(column - 1, row - 1)
            DataGridView1.FirstDisplayedScrollingRowIndex = row - 1
        Else
            ' Display an error message for invalid row or column number
            MessageBox.Show("Invalid row or column number.")
        End If
    End Sub

    Private Function IsIndexSpecified(indexTextBox As TextBox) As Boolean
        ' Check if the index number is specified in the given text box
        If String.IsNullOrEmpty(indexTextBox.Text) Then
            ' Display an error message if the index number is not specified
            MessageBox.Show("Index number is not specified.")
            Return False
        End If
        ' Return True if the index number is specified
        Return True
    End Function

    Private Sub RemoveRowButton_Click(sender As Object, e As EventArgs) Handles RemoveRowButton.Click
        ' Validate user input
        Dim rowNumber As Integer
        If String.IsNullOrEmpty(RowTextBox.Text) OrElse Not Integer.TryParse(RowTextBox.Text, rowNumber) Then
            MessageBox.Show("Please specify a valid row number")
            Return ' Early exit if input is invalid
        End If
        ' Adjust row number if the column headers are visible
        If DataGridView1.ColumnHeadersVisible Then
            rowNumber -= 1
        End If

        ' Check if the row number is within the range of the number of rows in DataGridView1
        If rowNumber < 0 OrElse rowNumber >= DataGridView1.Rows.Count Then
            MessageBox.Show($"Row {rowNumber + 1} does not exist")
            Return ' Early exit if row does not exist
        End If

        ' Confirm with user before removing the row
        Dim result = MessageBox.Show($"Want to remove row {rowNumber + 1}?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            DataGridView1.Rows.RemoveAt(rowNumber) ' Remove the row
        End If
    End Sub

    Private Sub RemoveColumnButton_Click(sender As Object, e As EventArgs) Handles RemoveColumnButton.Click
        ' Validate user input
        Dim columnNumber As Integer
        If Not IsIndexSpecified(ColumnTextBox) OrElse String.IsNullOrEmpty(ColumnTextBox.Text) OrElse Not Integer.TryParse(ColumnTextBox.Text, columnNumber) Then
            MessageBox.Show("Please specify a valid column number")
            Return ' Early exit if input is invalid
        End If
        ' Adjust column number to match index
        columnNumber -= 1

        ' Check if the column number is within the range of the number of columns in DataGridView1
        If columnNumber < 0 OrElse columnNumber >= DataGridView1.Columns.Count Then
            MessageBox.Show($"Column {columnNumber + 1} does not exist")
            Return ' Early exit if column does not exist
        End If

        ' Confirm with user before removing the column
        Dim result = MessageBox.Show($"Want to remove column {columnNumber + 1}?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            DataGridView1.Columns.RemoveAt(columnNumber) ' Remove the column
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Update the row and column text boxes with the clicked cell information
            RowTextBox.Text = $"{e.RowIndex + 1}" ' Convert the row index to a string and display it in RowTextBox
            ColumnTextBox.Text = $"{e.ColumnIndex + 1}" ' Convert the column index to a string and display it in ColumnTextBox
        Else
            ' Clear the row and column text boxes if the clicked cell is invalid
            RowTextBox.Clear() ' Clear the text in RowTextBox
            ColumnTextBox.Clear() ' Clear the text in ColumnTextBox
        End If
    End Sub

    Private Sub NewFileButton_Click(sender As Object, e As EventArgs) Handles NewFileButton.Click
        ' Ask the user how many columns and rows they want to add
        Dim columnsCount As Integer
        Dim rowsCount As Integer
        Dim columnsInput As String = InputBox("Enter the number of columns to add", "Columns Count")
        Dim rowsInput As String = InputBox("Enter the number of rows to add", "Rows Count")
        ' Validate the user input for columns and rows
        If Not Integer.TryParse(columnsInput, columnsCount) OrElse columnsCount < 1 Then
            MessageBox.Show("Invalid number of columns specified.", "Error")
            Return
        End If
        If Not Integer.TryParse(rowsInput, rowsCount) OrElse rowsCount < 1 Then
            MessageBox.Show("Invalid number of rows specified.", "Error")
            Return
        End If

        ' Ask the user if they want to create a new file and delete any existing data
        Dim result As DialogResult = MessageBox.Show("Creating a new file will remove any existing data. Do you want to continue?", "Confirm", MessageBoxButtons.YesNo)

        ' If the user clicked Yes, create a new table and display it in the DataGridView
        If result = DialogResult.Yes Then
            ' Create a new table with the specified number of columns and rows
            Dim table As New DataTable()
            For i As Integer = 1 To columnsCount
                table.Columns.Add($"Column{i}")
            Next
            For i As Integer = 1 To rowsCount
                table.Rows.Add()
            Next

            ' Set the new table as the data source for the DataGridView
            DataGridView1.DataSource = table
        End If
    End Sub

End Class
