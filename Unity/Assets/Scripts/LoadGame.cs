using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

    public void startGame(){
        SceneManager.LoadScene(1);
        Debug.Log("trigger");
    }
}
