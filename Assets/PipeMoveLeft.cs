using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveLeft : MonoBehaviour
{
    public float speed;
    public GameObject player;
    // Start is called before the first frame update
    BirdMoment birdMoment;
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
            if (transform.position.x <= -4f)
            {
                Destroy(gameObject);
            }
        }
    }
}
