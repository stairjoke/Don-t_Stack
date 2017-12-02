using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {

    public Canvas creditsCanvas;

    public void showCredits(){
        creditsCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void hideCredits(){
        creditsCanvas.GetComponent<Canvas>().enabled = false;
    }
}
