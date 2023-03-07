using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] float mouseSpeed = 5.0f;

    private float mouseY;

    

   
    void Update()
    {
        mouseY += Input.GetAxisRaw("Mouse Y") * mouseSpeed*Time.deltaTime;

        mouseY = Mathf.Clamp(mouseY, -55.0f, 35.0f);  // mouseY�� �ּҰ�, �ִ밪 ���� 

        transform.localEulerAngles = new Vector3(-mouseY,0, 0);

    }
}
