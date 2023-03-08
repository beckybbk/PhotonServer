using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : SingleTon<SoundManager> 
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip [] soundEffect;

    private void Awake()
    {
        var obj = FindObjectsOfType<SoundManager>();

        if(obj.Length !=1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        // if(obj.)
    }

  
    public void Sound(int count)
    {
        audioSource.PlayOneShot(soundEffect[count]); // PlayOneShot(�����Ŭ��): �ش� ����� ���尡 ȣ��Ǵ� �Լ�.
    }
}
