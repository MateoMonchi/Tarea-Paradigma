using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour, Iinteractuable, IAtaqueEnemigo
{
    public ScriptableEnemy scriptableEnemy;
    public int vidaActual;

    private void Awake()
    {
        vidaActual = scriptableEnemy.vida2;
    }

    public void AccionEnemigo()
    {
        Debug.Log($"Nombre: {scriptableEnemy.nombre2}, Vida: {scriptableEnemy.vida2}, Saludo: {scriptableEnemy.saludo2}");
    }

    public void RecibirDaño()
    {
        vidaActual -= 1;
        if (vidaActual <= 0)
        {
            Destroy(gameObject);
        }
    }
}

