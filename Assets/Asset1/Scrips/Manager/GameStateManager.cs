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
    // Start is called before the first frame update
    void Awake()
    {
        startTime = Time.time;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

        float elapsedTime = Time.time - startTime; // Calcula el tiempo transcurrido desde el inicio del juego
        TotalTime = elapsedTime;

        if (EndTime < TotalTime)
        {
            GameOver();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void SavedAnimal()
    {
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
        Time.timeScale = 0f;
    }
}
