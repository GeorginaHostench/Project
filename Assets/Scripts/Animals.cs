using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public float runSpeed;
    private bool hit;
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
        Destroy(gameObject);
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
            other.gameObject.GetComponent<Player>().animalobject = this.gameObject;
           
            switch (this.gameObject.tag)
            {

                case "Chicken":
                    SoundManager.Instance.PlayChicken();
                    animal = this.gameObject;
                    break;
                case "Chicken2":
                    SoundManager.Instance.PlayChicken();
                    animal = this.gameObject;
                    break;
                case "Duck":
                    SoundManager.Instance.PlayDuck();
                    animal = this.gameObject;
                    break;
                case "Duck2":
                    SoundManager.Instance.PlayDuck();
                    animal = this.gameObject;
                    break;
                case "Taipan":
                    SoundManager.Instance.PlayTaipan();
                    animal = this.gameObject;
                    break;
                case "Taipan2":
                    SoundManager.Instance.PlayTaipan();
                    animal = this.gameObject;
                    break;
                case "Muskrat":
                    SoundManager.Instance.PlayMuskrat();
                    animal = this.gameObject;
                    break;
                case "Muskrat2":
                    SoundManager.Instance.PlayMuskrat();
                    animal = this.gameObject;
                    break;
                case "Gecko":
                    SoundManager.Instance.PlayGecko();
                    animal = this.gameObject;
                    break;
                case "Gecko2":
                    SoundManager.Instance.PlayGecko();
                    animal = this.gameObject;
                    break;
                case "Colobus":
                    SoundManager.Instance.PlayColobus();
                    animal = this.gameObject;
                    break;
                case "Colobus2":
                    SoundManager.Instance.PlayColobus();
                    animal = this.gameObject;
                    break;
                case "Pudu":
                    SoundManager.Instance.PlayPudu();
                    animal = this.gameObject;
                    break;
                case "Pudu2":
                    SoundManager.Instance.PlayPudu();
                    animal = this.gameObject;
                    break;
                case "Sparrow":
                    SoundManager.Instance.PlaySparrow();
                    animal = this.gameObject;
                    break;
                case "Sparrow2":
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
    }

    private void Revive()
    {
        List<Vector3> points = new List<Vector3>();
        Vector3 vector1 = new Vector3(2, -20, 2);
        Vector3 vector3 = new Vector3(98, -20, 98);
        Vector3 vector4 = new Vector3(98, -20, 2);
        points.Add(vector1);
        points.Add(vector3);
        points.Add(vector4);

        Instantiate(this, points[UnityEngine.Random.Range(0, 3)], new Quaternion(0, 0, 0, 0));
        Destroy(this.gameObject);
    }

}

