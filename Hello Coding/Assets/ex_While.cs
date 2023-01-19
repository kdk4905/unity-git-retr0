using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_While : MonoBehaviour
{
    void Start()
    {
        int i = 0;

        while (i < 10)
        {
            Debug.Log(i + " 번째 루프입니다.");
            i++;
        }
    }
}
