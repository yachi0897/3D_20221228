using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float H_Input;
    public float speed = 20;

    void Start()
    {

    }

    void Update()
    {
        H_Input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * H_Input * Time.deltaTime * speed);

        if (transform.position.x >= 18)
        {
            transform.position = new Vector3(18, transform.position.y, transform.position.z);
        }else if (transform.position.x <= -18)
        {
            transform.position = new Vector3(-18, transform.position.y, transform.position.z);
        }
    }
}
