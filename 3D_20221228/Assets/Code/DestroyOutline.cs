using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutline : MonoBehaviour
{
    private float outLineTop = 30;
    private float outLineButton = -20;
    private void Start()
    {
        
    }
    private void Update()
    {
        //(子彈)超出一 定範圍就刪除
        if (transform. position.z > 30)
        {
            Destroy(gameObject);
        }

        //(動物)超出一 定範圍就刪除
        else if (transform.position.z < -20)
        {
            Destroy(gameObject);
        }


    }
}
