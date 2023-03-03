using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : SingleTon<SoundManager> 
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip [] soundEffect;

    public void Sound()
    {
        Debug.Log("사운드 호출");
    }
}
