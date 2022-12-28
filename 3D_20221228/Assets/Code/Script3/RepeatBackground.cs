using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public Vector3 startPos;
    public float repeatWidth;
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }


    void Update()
    {
        if (transform.position.x < startPos.x-42.5)
        {
            transform.position = startPos;
        }
    } 
}
