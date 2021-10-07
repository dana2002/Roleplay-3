namespace RoleplayGame
{
  public class Cronos: Enemies
  {
    public Cronos(string name, int PuntosDeVictoriaEnemigo)
      :base(name, PuntosDeVictoriaEnemigo)
    {
      this.AddItem(new Axe());
      this.AddItem(new Helmet());
    }
  }
}