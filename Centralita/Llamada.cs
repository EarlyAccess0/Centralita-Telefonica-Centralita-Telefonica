class Llamada
{
    public string NumeroOrigen { get; }
    public string NumeroDestino { get; }
    public int Duracion { get; }

    public Llamada(string numeroOrigen, string numeroDestino, int duracion)
    {
        NumeroOrigen = numeroOrigen;
        NumeroDestino = numeroDestino;
        Duracion = duracion;
    }
}