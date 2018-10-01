Imports TelefoniaEntidades

Module MarcaTest

    Sub Main()
        Dim m1 As New Marca("Philips")

        Console.WriteLine("Nombre: " & m1.Nombre)
        Console.WriteLine("ToString " & m1.ToString)
    End Sub

End Module
