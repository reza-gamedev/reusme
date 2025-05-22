using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float minY, maxY;
    float Timer;
    public float maxTime;
    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > maxTime)
        {
            spawnPipe();
            Timer = 0;
        }
    }
    public void spawnPipe()
    {
        float randomY = Random.Range(minY, maxY);
        GameObject newPipe = Instantiate(Pipe);
        newPipe.transform.position = new Vector2(transform.position.x, randomY);
    }
}
