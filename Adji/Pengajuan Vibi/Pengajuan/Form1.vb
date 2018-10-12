Imports System.Data.SqlClient

Public Class Form1
    Dim bentuk As string

    Private Sub ListView()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVpengajuan.View = View.Details
        LVpengajuan.Columns.Add("No", 50)
        LVpengajuan.Columns.Add("Nama Pelaksana", 150)
        LVpengajuan.Columns.Add("Bidang", 100)
        LVpengajuan.Columns.Add("Jumlah Permintaan", 150)
        LVpengajuan.Columns.Add("Bentuk Dana", 100)
        LVpengajuan.Columns.Add("Keperluan", 200)

        Try
            Call OpenKoneksi()
            Dim query_id As String = "select * from Table_Pengajuan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read
                LVpengajuan.Items.Add(dr("id"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("Nama_Pelaksana"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("Bidang"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("Jumlah_Permintaan"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("Bentuk_Dana"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("Keperluan"))
            Loop
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Bersih()
        TBnamapelaksana.Text = ""
        CBbidang.Text = ""
        TBjumlahpermintaan.Text = ""
        TBkeperluan.Text = ""
        Rcekbank.Checked = False
        Rgiro.Checked = False
        Rtunai.Checked = False
        TBID.Text = ""
        BTsave.Text = "save"

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now
        Call ListView()
        TBID.Visible = False
    End Sub

    Private Sub BTsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTsave.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim tanggal As String = DateTime.Now.ToString("dd-MM-yyyy")
        Dim query As String = ""
        If BTsave.Text = "save" Then
            Try
                Call OpenKoneksi()
                Dim query_id As String = "select MAX(id)+1 AS MXID from Table_Pengajuan"
                cmd = New SqlCommand(query_id, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                uid = dr("MXID")
                dr.Close()

                If Rcekbank.Checked = True Then
                    bentuk = Rcekbank.Text
                ElseIf Rtunai.Checked = True Then
                    bentuk = Rtunai.Text
                ElseIf Rgiro.Checked = True Then
                    bentuk = Rgiro.Text
                End If

                query = "Insert into Table_Pengajuan (id,Nama_Pelaksana,Bidang,Jumlah_Permintaan,Bentuk_Dana,Keperluan,Tanggal) Values(" & uid & ",'" & TBnamapelaksana.Text & "','" & CBbidang.Text & "','" & TBjumlahpermintaan.Text & "','" & bentuk & "','" & TBkeperluan.Text & "','" & tanggal & "')"
                MsgBox("Selamat '" + TBnamapelaksana.Text + "' Anda Bisa Mengakses")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf BTsave.Text = "Update" Then
            Call OpenKoneksi()
            If Rcekbank.Checked = True Then
                bentuk = Rcekbank.Text
            ElseIf Rtunai.Checked = True Then
                bentuk = Rtunai.Text
            ElseIf Rgiro.Checked = True Then
                bentuk = Rgiro.Text
            End If
            query = "Update Table_Pengajuan Set Nama_Pelaksana='" & TBnamapelaksana.Text & "',Bidang='" & CBbidang.Text & "',Jumlah_permintaan='" & TBjumlahpermintaan.Text & "',Bentuk_Dana='" & bentuk & "',Keperluan='" & TBkeperluan.Text & "'Where id='" & TBID.Text & "'"
            MsgBox("Selamat '" + TBnamapelaksana.Text + "'Data Telah Berhasil Di Update")
        End If
        Try
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call CloseKoneksi()
            Bersih()
            LVpengajuan.Clear()
            ListView()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub BTEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTEdit.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim id As String
        Try
            id = LVpengajuan.SelectedItems(0).Text
            Call OpenKoneksi()
            query = "Select * from Table_Pengajuan Where id='" + id + "'"

            If bentuk = Rtunai.Text Then
                Rtunai.Checked = True
            ElseIf bentuk = Rcekbank.Text Then
                Rcekbank.Checked = True
            ElseIf bentuk = Rgiro.Text Then
                Rgiro.Checked = True
            End If
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            TBnamapelaksana.Text = dr("Nama_Pelaksana")
            CBbidang.Text = dr("Bidang")
            TBjumlahpermintaan.Text = dr("Jumlah_Permintaan")
            bentuk = dr("Bentuk_Dana")
            TBkeperluan.Text = dr("Keperluan")
            TBID.Text = dr("id")
            BTsave.Text = "Update"
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub BTDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDelete.Click
        Dim id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        If MsgBox("Apakah Anda Yakin Ingin Menghapusnya?", vbYesNo) = MsgBoxResult.Yes Then
            Try
                id = LVpengajuan.SelectedItems(0).Text
                Call OpenKoneksi()
                Dim query As String = "Delete from Table_Pengajuan Where id='" + id + "'"

                cmd = New SqlCommand(query, conn)
                dr = cmd.ExecuteReader
                Call CloseKoneksi()
                dr.Close()
                LVpengajuan.Clear()
                ListView()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub BTcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTcancel.Click
        Bersih()
    End Sub
End Class
