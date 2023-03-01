using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class Player : MonoBehaviour
{
    float mouseX;
    [SerializeField] float speed = 2.5f;
    [SerializeField] float mouseSpeed = 1.0f;


    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x,0,z);
        transform.Translate(direction.normalized * speed * Time.deltaTime);

        mouseX += Input.GetAxisRaw("Mouse X") * mouseSpeed;
        transform.eulerAngles=new Vector3(0,mouseX,0);
    }
}
