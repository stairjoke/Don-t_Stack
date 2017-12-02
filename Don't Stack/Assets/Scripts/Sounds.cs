using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour {

    public Transform playAudio;
    public Transform scoreAudio;

    public void Start(){
        scoreAudio.GetComponent<AudioSource>().Pause();
        scoreAudio.GetComponent<AudioSource>().mute = false;;
    }

    public void score(){
        playAudio.GetComponent<AudioSource>().Stop();
        scoreAudio.GetComponent<AudioSource>().Play();
    }
}
