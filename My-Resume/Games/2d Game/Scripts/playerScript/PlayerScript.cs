using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float Speed;
    public float jump;
    Rigidbody2D Myrig;
    Animator animator;
    AudioSource audioSource;
    public AudioClip JumpSound1;
    public AudioClip JumpSound2;
    AudioClip JumpSound;
    public GameObject gameOver;
    public GameObject YouWon;
    int RanNum;
    public bool IsOnGround;
    public bool MovingRight, MovingLeft;
    bool Move = true;
    void Start()
    {
        Myrig = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (Move)
        {
            RanNum = Random.Range(1, 3);
            switch (RanNum)
            {
                case 1:
                    JumpSound = JumpSound1;
                    break;
                case 2:
                    JumpSound = JumpSound2;
                    break;
            }
            if (MovingRight)
            {
                transform.Translate(new Vector2(Speed * Time.deltaTime, 0));
                transform.localScale = new Vector3(0.69064f, transform.localScale.y, transform.localScale.z);
                animator.SetBool("Run", true);
            }
            if (MovingLeft)
            {
                transform.Translate(new Vector2(-Speed * Time.deltaTime, 0));
                transform.localScale = new Vector3(-0.69064f, transform.localScale.y, transform.localScale.z);
                animator.SetBool("Run", true);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector2(Speed * Time.deltaTime, 0));
                transform.localScale = new Vector3(0.69064f, transform.localScale.y, transform.localScale.z);
                animator.SetBool("Run", true);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector2(-Speed * Time.deltaTime, 0));
                transform.localScale = new Vector3(-0.69064f, transform.localScale.y, transform.localScale.z);
                animator.SetBool("Run", true);
            }
            if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && MovingLeft == false && MovingRight == false)
            {
                animator.SetBool("Run", false);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
            if (transform.position.y < -6)
            {
                gameOver.SetActive(true);
                Destroy(gameObject);
            }
        }
        else
        {
            animator.SetBool("Run", false);
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Win Flag")
        {
            Move = false;
            YouWon.SetActive(true);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            IsOnGround = true;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            IsOnGround = false;
        }
    }
    public void Jump()
    {
        if (IsOnGround == true)
        {
            Myrig.velocity = new Vector2(Myrig.velocity.x, jump);
            animator.Play("Jump");
            audioSource.PlayOneShot(JumpSound);
        }
    }
    public void Click_Down_RightBtn()
    {
        MovingRight = true;
    }
    public void Click_Up_RightBtn()
    {
        MovingRight = false;
    }
    public void Click_Down_LeftBtn()
    {
        MovingLeft = true;
    }
    public void Click_Up_LeftBtn()
    {
        MovingLeft = false;
    }
}
