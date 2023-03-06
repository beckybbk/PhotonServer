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
        audioSource.PlayOneShot(soundEffect[count]); // PlayOneShot(�����Ŭ��): �ش� ����� ���尡 ȣ��Ǵ� �Լ�.
    }
}
