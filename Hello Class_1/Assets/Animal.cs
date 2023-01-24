using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    public string name;
    public string sound;

    // 울음소리를 재생하는 메서드
    public void PlaySound() 
    {
        Debug.Log(name + " : " + sound);
    }
}

