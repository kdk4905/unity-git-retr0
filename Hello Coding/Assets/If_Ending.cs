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
            // love가 90보다 큰 경우
            Debug.Log("트루엔딩: 히로인과 결혼했다!");
        }
        else if (love > 70)
        {
            //love가 90보다 작거나 같고, 70보다 큰 경우
            Debug.Log("굿엔딩: 히로인과 사귀게 되었다!");
        }
        else
        {
            // love가 70보다 작거나 같은 경우
            Debug.Log("배드엔딩: 히로인에게 차였다.");
        }
    }

}
