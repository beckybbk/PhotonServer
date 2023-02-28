using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;
        
    void Start()
    {
        animator= GetComponent<Animator>();
        GameEvent.instance.onDoorEnter += OpenDoor;

    }

    public void OpenDoor()
    {
        animator.Play("Open Animation");
    }
}
