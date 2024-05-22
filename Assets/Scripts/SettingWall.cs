using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingWall : MonoBehaviour
{
    public GameObject Wall;

    void Start()
    {
        // LeftSide
        for (int i = 0; i < 22; i++)
        {
            Instantiate(Wall);
            Wall.transform.position = new Vector3(-2.5562f, -4.75f + (0.465f * i), 1.0f);
        }

        // Buttom
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Wall);
            Wall.transform.position = new Vector3(-2.0942f + (0.465f * i), -4.75f, 1.0f);
        }

        // RightSide
        for (int i = 0; i < 22; i++)
        {
            Instantiate(Wall);
            Wall.transform.position = new Vector3(2.5562f, -4.75f + (0.465f * i), 1.0f);

        }
    }
}
