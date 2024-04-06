class Centralita
{
    private List<Llamada> llamadas;

    public Centralita()
    {
        llamadas = new List<Llamada>();
    }

    public void RegistrarLlamada(Llamada llamada)
    {
        llamadas.Add(llamada);
    }

    public int NumeroTotalLlamadas()
    {
        return llamadas.Count;
    }

    public double FacturacionTotal()
    {
        double total = 0;
        foreach (var llamada in llamadas)
        {
            total += CalcularCosteLlamada(llamada);
        }
        return total;
    }

    private double CalcularCosteLlamada(Llamada llamada)
    {
        if (llamada.NumeroDestino.StartsWith("9"))
        {
            return 0.15 * llamada.Duracion;
        }
        else
        {
           
            int zona = CalcularZonaProvincial(llamada.NumeroDestino);
            switch (zona)
            {
                case 1:
                    return 0.20 * llamada.Duracion;
                case 2:
                    return 0.25 * llamada.Duracion;
                case 3:
                    return 0.30 * llamada.Duracion;
                default:
                    return 0; 
            }
        }
    }

    private int CalcularZonaProvincial(string numeroDestino)
    {
  
        return int.Parse(numeroDestino.Substring(0, 1));
    }

    public void MostrarLlamadas()
    {
        foreach (var llamada in llamadas)
        {
            Console.WriteLine($"Llamada de {llamada.NumeroOrigen} a {llamada.NumeroDestino}, duración: {llamada.Duracion} segundos");
        }
    }
}
