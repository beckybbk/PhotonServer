using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Information : MonoBehaviour
{
    public Text roomData;
    private string roomName;

    public void OnClickJoinRoom()
    {
        PhotonNetwork.JoinRoom(roomName);
    }

    public void SetInfo(string Name, int Current, int Max)
    {
        roomName = Name;
        roomData.text = Name + " ( " + Current + "/" + Max + " ) ";
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
