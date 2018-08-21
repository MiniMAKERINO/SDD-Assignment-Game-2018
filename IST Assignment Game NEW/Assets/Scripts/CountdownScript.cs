using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class CountdownScript : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;
    [SerializeField] private GameObject TPLocation;
    [SerializeField] private GameObject playerObject;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

	private void Start()
	{
        timer = mainTimer;
        playerObject.SetActive(true);
        playerObject.GetComponent<FirstPersonController>().enabled = true;

    }

	private void Update()
	{

        if(timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");

        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "Too Slow! Press 'R' to restart";
            timer = 0.0f;
            playerObject.GetComponent<FirstPersonController>().enabled = false;

        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            playerObject.transform.position = TPLocation.transform.position;
            timer = mainTimer;
            canCount = true;
            doOnce = false;
            playerObject.GetComponent<FirstPersonController>().enabled = true;
        }

	}

//    public void ResetTimer()
//    {
//        timer = mainTimer;
//        canCount = true;
//        doOnce = false;
//    }

}