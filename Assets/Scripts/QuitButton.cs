using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class QuitButton : MonoBehaviour
{
    public bool isplayerinside = false;
    public GameObject currentplayer;

    void Update()
    {
        if (isplayerinside)
        {
            if (currentplayer.transform.position.y > -17f)
            {
                UnityEngine.Application.Quit();
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que ha entrado en el trigger tiene el tag del jugador
        if (other.gameObject.tag == "Player")
        {
            isplayerinside = true;
            currentplayer = other.gameObject;

        }
    }
    void OnTriggerExit(Collider other)
    {
        isplayerinside = false;
        currentplayer = null;
    }
}
