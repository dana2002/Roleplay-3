namespace RoleplayGame
{
  public class Hades: Enemies
  {
    public Hades(string name, int PuntosDeVictoriaEnemigo)
      :base(name, PuntosDeVictoriaEnemigo)
    {
      this.AddItem(new Sword());
      this.AddItem(new Armor());
    }
  }
}