using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviourPunCallbacks
{
    public Vector3 RandomPosition(float value)
    {
        // 게임 오브젝트를 중심으로 기준 반지름 원 설정.
        float radius = value;
        float x = Random.Range(-radius, radius);
        float z = Mathf.Sqrt(Mathf.Pow(radius,2)-Mathf.Pow(x,2));
        
        if(Random.Range(0,2)==0)
        {
            z = -z;
        }

        return new Vector3(x,1,z);
        
    }

    IEnumerator Spawn(string name, float radius)
    {
        while(true)
        {
            PhotonNetwork.Instantiate
                (
                    name,
                    RandomPosition(radius),
                    Quaternion.identity
                );

            yield return new WaitForSeconds(5);

        }
    }

    private void Awake()
    {
        PhotonNetwork.Instantiate
                (
                    "Character",
                    RandomPosition(10),
                    Quaternion.identity
                );

    }
    void Start()
    {
        if(PhotonNetwork.IsMasterClient) 
        {
            StartCoroutine(Spawn("Bee", 100));
        }
    }

    public void ExitRoom()
    {
        PhotonNetwork.LeaveRoom();

    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.LoadLevel("Photon Room");

    }


}
