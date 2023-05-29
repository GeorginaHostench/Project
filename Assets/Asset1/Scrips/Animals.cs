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
    public GameObject animal;

    public Material playerEmpty;
    public Material playerTrigger;

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
        if (UnityEngine.Random.Range(0, 100) < 1)
        {
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
        if (other.CompareTag("Hit"))
        {
            Bounce();
        }

        if (other.CompareTag("Drop"))
        {
            Revive();
        }

        if (other.CompareTag("Player"))
        {
            other.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerTrigger;

            switch (this.gameObject.tag)
            {

                case "Chicken":
                    SoundManager.Instance.PlayChicken();
                    animal = this.gameObject;
                    break;
                case "Duck":
                    SoundManager.Instance.PlayDuck();
                    animal = this.gameObject;
                    break;
                case "Taipan":
                    SoundManager.Instance.PlayTaipan();
                    animal = this.gameObject;
                    break;
                case "Muskrat":
                    SoundManager.Instance.PlayMuskrat();
                    animal = this.gameObject;
                    break;
                case "Gecko":
                    SoundManager.Instance.PlayGecko();
                    animal = this.gameObject;
                    break;
                case "Colobus":
                    SoundManager.Instance.PlayColobus();
                    animal = this.gameObject;
                    break;
                case "Pudu":
                    SoundManager.Instance.PlayPudu();
                    animal = this.gameObject;
                    break;
                case "Sparrow":
                    SoundManager.Instance.PlaySparrow();
                    animal = this.gameObject;
                    break;
                default:
                    break;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
        }
    }
    private void Bounce()
    {
        transform.Rotate(0, transform.rotation.y + UnityEngine.Random.Range(170, 190), 0);
       //Instantiate(this, new Vector3(10, 0, 0), new Quaternion(0, 0, 0, 0));
       //Destroy(this.gameObject);
    }
    private void Revive()
    {
        Instantiate(this, new Vector3(10, 0, 0), new Quaternion(0, 0, 0, 0));
        Destroy(this.gameObject);
    }
}
