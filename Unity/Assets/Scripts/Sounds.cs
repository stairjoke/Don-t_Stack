using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour {

    public Transform playAudio;
    public Transform scoreAudio;
    private bool called = false;

    public void score(){
        if(!called){
            playAudio.GetComponent<AudioSource>().Stop();
            scoreAudio.GetComponent<AudioSource>().Play();
            called = true;
        }
    }
}
