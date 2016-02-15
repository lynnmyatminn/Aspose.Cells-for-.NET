Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Formatting.ConfiguringAlignmentSettings
    Public Class WrappingText
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiating a Workbook object
            Dim workbook As New Workbook()

            'Obtaining the reference of the worksheet
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            'Accessing the "A1" cell from the worksheet
            Dim cell As Global.Aspose.Cells.Cell = worksheet.Cells("A1")

            'Adding some value to the "A1" cell
            cell.PutValue("Visit Aspose!")

            'Setting the horizontal alignment of the text in the "A1" cell
            Dim style As Style = cell.GetStyle()

            'Enabling the text to be wrapped within the cell
            style.IsTextWrapped = True

            cell.SetStyle(style)

            'Saving the Excel file
            workbook.Save(dataDir & "book1.out.xls", SaveFormat.Excel97To2003)
        End Sub
    End Class
End Namespace