using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    /// <summary>
    // Contribution: Coded the counter
    // Feature: Counts how many presses the player has done. 
    //Date:	 Start Date: 04/23/2021   End Date: 04/23/2021
    /// </summary>

    // Calling both values at the start to initalize them for the counter
    public int count = 0;
    int i = 0;

    // Final Count for the values
    public int finalCount;

    // Text to update the score
    public Text clickCount;

    void Start()
    {
        // Sets the text count as zero
        clickCount.text = i.ToString();
    }

    // Makes the counter go up
    public void counter()
    {
        i++;
        count = i;
        finalCount = count;
        countDisplay();
    }

    // Displays the count
    public void countDisplay()
    {
        clickCount.text = count.ToString();
    }

    void Update()
    {
        // Conditions for Win

        if (finalCount == 100)
        {
            Debug.Log("Number Reached");
        }
    }
}
