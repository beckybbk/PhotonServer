using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission : MonoBehaviour
{
    string content = "CountDown";
    int count = 0;
    
    void Start()
    {
        // 대문자가 몇 개 있는지 알고리즘을 짜보세요. 
        for(int i =0; i<content.Length; i++)
        {
            if (content[i] >='A' && content[i] <='Z')
            {
                count++;
            }

        }
        
        Debug.Log(count);
    }

    
}
