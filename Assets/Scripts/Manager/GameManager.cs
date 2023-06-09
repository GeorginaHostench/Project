using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject Chicken;
    public GameObject Chicken2;
    public GameObject Duck;
    public GameObject Duck2;
    public GameObject Taipan;
    public GameObject Taipan2;
    public GameObject Gecko;
    public GameObject Geko2;
    public GameObject Colobus;
    public GameObject Colobus2;
    public GameObject Muskrat;
    public GameObject Muskrat2;
    public GameObject Pudu;
    public GameObject Pudu2;
    public GameObject Sparrow;
    public GameObject Sparrow2;
    public Player playerObject1;
    public Player playerObject2;
    public Material playerEmpty;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        salto();
    }

    private void salto()
    {
        // Check if the players are jumping
        if (playerObject1.isjumping && playerObject2.isjumping)
        {
            //Check if the two animals are not null 
            if (playerObject1.animalobject != null && playerObject2.animalobject != null)
            {
                //If player takes an animal with a tag
                switch (playerObject1.animalobject.tag)
                {
                    case "Chicken":
                        //the other animal is take by the other player
                        if (playerObject2.animalobject.tag == "Chicken2")
                        {
                            //destroy the two animals, the two player areas return to red, actualized the counter and play a check sound
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    // The same case as the other but, the other way around
                    case "Chicken2":
                        if (playerObject2.animalobject.tag == "Chicken")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Duck":
                        if (playerObject2.animalobject.tag == "Duck2")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Duck2":
                        if (playerObject2.animalobject.tag == "Duck")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Taipan":
                        if (playerObject2.animalobject.tag == "Taipan2")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Taipan2":
                        if (playerObject2.animalobject.tag == "Taipan")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Gecko":
                        if (playerObject2.animalobject.tag == "Geko2")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                        }
                        break;
                    case "Geko2":
                        if (playerObject2.animalobject.tag == "Gecko")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Colobus":
                        if (playerObject2.animalobject.tag == "Colobus2")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Colobus2":
                        if (playerObject2.animalobject.tag == "Colobus")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Muskrat":
                        if (playerObject2.animalobject.tag == "Muskrat2")
                        {
                            Debug.Log(" RATA");
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                        }
                        break;
                    case "Muskrat2":
                        if (playerObject2.animalobject.tag == "Muskrat")
                        {
                            Debug.Log(" RATA");
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();

                        }
                        break;
                    case "Pudu":
                        if (playerObject2.animalobject.tag == "Pudu2")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Pudu2":
                        if (playerObject2.animalobject.tag == "Pudu")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Sparrow":
                        if (playerObject2.animalobject.tag == "Sparrow2")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;
                    case "Sparrow2":
                        if (playerObject2.animalobject.tag == "Sparrow")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                            SoundManager.Instance.PlayCheck();
                        }
                        break;

                }

            }

        }

    }

}
