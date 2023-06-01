using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(" patata");
        // Verificar si el objeto que ha entrado en el trigger tiene el tag del jugador
        if (other.CompareTag("Player"))
        {
            Debug.Log(" SCene");
            SceneManager.LoadScene("Scene");
        }
    }

}
