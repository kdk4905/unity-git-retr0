using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bool_Example : MonoBehaviour
{
    void Start()
    {
        int age = 11;
        if (age > 7 && age <18)
        {
            Debug.Log("의무 교육을 받고있습니다.");
        }

        if (age < 13 || age > 70) 
        {
            Debug.Log("일을 할 수 없는 나이입니다.");
        }
    }
}
