Imports TelefoniaEntidades
Module LineaTest
    Sub main()
        Dim l1 As New Linea(376, 4699669)

        Console.WriteLine(l1.Estado)
        l1.Suspender()
        Console.WriteLine(l1.Estado)
        l1.Reactivar()
        Console.WriteLine(l1.ToString)
        l1.Suspender()
        Console.WriteLine(l1.ToString)
    End Sub
End Module
