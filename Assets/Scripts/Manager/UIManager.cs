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
        gameOverWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int minutes = Mathf.FloorToInt(GameStateManager.Instance.TotalTime / 60); // Calcula los minutos
        int seconds = Mathf.FloorToInt(GameStateManager.Instance.TotalTime % 60);
        OutOfTime.text = (minutes.ToString("00") + ":" + seconds.ToString("00"));
    }

    public void UpdateAnimalSaved()
    {
        AnimalsSavedText.text = GameStateManager.Instance.AnimalsSaved.ToString();
    }

    public void ShowGameOverWindow()
    {
        gameOverWindow.SetActive(true);
    }
}
