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
            Debug.Log("���� �÷��̾��� ü�� : " + Hp);
            Debug.Log("���������� �Դϴ�.");
            Hp -= 33;

            if (Hp <= 0)
            {
                isDead = false;
                Debug.Log("�÷��̰� ����Ͽ����ϴ�.");
            }
        }
    }
}
