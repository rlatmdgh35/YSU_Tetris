using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject[] blocks = new GameObject[7];
    GameObject[] piece = new GameObject[4];
    public GameObject block;
    public GameObject count;

    int otherCount = 0;

    Vector2[] pieceLoc = new Vector2[28] {
        new Vector2(-0.9f, 0f),
        new Vector2(-0f, 0f),
        new Vector2(0.9f, 0f),
        new Vector2(1.8f, 0f),
        new Vector2(0f, 0.9f),
        new Vector2(0.9f, 0f),
        new Vector2(1.8f, 0f),
        new Vector2(0.9f, 0f),
        new Vector2(0f, 0.9f),
        new Vector2(0.9f, 0.9f),
        new Vector2(0.9f, 0f),
        new Vector2(1.8f, 0f),
        new Vector2(1.8f, 0.9f),
        new Vector2(0.9f, 0f),
        new Vector2(0.9f, 0.9f),
        new Vector2(1.8f, 0.9f),
        new Vector2(0.9f, 0f),
        new Vector2(0.9f, 0.9f),
        new Vector2(1.8f, 0f),
        new Vector2(0f, 0f),
        new Vector2(0f, 0f),
        new Vector2(0f, 0f),
        new Vector2(0f, 0f),
        new Vector2(0f, 0f),
        new Vector2(0f, 0f),
        new Vector2(0f, 0f),
        new Vector2(0f, 0f),
        new Vector2(0f, 0f)
    };

    uint blockIndex = 0;

    void Log(object input)
    {
        Debug.Log(input);
    }

    void Start()
    {
        /*
        blockIndex = (uint)Random.Range(0, blocks.Length - 1);

        for (int i = 0; i < blocks.Length; i++)
        {
            if (blockIndex == i)
            {
                for (int j = 0; j < piece.Length; j++) // piece.Length -> 4
                {
                    piece[j] = blocks[blockIndex];

                    piece[j].transform.position = pieceLoc[i * piece.Length + j];
                }
            }
        }
        */


        

    }

    void Update()
    {
        if (otherCount == 3)
            return;

        Debug.Log(otherCount);

        count = Instantiate(count, block.transform);
        count.name = otherCount.ToString();
        otherCount++;
        for (int i = 0; i < 4; i++)
        {
            piece[i] = Instantiate(blocks[blockIndex], count.transform);
            piece[i].transform.position = pieceLoc[i];
        }
    }


}


/*
{
    public GameObject[] blocks = new GameObject[7];
    GameObject CurrentBlock;
    int CurrnetIndex;
    
    bool SpawnBlock = true;
    bool IsArrivedBottom = false;
    float delta;

    void Update()
    {
        delta += Time.deltaTime;

        if (SpawnBlock)
        {
            SpawnBlock = false;

            Spawn();
        }
        if(IsArrivedBottom && delta >= 1)
        {
            IsArrivedBottom = false;
            Invoke("DownBlock", 1);
        }
    }
    
    void DownBlock()
    {

        CurrentBlock.transform.position += new Vector3(0, -0.465f, 0);
    
    }
    
    Vector2[] CheckObserver(int BlockIndex, float Rotation)
    {
        uint length = 1;

        if((Rotation % 90) % 2 == 0)
        {
            if(BlockIndex == 0)
                length = 4;
            else if(BlockIndex == 2)
                length = 2;
            else
                length = 3;
        }
        else // (Rotation % 90) % 2 -> 1
        {
            if(BlockIndex == 0)
                length = 1;
            else
                length = 2;
        }

        Vector2[] UnderIndex = new Vector2[length];
        
        if(Rotation == 0)
        {
            if(BlockIndex == 0)
            {
                for(int i = 0; i < length; i++)
                    UnderIndex[i] = new Vector2(i * 0.465f + -0.6975f, -0.465f);
            }
            else if(BlockIndex == 1 || BlockIndex == 3 || BlockIndex == 5)
            {
                for(int i = 0; i < length; i++)
                    UnderIndex[i] = new Vector2((i-1) * 0.465f, -0.2325f);
            }
            else if(BlockIndex == 2)
            {
                for(int i = 0; i < length; i++)
                    UnderIndex[i] = new Vector2(i * 0.465f + -0.2325f, -0.465f);
            }
            else if(BlockIndex == 4)
            {
                UnderIndex[0] = new Vector2(-0.465f, -0.6975f);
                UnderIndex[1] = new Vector2(0, -0.6975f);
                UnderIndex[2] = new Vector2(0.465f, -0.2325f);
            }
            else if(BlockIndex == 6)
            {
                UnderIndex[0] = new Vector2(0.465f, -0.2325f);
                UnderIndex[1] = new Vector2(0, -0.6975f);
                UnderIndex[2] = new Vector2(-0.465f, -0.6975f);
            }
        }
        else if(Rotation == 90)
        {
            if(BlockIndex == 0)
                UnderIndex[0] = new Vector2(0, -1.1625f);
            else if(BlockIndex == 1)
            {
                for(int i = 0; i < length; i++)
                    UnderIndex[i] = new Vector2(i * 0.465f - 0.2325f, -0.93f);
            }
            
        }
        //else if(Rotation == 180)
        
        //else if(Rotation == 270)
        
        else
            Debug.Log("Rotation is wrong");

        return UnderIndex;
    }



    void Spawn()
    {
        int CurrnetIndex = Random.Range(0, blocks.Length);
        CurrentBlock = Instantiate(blocks[1]);
        if(CurrnetIndex != 0 | CurrnetIndex != 2)
            CurrentBlock.transform.position = new Vector2(-0.2342f, 4.3175f);
        else
            CurrentBlock.transform.position = new Vector2(-0.2342f, 4.3175f);
    }
}
*/