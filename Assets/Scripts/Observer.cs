using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public bool IsOverrlaped = false;

    void OnCollisionEnter2D(Collision2D inColl)
    {
        IsOverrlaped = true;
    }

    void OnCollisionExit2D(Collision2D inColl)
    {
        IsOverrlaped = false;
    }
}
