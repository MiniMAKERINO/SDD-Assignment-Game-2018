using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseFunction : MonoBehaviour {

    public GameObject PauseOverlay; // UI overlay on screen
    public static bool GamePaused = false; // Game is not paused


    private void Update() //Update every frame
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //If esc is pressed
        {
            if (GamePaused) // If GamePaused = True
            {
                Resume(); // Call Resume function
            }
            else // Else
            {
                Pause(); // Call Pause function
            }
        }
        
    }

    void Pause() // Pause Function
    {
        PauseOverlay.SetActive(true); // Pause UI overlay is set to active
        Time.timeScale = 0f; // Freezes time
        GamePaused = true; // Game is paused
        Cursor.lockState = CursorLockMode.None; // Cursor is not locked
        Cursor.visible = true; // Cursor is visible

    }

    public void Resume() // Resume function
    {
        PauseOverlay.SetActive(false); // Pause UI overlay is no longer active
        Time.timeScale = 1f; // Time is unfrozen or set to normal
        GamePaused = false; // Game is not paused
        Cursor.lockState = CursorLockMode.Locked; // Cursor is LOCKED
        Cursor.visible = false; // Cursor is NOT visible

    }

    public void LoadMenu() // LoadMenu function, used for button reference, hence a public function
    {
        SceneManager.LoadScene("Main Menu"); // Loads Main Menu scene
        Time.timeScale = 1f; // Sets time back to normal
    }

    public void QuitGame() // Quit game function, used for button reference, hence a public function
    {
        Debug.Log("Quit"); // Logs "Quit" to the console
        Application.Quit(); // Quit application
    }
}
