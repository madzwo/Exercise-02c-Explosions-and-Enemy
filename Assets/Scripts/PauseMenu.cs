using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public static PauseMenu instance;

    public bool isPaused;

    // Start is called before the first frame update
    public void Awake()
    {
        if(instance == null || instance != this)
        {
            instance = this;
        }
        
    }

    public void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseMenu.activeSelf)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame();
            }
        }    
    }

    private void PauseGame()
    {
        isPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void QuitGame() 
    {
        isPaused = false;
        SceneManager.LoadScene(0);
    }

   
}
