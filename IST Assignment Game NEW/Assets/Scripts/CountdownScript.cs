using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class CountdownScript : MonoBehaviour
{
    [SerializeField] private Text uiText; // uiText variable
    [SerializeField] private float mainTimer; // Main timer float
    [SerializeField] private GameObject TPLocation; // Start Location
    [SerializeField] private GameObject playerObject; // Player object

    private float timer; // Secondary timer float
    private bool canCount = true; // Bug/Error prevention boolean adds secondary condition that helps prevents bugs/glitches
    private bool doOnce = false; // Bug/Error prevention boolean adds secondary condition that helps prevents bugs/glitches

    private void Start() // Initialize upon starting a scene
	{
        timer = mainTimer; // Timer is set to mainTimer value
        playerObject.GetComponent<FirstPersonController>().enabled = true; // First person controller script component is enabled

    }

	private void Update() // Updates within every frame
	{

        if(timer >= 0.0f && canCount) // If the timer is greater than or equal to 0.0 and canCount = True (Bug prevention)
        {
            timer -= Time.deltaTime; // Timer decreases by 1 second
            uiText.text = timer.ToString("F"); // Float is converted to string and Time is shown on screen

        }

        else if (timer <= 0.0f && !doOnce) // If timer is less than or equal to 0.00 and doOnce = True (Bug prevention)
        {
            canCount = false; // Set canCount to false (Bug prevention)
            doOnce = true; // Set doOnce to True (Bug prevention)
            uiText.text = "Too Slow! Press 'R' to restart"; // Display this string 
            timer = 0.0f; // Sets the timer to 0.0f
            playerObject.GetComponent<FirstPersonController>().enabled = false; // First person controller script component is disabled

        }

        if(Input.GetKeyDown(KeyCode.R)) // If 'R' is pressed
        {
            playerObject.transform.position = TPLocation.transform.position; // Teleport to original position
            timer = mainTimer; // Timer is set to the mainTimer value
            canCount = true; // Bug prevention
            doOnce = false; // Bug prevention
            playerObject.GetComponent<FirstPersonController>().enabled = true; // First person character script component is enabled
        }

	}

//    public void ResetTimer()
//    {
//        timer = mainTimer;
//        canCount = true;
//        doOnce = false;
//    }

}