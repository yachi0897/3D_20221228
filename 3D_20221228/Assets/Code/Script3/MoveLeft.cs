using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed = 30;
    public PlayerController3 PC_Script;//宣告一個和PlayerController3一樣型態的變數:
    void Start()
    {
        PC_Script = GameObject.Find("Player").GetComponent<PlayerController3>();
    }

    void Update()
    {
        if(PC_Script.gameOver==false)
        transform.Translate(Vector3.left *speed*Time.deltaTime);
    }
}
