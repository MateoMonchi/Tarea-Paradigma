using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _velocidadMovimiento = 5f;
    public Vector2 raycastDireccion = Vector2.left;
    public float distanciaRayCast = 3f;
    private void Movimiento()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f) * _velocidadMovimiento * Time.deltaTime;
        MoverJugador(movimiento);
    }
    public void Update()
    {
        Movimiento();
        if (Input.GetKeyDown(KeyCode.R))
        {
            interaccion();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Piña();
        }
    }
    private void MoverJugador(Vector3 movimiento)
    {
        transform.Translate(movimiento, Space.World);
    }
    void interaccion()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, raycastDireccion, distanciaRayCast);

        if (hit.collider != null)
        {
            Iinteractuable interactuable = hit.collider.GetComponent<Iinteractuable>();
            if (interactuable != null)
            {
                Debug.Log("Interaction" + hit.collider.name);
                interactuable.AccionEnemigo();
            }

        }
    }
    public void Piña()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, raycastDireccion, distanciaRayCast);

        if (hit.collider != null)
        {
            IAtaqueEnemigo interactuable = hit.collider.GetComponent<IAtaqueEnemigo>();
            if (interactuable != null)
            {
                Debug.Log("Le suelta una piña" + hit.collider.name);
                interactuable.RecibirDaño();
            }

        }
    }
}

public interface Iinteractuable
{
    void AccionEnemigo();
}
public interface IAtaqueEnemigo
{
    void RecibirDaño();
}