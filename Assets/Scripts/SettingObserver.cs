using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingObserver : MonoBehaviour
{
    public Observer Observer;
    const int Width = 10;
    const int Height = 24;
    Observer[,] Observers = new Observer[Height, Width];
    bool temp = false;


    void Start()
    {
        for (int i = 0; i < 24; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Observers[i, j] = Observer;
                Instantiate(Observers[i, j]);
                Observers[i, j].transform.position = new Vector3(-2.2025f + (0.4f * j), -4.4f + (0.4f * i), 0.0f);
            }
        }   
    }


    void Update()
    {
        for (int i = 0; i < 24; i++)
        {
            int check = 0;
            for (int j = 0; j < 10; j++)
            {
                if (Observers[i, j].IsOverrlaped)
                    check++;
            }

            if(check == Width) // Width is const 10
            {
                // 그 줄을 없애고 모든 블럭들을 한칸씩 내리기
            }
        }
    }
}
