Imports System.Data.SqlClient
Public Class Form1
    Dim transportation As String
    Dim cmd_gl As SqlCommand
    Dim dr_gl As SqlDataReader
    Dim query_gl As String
    Dim DateIssue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt")
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBtransportation.Items.Add("Pick Up")
        CBtransportation.Items.Add("Box")
        CBtransportation.Items.Add("Blind Van")
        CBtransportation.Items.Add("Truck")
        CBtransportation.Items.Add("BTT")
        CBtransportation.Items.Add("Forklift")
        CBtransportation.Items.Add("Other")

        TBtransportation.Visible = False
        BTupdate.Visible = False
        TBrequestid.Visible = False

        show_request()
    End Sub

    Private Sub CBtransportation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBtransportation.SelectedIndexChanged
        transportation = CBtransportation.Text

        If CBtransportation.Text = "Other" Then
            TBtransportation.Visible = True
        Else
            TBtransportation.Visible = False
        End If
    End Sub

    Private Sub bSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTsend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim RequestId As String

        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(RequestId)+1 AS MXID FROM TB_Transportation"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            RequestId = dr("MXID")
            dr.Close()

            query = "INSERT INTO TB_Transportation (RequestId, NameRequestor, RequestorId, Unit, " & _
                "DateIssue, UnitDestination, acRegis, Transportation, Phone, Instruction) " & _
                "VALUES (" & RequestId & ", '" & TBname.Text & "', '" & TBid.Text & "', " & _
                " '" & TBunit.Text & "', '" & DateIssue & "', '" & TBdestination.Text & "', '" & TBac.Text & "', " & _
                " '" & transportation & "', '" & TBphone.Text & "', '" & TBinstruction.Text & "')"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            clear_from()

            LVreq.Clear()
            show_request()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub clear_from()

        TBname.Text = ""
        TBid.Text = ""
        TBunit.Text = ""
        TBdestination.Text = ""
        TBac.Text = ""
        CBtransportation.Text = ""
        TBtransportation.Text = ""
        TBphone.Text = ""
        TBinstruction.Text = ""

        TBinstruction.Visible = False
    End Sub

    Private Sub TBtransportation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtransportation.TextChanged
        transportation = TBtransportation.Text
    End Sub
    Private Sub show_request()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVreq.View = View.Details
        LVreq.Columns.Add("No", 50)
        LVreq.Columns.Add("Nama", 200)
        LVreq.Columns.Add("Unit From", 100)
        LVreq.Columns.Add("Unit To", 100)
        LVreq.Columns.Add("Request Date", 200)
        LVreq.Columns.Add("Transportation", 150)

        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT * FROM TB_Transportation"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                LVreq.Items.Add(dr("RequestId"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("NameRequestor"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("Unit"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("UnitDestination"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("DateIssue"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("Transportation"))

            Loop
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim RequestId As String

        Try
            RequestId = LVreq.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "DELETE FROM Request WHERE RequestId = '" + RequestId + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()

            LVreq.Clear()
            show_request()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim RequestId As String
        BTsend.Visible = False
        BTupdate.Visible = True


        Try
            RequestId = LVreq.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "SELECT * FROM Request WHERE RequestId = '" + RequestId + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            TBname.Text = dr("NameRequestor")
            TBid.Text = dr("RequestorId")
            TBunit.Text = dr("Unit")
            DTPdate.Value = dr("DateIssue")
            TBdestination.Text = dr("UnitDestination")
            TBac.Text = dr("acRegis")
            transportation = dr("Transportation")
            TBphone.Text = dr("Phone")
            TBinstruction.Text = dr("Instruction")
            TBrequestid.Text = dr("RequestId")

            Call CloseKoneksi()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BTupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTupdate.Click
        BTupdate.Visible = False
        BTsend.Visible = True

        Try
            Call OpenKoneksi()
            query_gl = "UPDATE TB_Transportation SET " & _
                                "NameRequestor = '" & TBname.Text & "', " & _
                                "RequestorId = '" & TBid.Text & "', " & _
                                "Unit = '" & TBunit.Text & "', " & _
                                "DateIssue = '" & DateIssue & "', " & _
                                "UnitDestination = '" & TBdestination.Text & "', " & _
                                "acRegis = '" & TBac.Text & "', " & _
                                "Transportation = '" & transportation & "', " & _
                                "Phone = '" & TBphone.Text & "', " & _
                                "Instruction = '" & TBinstruction.Text & "' " & _
                                "WHERE RequestId = " & TBrequestid.Text & " "

            cmd_gl = New SqlCommand(query_gl, conn)
            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call CloseKoneksi()
            clear_from()

            LVreq.Clear()
            show_request()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class

