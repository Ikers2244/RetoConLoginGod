Public Class Validaciones

    Public mensaje As String = ""
    Public Function validarNombre(ByVal nombre As String) As Boolean
        If nombre <> "" Then
            Try
                Dim numero = Integer.Parse(nombre)
                ' Ha escrito solo numeros y no es correcto
                mensaje = " No se puede escribir solo numeros en el campo Nombre"
                Return False
            Catch ex As Exception
                ' No ha escrito numero y es correcto
                Return True
            End Try
        Else
            mensaje = "No se puede dejar en blanco ningún campo"
            Return False
        End If
    End Function

    Public Function validarTipo(ByVal nombre As String) As Boolean
        If nombre <> "" Then
            Try
                Dim numero = Integer.Parse(nombre)
                ' Ha escrito solo numeros y no es correcto
                mensaje = " No se puede escribir solo numeros en el campo Tipo"
                Return False
            Catch ex As Exception
                ' No ha escrito numero y es correcto
                Return True
            End Try
        Else
            mensaje = "No se puede dejar en blanco ningún campo"
            Return False
        End If
    End Function

    Public Function validarPswd(ByVal nombre As String) As Boolean
        If nombre <> "" Then
            Try
                Dim numero = Integer.Parse(nombre)
                ' Ha escrito solo numeros y no es correcto
                mensaje = " No se pueden escribir solo numeros en el campo contraseña"
                Return False
            Catch ex As Exception
                ' No ha escrito numero y es correcto
                Return True
            End Try
        Else
            mensaje = "No se puede dejar en blanco ningún campo"
            Return False
        End If
    End Function

    Public Function validarPuesto(ByVal nombre As String) As Boolean
        If nombre <> "" Then
            Try
                Dim numero = Integer.Parse(nombre)
                ' Ha escrito solo numeros y no es correcto
                mensaje = " No se puede escribir solo numeros en el campo Puesto"
                Return False
            Catch ex As Exception
                ' No ha escrito numero y es correcto
                Return True
            End Try
        Else
            mensaje = "No se puede dejar en blanco ningún campo"
            Return False
        End If
    End Function

    Public Function validarPrecio(ByVal cp As String) As Boolean
        If cp <> "" Then
            Try
                Dim numero = Integer.Parse(cp)
                ' Ha escrito solo numeros y es correcto
                Return True
            Catch ex As Exception
                ' No ha escrito numero y no es correcto
                mensaje = "No se puede escribir letras en el campo Precio"
                Return False
            End Try
        Else
            mensaje = "No se puede dejar en blanco ningún campo"
            Return False
        End If
    End Function

    Public Function validarStock(ByVal cp As String) As Boolean
        If cp <> "" Then
            Try
                Dim numero = Integer.Parse(cp)
                ' Ha escrito solo numeros y es correcto
                Return True
            Catch ex As Exception
                ' No ha escrito numero y no es correcto
                mensaje = "No se puede escribir letras en el campo Stock"
                Return False
            End Try
        Else
            mensaje = "No se puede dejar en blanco ningún campo"
            Return False
        End If
    End Function

    Public Function validarSueldo(ByVal cp As String) As Boolean
        If cp <> "" Then
            Try
                Dim numero = Integer.Parse(cp)
                ' Ha escrito solo numeros y es correcto
                Return True
            Catch ex As Exception
                ' No ha escrito numero y no es correcto
                mensaje = "No se puede escribir letras en el campo Sueldo"
                Return False
            End Try
        Else
            mensaje = "No se puede dejar en blanco ningún campo"
            Return False
        End If
    End Function

    Public Function validarAdmin(ByVal cp As String) As Boolean
        If cp <> "" Then
            Try
                Dim numero = Integer.Parse(cp)
                ' Ha escrito solo numeros y es correcto
                Return True
            Catch ex As Exception
                ' No ha escrito numero y no es correcto
                mensaje = "Se debe escribir un 0 Para no otorgar permisos o un 1 para otorgarlos"
                Return False
            End Try
        Else
            mensaje = "No se puede dejar en blanco ningún campo"
            Return False
        End If
    End Function
End Class
