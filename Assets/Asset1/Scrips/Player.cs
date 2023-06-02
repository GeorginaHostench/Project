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

        if (this.gameObject.transform.position.y > 3f)
        {
            isjumping = true;
        }

        if (this.gameObject.transform.position.x > 78 && this.gameObject.transform.position.x < 100
        && this.gameObject.transform.position.z > 21 && this.gameObject.transform.position.z > 28)
        {
            Debug.Log("ACTIVATORP");
    
        }
        if (this.gameObject.transform.position.x > 10 && this.gameObject.transform.position.x < 31
            && this.gameObject.transform.position.z > 21 && this.gameObject.transform.position.z > 28)
        {
            Debug.Log("ACTIVATORP");
           
        }

    }
}
