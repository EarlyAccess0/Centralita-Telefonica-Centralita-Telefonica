using System;
using System.Collections.Generic;


class Practica2
{
    static void Main()
    {
        Centralita centralita = new Centralita();

       
        centralita.RegistrarLlamada(new Llamada("829771111", "913345561", 60)); 
        centralita.RegistrarLlamada(new Llamada("809662529", "923223444", 120)); 
        centralita.RegistrarLlamada(new Llamada("809332343", "935366323", 180)); 
        centralita.RegistrarLlamada(new Llamada("829455221", "946554176", 240)); 

   
        centralita.MostrarLlamadas();

     
        Console.WriteLine($"Número total de llamadas: {centralita.NumeroTotalLlamadas()}");
        Console.WriteLine($"Facturación total: {centralita.FacturacionTotal()} euros");
    }
}

