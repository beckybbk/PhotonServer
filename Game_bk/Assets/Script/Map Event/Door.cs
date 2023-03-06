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
        GameEvent.Instance.onDoorEnter += OpenDoor;
        GameEvent.Instance.onDoorExit += CloseDoor;
    }

    public void OpenDoor(int openCount)
    {
        if (doorCount == openCount)
        {
            SoundManager.Instance.Sound(1);
            animator.SetBool("open", true); // trigger의 이름을 넣으면 됨. 
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
