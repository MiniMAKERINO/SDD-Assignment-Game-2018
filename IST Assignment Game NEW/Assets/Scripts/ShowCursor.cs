using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCursor : MonoBehaviour {

    private void Start() // Initialization
    {
        Cursor.lockState = CursorLockMode.None; // Cursor is not locked
    }

    private void Update() // Update every frame 
    {
        Cursor.visible = true; // Cursor is visible
    }
}
