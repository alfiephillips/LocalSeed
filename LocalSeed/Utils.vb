Public Module Utils

    Public Structure DuplicateReturnType
        Public found As Boolean
        Public loopCount As Integer
    End Structure

    ' function name: FindDuplicate
    ' desc: To be able to identify a duplicate field; this has been modulised to be able to use this in any part of the solution to avoid redundancy of code and increase efficiency.
    ' args: (tableName, columnIndex, tableValue) Returns Boolean
    Public Function FindDuplicate(ByVal DS As DS, ByVal tableName As String, ByVal columnIndex As Integer, ByVal tableValue As String) As DuplicateReturnType
        Dim dataFound As Boolean
        Dim rowCount, loopCount As Integer

        ' query the database to identify number of rows
        rowCount = DS.Tables(tableName).Rows.Count() - 1
        dataFound = False
        loopCount = 0

        ' loop through the user data fields to detect any duplicates specified in the (tableValue) parameter.
        Do While (loopCount <= rowCount) And (dataFound = False)
            Dim dbData = DS.Tables(tableName)(loopCount) ' scrape the data found at the certain (x, y) position according to the (columnIndex, tableValue) parameters
            Dim dbQuery = dbData(columnIndex)

            If (dbQuery = tableValue) Then ' if found exit the loop
                dataFound = True
            End If

            loopCount += 1 ' increment loop count
        Loop

        Dim returnVal As DuplicateReturnType = New DuplicateReturnType With {
            .found = dataFound,
            .loopCount = loopCount - 1
        }

        Return returnVal
    End Function

    ' function name: GetNextUserID
    ' desc: This will search for the next available userID to create a unique primary key hash for the user, ex: ap0001
    ' args: (tableName) Returns String
    Public Function GetNextUserID(ByVal DS As DS, ByVal tableName As String) As String
        ' query the database to get the count of existing users
        Dim rows As Integer = DS.Tables(tableName).Rows.Count
        Dim latestID As Integer = 0

        ' check if the number of rows isn't zero so we can create a new unique id, otherwise this defaults to 0000
        If rows > 0 Then
            Dim stringId As String = DS.Tables(tableName).Rows(rows - 1)(0)
            latestID = Integer.Parse(stringId.Substring(2, 4)) 'ex: strip ap0001 -> 0001 and latestID becomes 1
        End If

        ' increment the latest ID
        Dim incrementedID As Integer = latestID + 1

        ' format the ID
        Dim formattedID As String = incrementedID.ToString("D4")
        Return formattedID
    End Function
End Module
