using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : MonoBehaviour
{

    public float alturaFinal = 2f; // Altura final deseada
    public float tiempoTotal = 5f; // Tiempo total en segundos para el movimiento

    private float alturaInicial; // Altura inicial del objeto
    private float tiempoPasado = 0f; // Tiempo transcurrido desde el inicio

    private void Start()
    {
        alturaInicial = transform.position.y; // Guardar la altura inicial del objeto
        Collider[] colisionadores = FindObjectsOfType<Collider>();

        // Desactivar las colisiones con cada colisionador
        foreach (Collider colisionador in colisionadores)
        {
            // Ignorar colisiones con el colisionador del objeto que estás elevando
            if (colisionador != GetComponent<Collider>())
            {
                Physics.IgnoreCollision(GetComponent<Collider>(), colisionador, true);
            }
        }
    }

    private void Update()
    {
        if (tiempoPasado < tiempoTotal)
        {
            tiempoPasado += Time.deltaTime; // Incrementar el tiempo transcurrido

            // Calcular la interpolación lineal entre la altura inicial y final según el tiempo
            float t = tiempoPasado / tiempoTotal;
            float nuevaAltura = Mathf.Lerp(alturaInicial, alturaInicial + alturaFinal, t);

            // Actualizar la posición del objeto solo en el eje Y
            transform.position = new Vector3(transform.position.x, nuevaAltura, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // Desactivar colisiones físicas con otros objetos
        Physics.IgnoreCollision(GetComponent<Collider>(), other, true);
    }
    private void OnTriggerExit(Collider other)
    {
        // Reactivar colisiones físicas con otros objetos
        Physics.IgnoreCollision(GetComponent<Collider>(), other, true);
    }

}
