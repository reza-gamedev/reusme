using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetGame : MonoBehaviour
{
    public float ResetPosition = -50f;
    void Update()
    {
        if (transform.position.y < ResetPosition)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
