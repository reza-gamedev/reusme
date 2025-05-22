using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control_Sctipt : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void ResetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackToMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
