using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

    public void PlayAgain() { // Play Again function
        SceneManager.LoadScene("Scene 1"); // Load scene 1
    }

    public void BackToMenu() // Back to menu function
    {
        SceneManager.LoadScene("Main Menu"); // Load Main Menu
    }
}
