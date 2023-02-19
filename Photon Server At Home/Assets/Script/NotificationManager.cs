using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class NotificationManager : MonoBehaviour
{
    [SerializeField] Text title;
    [SerializeField] Text content;
    public void Close()
    {
        Destroy(gameObject);
    }

    public static NotificationManager NotificationWindow(string titleMessage, string contetnMessage)
    {
        GameObject notification = Instantiate(Resources.Load<GameObject>("Notification Window"));

        NotificationManager resultWindow = notification.GetComponent<NotificationManager>();

        resultWindow.title.text = titleMessage;
        resultWindow.content.text = contetnMessage;

        return resultWindow;

    }
}
