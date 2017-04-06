Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PihcsaDataSet.movil' Puede moverla o quitarla según sea necesario.
        Me.MovilTableAdapter.Fill(Me.PihcsaDataSet.movil)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.MovilTableAdapter.insertar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, CInt(TextBox8.Text), CInt(TextBox9.Text), CInt(TextBox10.Text), TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, DateTimePicker1.Text, DomainUpDown1.Text, TextBox15.Text)
        Me.MovilTableAdapter.Fill(Me.PihcsaDataSet.movil)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.MovilTableAdapter.eliminar(TextBox1.Text)
        Me.MovilTableAdapter.Fill(Me.PihcsaDataSet.movil)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.MovilTableAdapter.actualizar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, CInt(TextBox8.Text), CInt(TextBox9.Text), CInt(TextBox10.Text), TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, DateTimePicker1.Text, DomainUpDown1.Text, TextBox15.Text)
        Me.MovilTableAdapter.Fill(Me.PihcsaDataSet.movil)
    End Sub
End Class
