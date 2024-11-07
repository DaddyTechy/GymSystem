Public Class ErrorHandler
    Public Shared Sub HandleError(ex As Exception)
        ' Log the error (you can customize this to log to a file, database, etc.)
        Console.WriteLine("Error: " & ex.Message)
        Console.WriteLine("Stack Trace: " & ex.StackTrace)

        ' Show a user-friendly message
        MessageBox.Show("An unexpected error occurred. Please complete any form Appropriately or Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Shared Sub HandleInputError(message As String)
        ' Log the input error (you can customize this to log to a file, database, etc.)
        Console.WriteLine("Input Error: " & message)

        ' Show a user-friendly message
        MessageBox.Show(message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class


