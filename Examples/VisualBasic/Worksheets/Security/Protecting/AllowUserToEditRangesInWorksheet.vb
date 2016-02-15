Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Worksheets.Security.Protecting
    Public Class AllowUserToEditRangesInWorksheet
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Instantiate a new Workbook
            Dim book As New Workbook()

            'Get the first (default) worksheet
            Dim sheet As Worksheet = book.Worksheets(0)

            'Get the Allow Edit Ranges
            Dim allowRanges As ProtectedRangeCollection = sheet.AllowEditRanges

            'Define ProtectedRange
            Dim proteced_range As ProtectedRange

            'Create the range
            Dim idx As Integer = allowRanges.Add("r2", 1, 1, 3, 3)
            proteced_range = allowRanges(idx)

            'Specify the passoword
            proteced_range.Password = "123"

            'Protect the sheet
            sheet.Protect(ProtectionType.All)

            'Save the Excel file
            book.Save(dataDir & "protectedrange.out.xls")

        End Sub
    End Class
End Namespace