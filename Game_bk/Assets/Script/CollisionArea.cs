using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameEvent.instance.DoorTriggerEnter();

    }
}
