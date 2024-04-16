using System;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TMP_Text _timerText;
    enum TimerType {Countdown, Stopwatch}
    [SerializeField] private TimerType timerType;

    [SerializeField] private float timeToDisplay = 60.0f;

    private bool _isRunning;

    private void Awake()
    {
        _timerText = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        EventManager.TimerStart += EventManager_TimerStart;
        EventManager.TimerStop += EventManager_TimerStop;
        EventManager.TimerUpdate += EventManager_TimerUpdate;

    }

    private void OnDisable()
    {
        EventManager.TimerStart -= EventManager_TimerStart;
        EventManager.TimerStop -= EventManager_TimerStop;
        EventManager.TimerUpdate -= EventManager_TimerUpdate;
    }

    private void EventManager_TimerStart() => _isRunning = true;

    private void EventManager_TimerStop() => _isRunning = false;

    private void EventManager_TimerUpdate(float value) => timeToDisplay += value;

    void Update()
    {
        if (!_isRunning) return;
        if (timerType == TimerType.Countdown && timeToDisplay < 0.0f)
        {
            EventManager.OnTimerStop();
            return;
        }
        timeToDisplay += timerType == TimerType.Countdown ? -Time.deltaTime : Time.deltaTime;

        TimeSpan timeSpan = TimeSpan.FromSeconds(timeToDisplay);
        _timerText.text = timeSpan.ToString(@"mm\:ss\:ff");
    }
}
