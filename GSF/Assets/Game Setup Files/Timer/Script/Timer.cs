using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    /// <summary>
    // Contribution: Added comments explaining what most of the code does. 
    //  Feature: Counts down one minute. 
    //	Date:	Start Date: 04/23/2021   End Date: 04/23/2021
    //  References: John Leonard French
    //	Links:  French, J. L. (2020, February 25). How to make a countdown timer in Unity (in minutes + seconds). gamedevbeginner. https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/#:~:text=The%20method%20for%20making%20a%20basic%20countdown%20timer,time%20to%20count%20down%2C%20the%20timer%20will%20run. 
    /// </summary>

    // variables
    // Timer values for counting down.
    public float timer = 60;

    public bool timerOn = false;

    // Text to update timer
    public Text timerText;

    void Start()
    {
        Debug.Log("Start");

        // Sets the timer on
        timerOn = true;
    }

    void Update()
    {
        if (timerOn)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                timerDisplay();
            }
            else
            {
                timer = 0;
                timerOn = false;

                // Makes the player lose
                Debug.Log("Out of Time");
            }
        }
    }

    public void timerDisplay()
    {
        float timedisplay = timer;
        timedisplay += 1;
        float minutes = Mathf.FloorToInt(timedisplay / 60);
        float seconds = Mathf.FloorToInt(timedisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
