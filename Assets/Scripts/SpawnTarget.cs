using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{

    public GameObject blueTarget;
    public GameObject redTarget;
    public Transform targets;

    private Vector3 spawnPosition;
    private float time = 1.5f;
    private float verticalExtent;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, time);
        verticalExtent = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        spawnPosition = new Vector3(Random.Range(-1f, 1f), 4.5f);
        if (Random.Range(0, 2) == 1)
        {
            GameObject rb = Instantiate(blueTarget, spawnPosition, Quaternion.identity);
            rb.transform.SetParent(targets);
            //Destroy(rb, 2.5f);
            /*if(rb.transform.position.y > verticalExtent)
            {
                Destroy(rb.gameObject);
                Debug.Log("GameOver!");
            }*/
        }
        else
        {
            GameObject rb = Instantiate(redTarget, spawnPosition, Quaternion.identity);
            rb.transform.SetParent(targets);
            //Destroy(rb, 2.5f);
            /*if (rb.transform.position.y > verticalExtent)
            {
                Destroy(rb.gameObject);
                Debug.Log("GameOver!");
            }*/
        }
    }
}
