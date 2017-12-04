using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {
    public void mainMenu(){
        SceneManager.LoadScene(0);
    }
    public void exit(){
        Debug.Log("EXIT APP");
        Application.Quit();
    }
}
