using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLeftMoment : MonoBehaviour
{
    public float speed;
    public GameObject pipePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector2(transform.position.x -speed * Time.deltaTime,transform.position.y);
        if(transform.position.x<=-5.5f)
        {
            transform.position = new Vector2(2.9f, transform.position.y);
        }
      else  if (transform.position.x <= -5.5f)
        {
            transform.position = new Vector2(6.3f, transform.position.y);
        }
      else  if (transform.position.x <= -5.5f)
        {
            transform.position = new Vector2(2.9f, transform.position.y);
        }
    }
}
