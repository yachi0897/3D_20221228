using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutline2 : MonoBehaviour
{
    private float outLineTop = 30;
    private float outLineButton = -20;
    private void Start()
    {
        
    }
    private void Update()
    {
        //超出一定範圍就刪除
        if (transform. position.x < -10)
        {
            Destroy(gameObject);
        }

        


    }
}
