using System;
using System.Text;
using System.Collections.Generic;

{
     
}
namespace RoleplayGame
{
  public class Encounter
  {
    private List<Enemies> listaEnemigios = new List<Enemies>();
    private List<Heroes> listaHeroes = new List<Heroes>();

    public void AddEnemigos(Enemies enemigo)
    {
      listaEnemigios.Add(enemigo);
    } 

    public void AddHeroes(Heroes heroe)
    {
      listaHeroes.Add(heroe);
    }   

    /*private void AtaqueEnemigo()
    {
      int contador = 0;
      foreach( Enemies enemigo in listaEnemigios){
        listaHeroes[contador].ReceiveAttack(enemigo.AttackValue);
        contador ++;
        if(contador <= listaHeroes.Count){
          
        }

      }
    }

    public void DoEncounter(Heroes heroe, Enemies enemigo)   
    {
      
    } */
  }
}