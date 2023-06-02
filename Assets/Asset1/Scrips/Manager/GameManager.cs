using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject Chiken;
    public GameObject Chiken2;
    public GameObject Duck;
    public GameObject Duck2;
    public GameObject Taipan;
    public GameObject Taipan2;
    public GameObject Geko;
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
        // Check if the player's Y position is greater than 3
         if (playerObject1.isjumping && playerObject2.isjumping)
         {
            if (playerObject1.animalobject != null && playerObject2.animalobject != null)
            {
                switch (playerObject1.animalobject.tag){

                    case "Chiken":
                        if(playerObject2.animalobject.tag == "Chiken2"){
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
                        }
                        break;
                    case "Chiken2":
                        if (playerObject2.animalobject.tag == "Chiken"){
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
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
                        }
                        break;
                    case "Geko":
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
                        if (playerObject2.animalobject.tag == "Geko")
                        {
                            Destroy(playerObject1.animalobject);
                            Destroy(playerObject2.animalobject);
                            playerObject1.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            playerObject2.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = playerEmpty;
                            GameStateManager.Instance.SavedAnimal();
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
                        }
                        break;

                }
                
            }
            
         }

    }


    
}
