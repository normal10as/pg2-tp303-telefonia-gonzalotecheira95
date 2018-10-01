Imports TelefoniaEntidades

Module EquipoTest

    Sub main()
        Dim marca As New Marca("Samsumg")
        Dim modelo As New Modelo("J7", marca)
        Dim e1 As New Equipo(marca, modelo, "12345")

        e1.Vender(Now.AddDays(-10))
        Console.WriteLine("Serie: " & e1.Serie)
        Console.WriteLine("Marca: " & e1.Modelo.Marca.ToString)
        Console.WriteLine("Modelo: " & e1.Modelo.ToString)
        Console.WriteLine("To String" & e1.ToString)
        Console.WriteLine("Se vendi: " & e1.fechaVenta)


    End Sub


End Module
