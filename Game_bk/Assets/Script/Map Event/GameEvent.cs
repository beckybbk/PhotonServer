using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : SingleTon<GameEvent>
{
    public static GameEvent instance;
    
    public event Action<int> onDoorEnter;  
    public event Action<int> onDoorExit;


    private void Awake()
    {

        DontDestroyOnLoad(this.gameObject);


        if (instance == null)
        {
            instance = this;

        }

        //var obj = FindObjectsOfType<GameEvent>();

        //if (obj.Length != 1)
        //{
        //    Destroy(gameObject);
        //}
    }

    public void DoorTriggerEnter(int enterCount)
    {
        if(onDoorEnter != null)
        {
            onDoorEnter(enterCount);

        }
    }

    public void DoorTriggerExit(int exitCount)
    {
        if (onDoorExit != null)
        {
            onDoorExit(exitCount);

        }
    }


}
