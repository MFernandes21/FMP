using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    private void Awake()
    {
        AudioManager.instance.StopSFX("Fireplace");
        AudioManager.instance.PlaySFX("Dead");
        
        
        


        AudioManager.instance.StopMusic("Theme");
    }
}
