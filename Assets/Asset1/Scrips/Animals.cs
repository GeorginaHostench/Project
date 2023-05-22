using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animals : MonoBehaviour
{
    public float runSpeed;
    public float gotHayDestroyDelay;
    private bool hit;
    public float dropDestroyDelay; 
    private Collider myCollider;  
    private Rigidbody myRigidbody; 


    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
        if (UnityEngine.Random.Range(0, 100) < 1) {
            transform.Rotate(0, transform.rotation.y + UnityEngine.Random.Range(0, 45), 0);

        }
        
    }
    private void Hit()
    {
        hit = true; 
        runSpeed = 0; 
        Destroy(gameObject, gotHayDestroyDelay); 
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Hit") ) 
        {
            Bounce();  
        }
    }
    private void Bounce()
    {
        transform.Rotate(0,transform.rotation.y + UnityEngine.Random.Range(120, 240), 0);

    }
}
