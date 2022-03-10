using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    // Start is called before the first frame update
    public float yMin;
    public float yMax;
    public float time;
    BirdMoment birdMoment;
    void Start()
    {
        birdMoment = GameObject.Find("Player").GetComponent<BirdMoment>();
        
        
            InvokeRepeating("Spawner", 2f, 2f);
        


    }

    // Update is called once per frame
    void Update()
    {
    }
    
   private void Spawner()
    {
        if (birdMoment.isTrue == false)
        {
            GameObject newPipe = Instantiate(pipePrefab);

            newPipe.transform.position = new Vector2(transform.position.x, UnityEngine.Random.Range(yMin, yMax));

        }
     }
}
