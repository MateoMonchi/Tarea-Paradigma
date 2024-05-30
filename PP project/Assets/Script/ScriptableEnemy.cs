using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Scriptable", menuName ="EnemigoScriptable")]
public class ScriptableEnemy : ScriptableObject
{
    public string Nombre;
    public int Vida;
    public string Saludo;

    public string nombre2
    {
        get
        {
            return Nombre;
        }
    }
   public int vida2
    {
        get
        {
            return Vida;
        }
    }
   public string saludo2
    {
        get
        {
            return Saludo;
        }
    }
}
