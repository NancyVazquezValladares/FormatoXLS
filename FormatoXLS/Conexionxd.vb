Module Conexionxd
    Public conexion As New SqlClient.SqlConnection("data source=LAPTOP-9KA9VTM6\SQLEXPRESS01; initial catalog =Capacitacion; integrated security= SSPI; persist security info= false; trusted_connection = yes;")
    Public cmd As SqlClient.SqlCommand
    Public sqlread As SqlClient.SqlDataReader
    Public query As String
End Module
