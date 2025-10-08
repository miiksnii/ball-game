using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject AboutCanvas;

    void Start()
    {
        AboutCanvas.SetActive(false);
    }

    public void MyFunction() // Correct
    {
        Debug.Log("Button clicked!");
    }

    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level");
    }
    
    public void AboutButton()
    {
        MainMenuCanvas.SetActive(false);
        AboutCanvas.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();        
    }
}
