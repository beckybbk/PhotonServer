using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameButton : CreateButton
{
    private List<GameObject> button = new List<GameObject>();
    void Start()
    {
     
        Create(3, "Button (Legacy)");

        button[0].GetComponent<Button>().onClick.AddListener(Function1);
        button[1].GetComponent<Button>().onClick.AddListener(Function2);
        button[2].GetComponent<Button>().onClick.AddListener(Function3);

    }



    public override void Create(int createCount, string buttonName)
    {
        for (int i = 0; i < createCount; i++)
        {
            GameObject buttonPrefab = Instantiate(Resources.Load<GameObject>(buttonName));
            button.Add(buttonPrefab);
            button[i].transform.SetParent(parentPosition);
                        
        }

        buttonDisable(false);
    }
    public void buttonDisable(bool condition)
    {
        for(int i=0; i < 3; i++)
        {
            button[i].gameObject.SetActive(condition);
        }
    }
    public override void Function1()
    {
        buttonDisable(false);

        Cursor.visible = false;
        Cursor.lockState=CursorLockMode.Locked;

        Time.timeScale= 1.0f;
    }

    public override void Function2()
    {
        Debug.Log("Function2");
    }

    public override void Function3()
    {
        Destroy(GameEvent.Instance.gameObject);
        SceneManager.LoadScene("Title Scene");
    }   
}
