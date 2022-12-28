using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // public float radomRangeX = 20;
    public float spawanZ = 20;
    void Start()
    {
        //重複呼叫某個函數(名字,遊戲啟動延遲時間)
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    void Update()
    {
     if(Input.GetMouseButtonDown(0))
      {
           SpawnRandomAnimal();
       }
    }

    void SpawnRandomAnimal()
    {
       
        int a_Index = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(10, -14), 0, spawanZ);
        Instantiate(animalPrefabs[a_Index], spawnPos, animalPrefabs[a_Index].transform.rotation);
        print("動物來囉");


    }


}
