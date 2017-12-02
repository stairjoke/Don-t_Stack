using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public float levelTimeInSeconds = 45f;
    public Text timer;
	
	// Update is called once per frame
	void Update () {
        UpdateTimer();
	}

    private void UpdateTimer(){
        levelTimeInSeconds -= Time.smoothDeltaTime;
        if (levelTimeInSeconds <= 1)
        {
            Time.timeScale = 0;
            //show score
        }
        timer.text = Mathf.Floor(levelTimeInSeconds).ToString() + "s";
    }

}
