using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Ending : MonoBehaviour
{
    void Start()
    {
        int love = 80;

        if (love > 90)
        {
            // love�� 90���� ū ���
            Debug.Log("Ʈ�翣��: �����ΰ� ��ȥ�ߴ�!");
        }
        else if (love > 70)
        {
            //love�� 90���� �۰ų� ����, 70���� ū ���
            Debug.Log("�¿���: �����ΰ� ��Ͱ� �Ǿ���!");
        }
        else
        {
            // love�� 70���� �۰ų� ���� ���
            Debug.Log("��忣��: �����ο��� ������.");
        }
    }

}
