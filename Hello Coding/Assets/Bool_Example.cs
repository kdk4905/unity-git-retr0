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
            Debug.Log("�ǹ� ������ �ް��ֽ��ϴ�.");
        }

        if (age < 13 || age > 70) 
        {
            Debug.Log("���� �� �� ���� �����Դϴ�.");
        }
    }
}
