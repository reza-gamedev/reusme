using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jump;

    public Animator jumpAnimation;
    public Animator death;

    public bool gameOver = false;

    public GameObject GameOverScene;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping();
        }
        if(gameOver == true)
        {
            GameOverScene.SetActive(true);
        }
    }
    public void jumping()
    {
        if (gameOver == false)
        {
            rigid.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            jumpAnimation.Play("jumpAnimation");
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            death.Play("deathAnimation");
            gameOver = true;
        }
    }
}
