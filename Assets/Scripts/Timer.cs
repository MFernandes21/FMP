using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] public float remainingTime = 30;
    string sceneName = "GameOver";
    string gameScene = "Game";
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if(remainingTime < 0)
        {
            
            SceneManager.LoadScene(sceneName);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }



        int minutes  = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    public void SetTimer()
    {
        remainingTime = 30;
    }
}
