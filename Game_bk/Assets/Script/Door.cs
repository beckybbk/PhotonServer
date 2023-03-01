using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;

    [SerializeField] int doorCount;

    void Start()
    {
        animator= GetComponent<Animator>();
        GameEvent.instance.onDoorEnter += OpenDoor;
        GameEvent.instance.onDoorExit += CloseDoor;
    }

    public void OpenDoor(int openCount)
    {
        if (doorCount == openCount)
        {
            animator.SetBool("open", true);
        }
    }

    public void CloseDoor(int closeCount) 
    {
        if (doorCount == closeCount)
        {
            animator.SetBool("open", false);
        }
    }
}
