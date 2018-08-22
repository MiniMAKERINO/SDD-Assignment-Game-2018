using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void StartGame() // Start Game function, used for button reference, hence a public function
    {
        SceneManager.LoadScene("Scene 1"); // Loads scene 1

    }

    public void QuitGame() // Quit Game Function, used for button reference, hence a public function
    {
        Debug.Log("QUIT works just fine!"); //Logs a msg to console
        Application.Quit(); // Quit application
    }


}
