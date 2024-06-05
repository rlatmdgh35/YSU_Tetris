using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingWall : MonoBehaviour
{
    public GameObject wall;

    void Start()
    {
        // LeftSide
        for (int i = 0; i < 22; i++)
        {
            Instantiate(wall, gameObject.transform);
            wall.transform.position = new Vector3(-4.95f, -9.15f + (0.9f * i), 0f);
        }

        // Buttom
        for (int i = 0; i < 10; i++) // Instantiate 10 blocks
        {
            Instantiate(wall, gameObject.transform);
            wall.transform.position = new Vector3(-4.05f + (0.9f * i), -9.15f, 0f);
        }

        // RightSide
        for (int i = 0; i < 22; i++)
        {
            Instantiate(wall, gameObject.transform);
            wall.transform.position = new Vector3(4.95f, -9.15f + (0.9f * i), 0f);

        }
    }
}
