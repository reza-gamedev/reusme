using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public static int currentScore;
    public int highScore;
    public Text texthighScore;
    public Text textScore;
    void Start()
    {
        currentScore = 0;
        textScore.text = currentScore.ToString();
        highScore = PlayerPrefs.GetInt("highScore");
        texthighScore.text = highScore.ToString();
    }

    void Update()
    {
        if (currentScore > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", currentScore);
        }
        textScore.text = currentScore.ToString();
        texthighScore.text = highScore.ToString();
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void PauseMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void ResetScore()
    {
        PlayerPrefs.SetInt("highScore", 0);
        highScore = 0;
    }
}
