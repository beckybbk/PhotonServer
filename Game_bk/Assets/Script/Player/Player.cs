using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class Player : MonoBehaviour
{
    float mouseX;
    [SerializeField] float speed = 2.5f;
    [SerializeField] float mouseSpeed = 1.0f;

    private CharacterController characterController;
    

    private void Start()
    {
        Cursor.visible= false;
        Cursor.lockState = CursorLockMode.Locked;

        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x,0,z);

        
        characterController.Move(transform.TransformDirection(direction.normalized) * speed*Time.deltaTime);  // 캐릭터 컨트롤러 사용시 (벽 통과 안하도록) 
        // transform.Translate(direction.normalized * speed * Time.deltaTime);

        mouseX += Input.GetAxisRaw("Mouse X") * mouseSpeed;
        transform.eulerAngles=new Vector3(0,mouseX,0);
    }
}
