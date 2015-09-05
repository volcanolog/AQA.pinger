Imports System.Xml
Imports System
Imports System.IO
Imports System.ComponentModel



Public Class Form1

    Dim tid As Integer
    Dim tsize As Integer = 0

    Private Sub gridRefresh()

        Dim myXML As New XmlDocument
        myXML.Load("https://www.aqa.ru/forum/aqareader.php?last=" & tid)
        tsize += myXML.InnerXml.Length


        Dim root As XmlElement = myXML.DocumentElement
        Dim elemList As XmlNodeList = root.GetElementsByTagName("post")
        Dim i As Integer

        For i = 0 To elemList.Count - 1
            Dim _tid As Integer = elemList.ItemOf(i)("tid").InnerXml
            Dim foundRow As DataRow = topics.Rows.Find(_tid)
            If Not (foundRow Is Nothing) Then
                foundRow.Delete()
            End If


            Dim newRow As DataRow = topics.NewRow()
            newRow.Item("id") = _tid
            newRow.Item("replies") = elemList.ItemOf(i)("repl").InnerXml
            newRow.Item("author") = elemList.ItemOf(i)("author").InnerXml
            newRow.Item("tdate") = elemList.ItemOf(i)("date").InnerXml
            newRow.Item("forum") = elemList.ItemOf(i)("forum").InnerXml
            newRow.Item("subject") = elemList.ItemOf(i)("name").InnerXml
            topics.Rows.Add(newRow)

        Next

        Dim direction As ListSortDirection = ListSortDirection.Descending
        Dim oldColumn As DataGridViewColumn
        If dg.SortedColumn IsNot Nothing Then
            oldColumn = dg.SortedColumn
        Else
            oldColumn = dg.Columns(4)
        End If
        dg.Sort(oldColumn, direction)
        t.Enabled = True

    End Sub

    Private Sub dg_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentDoubleClick
        Dim myUrl As String = "https://www.aqa.ru/forum/vt"
        myUrl &= dg.CurrentRow.Cells(0).Value.ToString
        System.Diagnostics.Process.Start(myUrl)


    End Sub

    Private Sub t_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t.Tick
        t.Enabled = False

        Dim myXML As New XmlDocument
        myXML.Load("https://www.aqa.ru/forum/aqatid.php")
        tsize += myXML.InnerXml.Length
        Dim root As XmlElement = myXML.DocumentElement
        Dim elemList As XmlNodeList = root.GetElementsByTagName("tid")
        If (elemList.ItemOf(0).InnerXml <> tid) Then
            gridRefresh()
            tid = elemList.ItemOf(0).InnerXml
        End If
        t.Enabled = True

        Dim tSizeLabel As String = "Трафик: "

        If (tsize > 1024000) Then
            tSizeLabel &= (tsize \ 1024000) & "MB"
        ElseIf (tsize > 1024) Then
            tSizeLabel &= (tsize \ 1024) & "KB"
        End If
        lbSize.Text = tSizeLabel


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbTimer.SelectedIndex = 4
        t_Tick(t, e)


    End Sub

    Private Sub cbTimer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTimer.SelectedIndexChanged
        Select Case cbTimer.SelectedIndex
            Case 0
                t.Interval = 10000
            Case 1
                t.Interval = 15000
            Case 2
                t.Interval = 30000
            Case 3
                t.Interval = 45000
            Case 4
                t.Interval = 60000
            Case 5
                t.Interval = 180000
            Case 6
                t.Interval = 300000
            Case 7
                t.Interval = 600000
            Case 8
                t.Interval = 900000
            Case 9
                t.Interval = 1800000
            Case 10
                t.Interval = 3600000
            Case 11
                t.Interval = 7200000
            Case 12
                t.Interval = 10800000
        End Select
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llTopic.LinkClicked
        System.Diagnostics.Process.Start("https://www.aqa.ru/forum/vt171833")
    End Sub

    Private Sub llSite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llSite.LinkClicked
        System.Diagnostics.Process.Start("https://www.aqa.ru/")
    End Sub
End Class