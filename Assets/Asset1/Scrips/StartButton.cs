using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public bool isplayerinside= false;
    public GameObject currentplayer;

    void Update()
    {
        if (isplayerinside)
        {
            Debug.Log(currentplayer.transform.position.y);
            if (currentplayer.transform.position.y > -15f)
            {
                
                SceneManager.LoadScene("Scene");
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
