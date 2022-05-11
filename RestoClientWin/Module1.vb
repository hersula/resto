Module Module1

    'Public strConn As String = "server=localhost;database=resto;integrated security=true;"
    Public strConn As String = "server=.\ZSERVER;database=Resto;user id=sa;password=sa!"
    'Public strConn As String = "server=localhost\sql2005,20010;database=resto;user id=sa;password=sa!"
    'Public strConn As String = "server=192.168.78.100\sql2005;database=resto;user id=sa;password=sa!"
    Public CN As SqlClient.SqlConnection
    Public nSignTable As Char
    Public nTableNumber As Byte

    Public _pubLocationID As String
    Public _pubCabangID As String
    Public _pubDataposID As String
    Public _pubComputerID As String
    Public _pubOprID As String

    Public _pubCurSalesDate As String
    Public _pubValSC As Decimal
    Public _pubValPPn As Decimal

    Public Sub setParameter()
        _pubLocationID = frmMain.cmbFloor.SelectedValue

        _pubCabangID = "0001"
        _pubComputerID = "001"
        _pubDataposID = "001"

        _pubOprID = ""

        _pubValSC = 0.05
        _pubValPPn = 1.1
    End Sub

    Public Sub cekKoneksi()

        If CN Is Nothing Then
            CN = New SqlClient.SqlConnection
            CN.ConnectionString = strConn
            CN.Open()
        Else
            If CN.State = ConnectionState.Closed Or CN.State = ConnectionState.Broken Then
                CN.Open()
            End If
        End If
    End Sub

    Public Sub CustomeMessage(ByVal lcMeTxt As String, ByVal lcLblMsg As String, ByVal lcMessage As String, Optional ByVal isOkButton As Boolean = False, Optional ByRef isRetVal As Boolean = False)
        Dim f As New frmMessage
        f.Text = lcMeTxt
        f.lblHeaderMessage.Text = lcLblMsg
        f.txtMessage.Text = lcMessage
        f.isOkButton = isOkButton
        f.ShowDialog()
        isRetVal = f.isReturn
        f.Dispose()

    End Sub

End Module
