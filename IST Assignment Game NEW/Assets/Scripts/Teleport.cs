using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    [SerializeField] private GameObject playerObject; // What to teleport, in this case, the player
    [SerializeField] private GameObject TPLocation; // New location

    private void OnTriggerEnter(Collider other) // Upon entering the box collider set to trigger
    {
        if (other.gameObject.tag == "Player") // If collision with a gameobject tagged "Player"
            playerObject.transform.position = TPLocation.transform.position; // Make the "Player" position to the new position AKA Teleport "Player" to new location
    }
}
