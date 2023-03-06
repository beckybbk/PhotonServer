using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : SingleTon<SoundManager> 
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip [] soundEffect;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Sound(int count)
    {
        audioSource.PlayOneShot(soundEffect[count]); // PlayOneShot(오디오클립): 해당 오디오 사운드가 호출되는 함수.
    }
}
