using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_PlayerIsDead : MonoBehaviour
{
    void Start()
    {
        bool isDead = true;
        int Hp = 100;

        while (isDead)
        {
            Debug.Log("현재 플레이어의 체력 : " + Hp);
            Debug.Log("출혈상태중 입니다.");
            Hp -= 33;

            if (Hp <= 0)
            {
                isDead = false;
                Debug.Log("플레이가 사망하였습니다.");
            }
        }
    }
}
