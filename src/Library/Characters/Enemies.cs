namespace RoleplayGame
{
  public class Enemies: Character
  {
    public Enemies(string name, int PuntosDeVictoriaEnemigo)
      :base(name)
    {
      this.puntosDeVictoriaEnemigo = PuntosDeVictoriaEnemigo;
    }

    public int puntosDeVictoriaEnemigo{get;set;}
  }
}