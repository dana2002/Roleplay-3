namespace RoleplayGame
{
  public class Heroes: Character
  {
    public Heroes(string name)
      : base(name)
    {}

    public int PuntosDeVictoria
    {
      get{
        return this.PuntosDeVictoria;
      }
      set{
        this.PuntosDeVictoria = value;
      }
    }

    public void AcumularPuntos(Enemies enemigo)
    {
      this.PuntosDeVictoria += enemigo.puntosDeVictoriaEnemigo;
    }
  }
}