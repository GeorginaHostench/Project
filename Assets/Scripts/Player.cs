using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isjumping = false;
    public GameObject animalobject;
    public static Player Instance;

    public Material playerisjumping;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (this.gameObject.transform.position.y > -15f)
        {
            isjumping = true;
            this.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerisjumping;
        }
        
    }


}