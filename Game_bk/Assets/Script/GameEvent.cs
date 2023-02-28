using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public static GameEvent instance;
    public event Action onDoorEnter;


    private void Awake()
    {
        
        if(instance==null)
        {
            instance = this;

        }
    }

    public void DoorTriggerEnter()
    {
        if(onDoorEnter != null)
        {
            onDoorEnter();

        }
    }
        
}
