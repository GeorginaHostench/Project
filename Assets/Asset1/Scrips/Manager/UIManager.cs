using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance; 
    public Text AnimalsSavedText; 
    public Text OutOfTime; 
    public GameObject gameOverWindow; 

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateAnimalSaved() 
    {
        AnimalsSavedText.text = GameStateManager.Instance.AnimalsSaved.ToString();
    }
    public void UpdateOutOfTime() 
    {
        AnimalsSavedText.text = GameStateManager.Instance.TotalTime;
    }
    public void ShowGameOverWindow()
    {
        gameOverWindow.SetActive(true);
    }
}
