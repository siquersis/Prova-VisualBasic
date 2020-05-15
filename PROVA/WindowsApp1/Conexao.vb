Public Class Conexao
    Public abrirConexao As SqlClient.SqlConnection

    Public Sub conectaBanco()
        Try
            abrirConexao = New SqlClient.SqlConnection("Server = NOTEHOUSE; INITIAL CATALOG = ADM_CON;USER ID =sa;PASSWORD=Abcd.123")
            abrirConexao.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub fechaBanco()
        Try
            If Not IsNothing(abrirConexao) Then
                If abrirConexao.State = ConnectionState.Open Then
                    abrirConexao.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ExecuteQuery(ByVal Command As String) As DataSet
        Dim DS As New DataSet
        Dim objDataAdapter As New SqlClient.SqlDataAdapter
        Dim objCommand As New SqlClient.SqlCommand

        Try
            objCommand = abrirConexao.CreateCommand
            objCommand.CommandText = Command

            objDataAdapter = New SqlClient.SqlDataAdapter(objCommand)
            objDataAdapter.Fill(DS)
        Catch ex As Exception
            Throw ex
        End Try

        Return DS
    End Function
End Class
