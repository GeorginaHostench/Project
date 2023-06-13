using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance; 

    [HideInInspector]
    public int AnimalsSaved;
    public int TotalAnimals;
    public float TotalTime;
    public float startTime;
    public float EndTime;
    private bool GameOv=false;
    // Start is called before the first frame update
    void Awake()
    {
        startTime = Time.time;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOv == false){
            float elapsedTime = Time.time - startTime; // Calcula el tiempo transcurrido desde el inicio del juego
            TotalTime = elapsedTime;
            //Si el tiempo transcurrido es mayor al tiempo final, acaba el juego
            if (EndTime < TotalTime)
            {
                GameOver();
            }
        }
    }

    //actualiza el numero de animales salvados 
    public void SavedAnimal()
    {
        AnimalsSaved++;
        UIManager.Instance.UpdateAnimalSaved();
        //Si el counter es igual al total de animales, va a la window de gameover
        if (AnimalsSaved == TotalAnimals)
        {
            GameOver();
        }
    }

    //El juego acaba, va a la GameOverWindow i se activa la DoActionAfterDelay()
    private void GameOver()
    {
        SoundManager.Instance.PlayBoat();
        GameOv =true;
        UIManager.Instance.ShowGameOverWindow();
        StartCoroutine(DoActionAfterDelay());
        

    }
    //Corutina 
    IEnumerator DoActionAfterDelay()
    {
        //Cuando acaba el juego, espera 10s i carga la escena de menu
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Menu");
        GameOv=false;
        
    }
}
