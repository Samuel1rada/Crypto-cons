using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muteAudio : MonoBehaviour
{
    public GameObject ObjectMuziek;

    public void MuteToggle(bool Muted)
    {
        ObjectMuziek = GameObject.FindWithTag("AchtergroundMuziek");
        if(Muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
       
        
     
        
    }
}
