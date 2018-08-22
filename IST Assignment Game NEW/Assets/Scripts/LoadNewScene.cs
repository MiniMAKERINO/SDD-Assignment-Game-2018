using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {

    [SerializeField] private GameObject playerObject; //Reference player object
    [SerializeField] private string necLevel;

    private void OnTriggerEnter(Collider other) // upon entering trigger
    {
        if (other.gameObject.tag == "Player") // If tag is player
        {
            SceneManager.LoadScene(necLevel); // Load scene

        }
    }
}
