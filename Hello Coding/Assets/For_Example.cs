using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Example : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + " 번째 순번입니다.");
        }       
    }

}
