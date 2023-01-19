using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_Array2 : MonoBehaviour
{
    void Start()
    {
        int[] students = new int[5];
        int Myindex = 0;
        for (int score = 100; score >= 60; score -= 10)
        {
            students[Myindex] = score;
            Myindex++;
        }

        for (int i = 0; i < students.Length; i++)
        {
            Debug.Log(i +"번째 학생의 성적은 " + students[i] + "점 입니다.");
        }
    }
}
