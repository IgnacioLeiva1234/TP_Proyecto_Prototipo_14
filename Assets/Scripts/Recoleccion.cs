using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoleccion : MonoBehaviour
{
     static int contador = 0;

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            contador++;
            Debug.Log("Objetos recolectados: " + contador);
            Destroy(gameObject);
        }
    }
}
