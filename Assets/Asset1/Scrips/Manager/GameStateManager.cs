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
    // Start is called before the first frame update
    void Awake()
    {
        startTime=Time.time;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {   
        
        float elapsedTime = Time.time - startTime; // Calcula el tiempo transcurrido desde el inicio del juego
       
        int minutes = Mathf.FloorToInt(elapsedTime / 60); // Calcula los minutos
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        TotalTime = elapsedTime;

        //("Tiempo transcurrido: " + minutes.ToString("00") + ":" + seconds.ToString("00"));
        UIManager.Instance.UpdateOutOfTime();
        if (Input.GetKeyDown(KeyCode.Escape))
    {
        SceneManager.LoadScene("Menu");
    }
    }
    public void SavedAnimal()
    {
        Debug.Log("ACTUALUZAAAAAA");
        AnimalsSaved++;
        UIManager.Instance.UpdateAnimalSaved();
        if (AnimalsSaved == TotalAnimals) 
        {
            GameOver();
        }
    }
    private void GameOver()
    {
        UIManager.Instance.ShowGameOverWindow();
    }
}
