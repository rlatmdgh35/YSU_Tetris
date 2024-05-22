using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingWall : MonoBehaviour
{
    public GameObject Wall;

    void Start()
    {
        // LeftSide
        for(int i = 0; i < 25; i++)
        {
            Instantiate(Wall);
            Wall.transform.position = new Vector3(-2.6025f, -4.75f + (0.4f * i), 1.0f);
        }

        // Buttom
        for(int i = 0; i < 12; i++)
        {
            Instantiate(Wall);
            Wall.transform.position = new Vector3(-2.2025f + (0.4f * i), -4.75f, 1.0f);
        }

        // RightSide
        for(int i = 0; i < 25; i++)
        {
            Instantiate(Wall);
            Wall.transform.position = new Vector3(2.6025f, -4.75f + (0.4f * i), 1.0f);

        }
    }

    void Update()
    {
        
    }
}
