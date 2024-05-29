using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingObserver : MonoBehaviour
{
    public GameObject observer;
    const int Width = 10;
    const int Height = 21;
    Observer[,] Observers = new Observer[Height, Width];

    void Start()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Observers[i, j] = observer.GetComponent<Observer>();
                Instantiate(Observers[i, j]);
                Observers[i, j].transform.position = new Vector3(-2.0942f + (0.465f * j), -4.285f + (0.465f * i), 0.0f);
            }
        }   
    }


    void Update()
    {
        for (int i = 0; i < Height; i++)
        {
            int check = 0;
            for (int j = 0; j < Width; j++)
            {
                if (Observers[i, j].IsOverrlaped)
                {
                    check++;
                }
            }

            if(check == Width) // Width is const 10
            {
                // 그 줄을 없애고 모든 블럭들을 한칸씩 내리기
            }
        }
    }
}
