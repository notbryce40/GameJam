using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject poster1;
    //public Sprite poster2;
    public float spawnRate = 4;
    private float timer = 0;
    public float heightOffset = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPoster();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPoster();
            timer = 0;
        }
    }


    void SpawnPoster()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(poster1, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        //Instantiate(poster2, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
