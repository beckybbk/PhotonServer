using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionArea : MonoBehaviour
{
    [SerializeField] int count;
    private void OnTriggerEnter(Collider other)
    {
        GameEvent.Instance.DoorTriggerEnter(count);

    }

    private void OnTriggerExit(Collider other)
    {
        GameEvent.Instance.DoorTriggerExit(count);
    }
}
