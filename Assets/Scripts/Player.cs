using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isjumping = false;
    public GameObject animalobject;
    public static Player Instance;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //If the player is higher than -15 then isjumping is true
        if (this.gameObject.transform.position.y > -15f)
        {
            isjumping = true;
        }
        else
        {
            isjumping = false;
        }
    }
}
