using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLeftMoment : MonoBehaviour
{
    public float speed;
   
     BirdMoment birdMoment;
    // Start is called before the first frame update
    void Start()
    {
        birdMoment = GameObject.Find("Player").GetComponent<BirdMoment>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birdMoment.isTrue == false)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            if (transform.position.x <= -5.5f)
            {
                transform.position = new Vector2(2.9f, transform.position.y);
            }
            else if (transform.position.x <= -5.5f)
            {
                transform.position = new Vector2(6.3f, transform.position.y);
            }
            else if (transform.position.x <= -5.5f)
            {
                transform.position = new Vector2(2.9f, transform.position.y);
            }
        }
    }
}
