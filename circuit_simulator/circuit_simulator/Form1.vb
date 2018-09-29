Class Form1
    Dim x As Integer
    Dim tp As TestPoints = New TestPoints()
    Dim input As InputSignal = New InputSignal()






    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'change input column color
        data_table.EnableHeadersVisualStyles = False
        data_table.Columns(0).HeaderCell.Style.BackColor = Color.Yellow
        data_table.Columns(0).DefaultCellStyle.BackColor = Color.Yellow
        data_table.Columns(1).HeaderCell.Style.BackColor = Color.YellowGreen
        data_table.Columns(1).DefaultCellStyle.BackColor = Color.YellowGreen
        data_table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'init all signal to low
        clear_output_signal()
        'change state of TP12-TP15
        change_state()
    End Sub

    Private Sub clear_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_check.CheckedChanged
        Dim txt As String = New String("Low")
        input.clear = clear_check.Checked()
        If input.clear = True Then
            txt = "High"
        Else
            'clear output and display another record
            clear_output_signal()
            change_state()
            'print data on table
            update_table()
        End If
        clear_check.Text = "Clear " + "(" + txt + ")"
    End Sub

    Private Sub data_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_check.CheckedChanged
        Dim txt As String = New String("Low")
        input.data = data_check.Checked()
        If input.data = True Then
            txt = "High"
        End If
        data_check.Text = "Data " + "(" + txt + ")"
    End Sub

    Private Sub clk_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clk_button.Click
        'check if Clear is high
        If input.clear = True Then
            'shift right data
            shift_data_right()
            'change state of TP12-TP15
            change_state()
        End If
        'print data on table
        update_table()

    End Sub
    Private Sub change_state()
        'change state of TP12-TP15
        tp.TP12 = tp.TP8 And tp.TP10
        tp.TP13 = tp.TP10 And tp.TP11
        tp.TP14 = tp.TP12 Or tp.TP9
        tp.TP15 = Not (tp.TP13 Or tp.TP14)
    End Sub

    Private Sub clear_output_signal()
        tp.TP8 = False
        tp.TP9 = False
        tp.TP10 = False
        tp.TP11 = False
    End Sub
    Private Sub shift_data_right()
        'shift right data
        tp.TP11 = tp.TP10
        tp.TP10 = tp.TP9
        tp.TP9 = tp.TP8
        tp.TP8 = input.data()
    End Sub

    Private Sub update_table()
        'add new row and fill with data
        data_table.Rows.Add(New String() {Convert.ToDecimal(input.clear), Convert.ToDecimal(input.data), Convert.ToDecimal(tp.TP8), Convert.ToDecimal(tp.TP9), Convert.ToDecimal(tp.TP10), Convert.ToDecimal(tp.TP11), Convert.ToDecimal(tp.TP12), Convert.ToDecimal(tp.TP13), Convert.ToDecimal(tp.TP14), Convert.ToDecimal(tp.TP15)})
        'scroll to last row
        data_table.FirstDisplayedScrollingRowIndex = data_table.RowCount - 1
        'select the last row
        data_table.Rows(data_table.RowCount - 1).Selected = True

    End Sub
End Class
