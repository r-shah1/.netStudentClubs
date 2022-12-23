Public Class Form1

    'Array for club names
    Private strClubNames() As String = {"Honors", "Golden Arrow", "Computer"}
    'Variable for club member count
    Private intEnrollSizes(strClubNames.Count) As Integer

    'Array for selected club members
    Private StrEnrollments(0, 0) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Add club names to combo box
        For Each club As String In strClubNames
            cboClubs.Items.Add(club)
        Next
        'Redefine student enrollments
        ReDim StrEnrollments(strClubNames.Count, lstAllStudents.Items.Count)
    End Sub

    'Check for insert errors
    Function InsertErrorCheck() As Boolean

        lblStatus.Text = String.Empty

        'Check if Student is selected
        If lstAllStudents.SelectedIndex = -1 Then   '-1 = empty list
            lblStatus.Text = "Please select a name from the general student list"
            Return False
        End If

        'Check if Club Name is selected
        If cboClubs.SelectedIndex = -1 Then     '-1 = empty list
            lblStatus.Text = "Please select a Club Name from the list"
            Return False
        End If

        Return True
    End Function

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        If InsertErrorCheck() Then
            Dim studentname As String = lstAllStudents.SelectedItem.ToString()
            Dim clubIndex As Integer = cboClubs.SelectedIndex

            'Add name to list if it does not contain the same name
            If Not lstMemberStudents.Items.Contains(studentname) Then
                lstMemberStudents.Items.Add(studentname)
                intEnrollSizes(clubIndex) += 1
                lblClubTotalMembers.Text = lstMemberStudents.Items.Count.ToString() & " member(s)"
            End If

            'save club membersnames into club members array
            For i = 0 To lstMemberStudents.Items.Count - 1
                StrEnrollments(clubIndex, i) = lstMemberStudents.Items(i).ToString()
            Next
        End If
    End Sub

    Private Sub btnRemoveStudent_Click(sender As Object, e As EventArgs) Handles btnRemoveStudent.Click
        lblStatus.Text = String.Empty

        If Not lstMemberStudents.SelectedIndex = -1 Then
            Dim studentIndex As Integer = lstMemberStudents.SelectedIndex
            Dim studentName As String = lstMemberStudents.SelectedItem.ToString()
            Dim clubIndex As Integer = cboClubs.SelectedIndex

            'Remove name from club member list
            lstMemberStudents.Items.Remove(studentName)
            intEnrollSizes(clubIndex) -= 1
            lblClubTotalMembers.Text = lstMemberStudents.Items.Count.ToString() & " member(s)"

            'save club membersnames into club members array
            For i = 0 To lstMemberStudents.Items.Count - 1
                StrEnrollments(clubIndex, i) = lstMemberStudents.Items(i).ToString()
            Next
        Else 'Error if no name in membership list is selected
            lblStatus.Text = "Please select a Student Name to remove from the Membership list"
        End If
    End Sub

    Private Sub cboClubs_SelectedIndexChanged() Handles cboClubs.SelectedIndexChanged
        lstMemberStudents.Items.Clear()

        'Display the members of the selected club
        For i = 0 To lstAllStudents.Items.Count - 1
            Try
                If StrEnrollments(cboClubs.SelectedIndex, i).ToString.Length > 0 Then
                    lstMemberStudents.Items.Add(StrEnrollments(cboClubs.SelectedIndex, i).ToString)
                End If
            Catch ex As Exception
            End Try
        Next

        lblClubTotalMembers.Text = lstMemberStudents.Items.Count.ToString() & " members"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class

