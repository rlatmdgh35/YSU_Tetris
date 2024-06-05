using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingObserver : MonoBehaviour
{
    public GameObject observer;

    Observer[,] Observers = new Observer[Height, Width];
    const int Width = 10;
    const int Height = 21;

    void Start()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Observers[i, j] = observer.GetComponent<Observer>();
                Instantiate(Observers[i, j], gameObject.transform);
                Observers[i, j].transform.position = new Vector3(-4.05f + (0.9f * j), -8.25f + (0.9f * i), 0.0f);
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
                    check++;
            }

            if(check == Width) // Width is const 10
            {
                // 그 줄을 없애고 모든 블럭들을 한칸씩 내리기
            }
        }
    }
}
