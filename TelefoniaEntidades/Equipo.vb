Public Class Equipo
    Private _serie As String
    Private _fechaVenta As Date
    Private _modelo As Modelo

    Public Sub New(marca As Marca, modelo As Modelo, serie As String)
        Me.Serie = serie
        Me.Modelo = modelo

    End Sub
    Public Property Modelo As Modelo
        Get
            Return _modelo
        End Get
        Set(value As Modelo)
            _modelo = value
        End Set
    End Property
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 15 Then
                _serie = value
            End If
        End Set
    End Property
    Public ReadOnly Property fechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property

    Public Sub Vender(fecha As Date)
        _fechaVenta = fecha
    End Sub

    Public Overrides Function ToString() As String
        Return Serie
    End Function
End Class
