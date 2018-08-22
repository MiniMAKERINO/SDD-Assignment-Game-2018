using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void StartGame() 
    {
        SceneManager.LoadScene("Scene 1");

    }

    public void QuitGame() {
        Debug.Log("QUIT works just fine!"); 
        Application.Quit();
    }


}
