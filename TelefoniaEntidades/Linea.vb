﻿Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _activo As Boolean

    Public Sub New(codigoArea As UShort, numero As UInteger)
        Me.CodigoArea = codigoArea
        Me.Numero = numero
        _activo = True
    End Sub
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            _codigoArea = value
        End Set
    End Property
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property
    Public ReadOnly Property Estado As String
        Get
            Return If(_activo, "Activo", "Suspendido")
        End Get
    End Property
    Public Sub Suspender()
        _activo = False
    End Sub
    Public Sub Reactivar()
        _activo = True
    End Sub

    Public Overrides Function ToString() As String
        Dim value As String = CodigoArea & " " & Numero
        If Not _activo Then
            value = value & " " & Estado
        End If
        Return value
    End Function
End Class
