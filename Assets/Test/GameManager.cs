using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(SystemInfo.deviceUniqueIdentifier);
        ADSManager.instance.DownloadIntertitalAd();
    }

    public void GameOver()
    {
       ADSManager.instance.ShowInterStitalAd();
    }

   
}
