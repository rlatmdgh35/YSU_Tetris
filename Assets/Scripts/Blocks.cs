using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject[] blocks = new GameObject[7];
    bool SpawnBlock = true;
    // bool IsDown = false;

    void Update()
    {
        if (SpawnBlock)
        {
            SpawnBlock = false;

            Spawn();
        }
    }
    //    if(!IsDown)
    //    {
    //        IsDown = true;
    //        Invoke("DownBlock", 1);
    //    }
    //}
    //
    //void DownBlock()
    //{
    //    while(true)
    //    {
    //    }
    //
    //    IsDown = false;
    //}

    void Spawn()
    {
        int rand = Random.Range(0, blocks.Length);
        GameObject block = Instantiate(blocks[1]);
        block.transform.position = new Vector2(0, 4.75f);
    }
}