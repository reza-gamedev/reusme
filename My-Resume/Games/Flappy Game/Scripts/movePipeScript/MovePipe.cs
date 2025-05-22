using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.right * -3 * Time.deltaTime;
        Destroy(gameObject, 10);
    }
}
