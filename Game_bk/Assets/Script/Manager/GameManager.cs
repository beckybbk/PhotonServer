using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameButton gameButton;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            gameButton.buttonDisable(true);
            Time.timeScale = 0.0f;  
        }
    }
}
