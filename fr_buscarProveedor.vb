﻿Public Class fr_buscarProveedor

    Dim prove As fr_eliminarActualizaProveedor = New fr_eliminarActualizaProveedor()

    Private Sub fr_buscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SaeCpPDataSet2.tbl_sae_proveedor' Puede moverla o quitarla según sea necesario.
        Me.Tbl_sae_proveedorTableAdapter.Fill(Me.SaeCpPDataSet2.tbl_sae_proveedor)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        TextBox1.Text = dgv.Cells(0).Value.ToString()
        TextBox2.Text = dgv.Cells(1).Value.ToString()
        TextBox3.Text = dgv.Cells(2).Value.ToString()
        TextBox4.Text = dgv.Cells(3).Value.ToString()
        TextBox5.Text = dgv.Cells(4).Value.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class