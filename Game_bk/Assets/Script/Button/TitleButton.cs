using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleButton : CreateButton
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
    }

    public override void Function1()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public override void Function2() 
    {
        Debug.Log("Function 2 호출");
        SoundManager.Instance.Sound(0);
    }

    public override void Function3()
    {
        UnityEditor.EditorApplication.isPlaying= false; // 유니티 에디터를 종료하는 기능
    }



}
