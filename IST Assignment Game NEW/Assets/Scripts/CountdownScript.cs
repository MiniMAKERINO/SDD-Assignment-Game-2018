using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;
    [SerializeField] private GameObject TPLocation;
    [SerializeField] private GameObject TPObject;
   // [SerializeField] private GameObject playerObject;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

	private void Start()
	{
        timer = mainTimer;
        //playerObject.setActive(true);
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
            //playerObject.setActive(false);
            // Make Press "r" to restart
            {
                
            }

        }

        if(Input.GetKeyDown(Keycode.R))
        {
            TPObject.transform.position = TPLocation.tranform.position;
        }

	}

//    public void ResetTimer()
//    {
//        timer = mainTimer;
//        canCount = true;
//        doOnce = false;
//    }

}