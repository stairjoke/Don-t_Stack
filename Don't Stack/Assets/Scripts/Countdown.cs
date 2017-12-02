using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public float levelTimeInSeconds = 45f;
    public Canvas replayCanvas;
    public Text timer;
    public Color runningOutOfTimeColor;
    public float runningOutStep = 10f;
    public Font runningOutFont;
    public ParticleSystem reminder;
    public Transform soundsEmpty;
	
    void Start(){
        Time.timeScale = 1;
        if(reminder != null){
            reminder.Pause();
        }
    }

	// Update is called once per frame
	void Update () {
        UpdateTimer();
	}

    private void UpdateTimer(){
        levelTimeInSeconds -= Time.smoothDeltaTime;
        if (levelTimeInSeconds <= 1)
        {
            soundsEmpty.GetComponent<Sounds>().score();
            Time.timeScale = 0;
            replayCanvas.GetComponent<Canvas>().enabled = true;
        }
        timer.text = Mathf.Floor(levelTimeInSeconds).ToString() + "s";
        if (runningOutStep > 0f){
            if(reminder != null && levelTimeInSeconds <= (runningOutStep + 1 + 1)){
                reminder.Play();
            }
            if (levelTimeInSeconds <= runningOutStep + 1f)
            {
                timer.color = runningOutOfTimeColor;
                if (runningOutFont != null)
                {
                    timer.font = runningOutFont;
                }
            }
        }
    }

}
