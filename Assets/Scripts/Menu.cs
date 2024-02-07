using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button start;
    public Button quit;

    void Start()
    {
        start.onClick.AddListener(() => StartGame());

    }

    public void StartGame() 
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}
