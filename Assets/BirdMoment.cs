using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdMoment : MonoBehaviour
{
    Rigidbody2D rb;
    public float birdSpeed;
   public  int maxAngle, minAngle, angle;
    public float score;
    public Text scoreText;
   // bool isTrue = false;
    public Text gameOver;
    // Start is called before the first frame update\

    private void Awake()
    {
        
        gameObject.AddComponent<Rigidbody2D>();
        
        


    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
        rb.freezeRotation = true;

    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BirdFlagJump();
        }
        BirdRotation();
    }

    private void BirdRotation()
    {
        if (rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }
        }
        else if (rb.velocity.y < 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle - 4;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void BirdFlagJump()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(rb.velocity.x, birdSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<CapsuleCollider2D>())
        {
            score = score + 10;
            scoreText.text = score.ToString();
        }
           
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="pipe")
        {
            Debug.Log("gameover");

            gameOver.GetComponent<Text>().enabled = true;

           
        }
    }
}
