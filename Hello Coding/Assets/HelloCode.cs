using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        // Hello World!�� �ֿܼ� ���
        //Debug.Log("Hello World!");

        // ĳ������ �������� ������ �����
        //string characterName = "���";
        //char bloodType = 'A';
        //int age = 17;
        //float height = 168.3f;
        //bool isFemale = true;

        //// ������ ������ �ֿܼ� ���
        //Debug.Log("ĳ���� �̸� : " + characterName);
        //Debug.Log("������ : " + bloodType);
        //Debug.Log("���� : " + age);
        //Debug.Log("Ű : " + height);
        //Debug.Log("�����ΰ�? : " + isFemale);

        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)���� (5,6)������ �Ÿ� : " + distance);
    }

    float GetDistance(float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;
        
        float distance = (width * width) + (height * height);
        distance = Mathf.Sqrt(distance);

        return distance;
    }
}
