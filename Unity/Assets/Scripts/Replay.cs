using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {
    public void restartLevel(){
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().path);
    }
}
