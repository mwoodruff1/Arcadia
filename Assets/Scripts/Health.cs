//Coded by: Matthew Woodruff/Camwarp.
//August 8 2016.
//The main health script of the Arcadia Project
using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
     public float PlayerHealth = 100.0f;

    // void Update just calls the health script which is farther down.
    void Update()
    {
        HealthOfPlayer();    
    }

    //Below is the Health of Player script
    //Any Debug.Logs will be replaced when the GUI is implemented. 
    //The only ones that wont will be the actual error messages
    //Camwarp 10:53 8/9/2016
    void HealthOfPlayer()
    {
       //The below code just spams the console. 
       //TODO Make it stop spamming. Maybe with a wait loop. Checks every second maybe
       //Coffee Sounds better though. Hmm decisions decisions.

        if (PlayerHealth > 100) { 
            Debug.LogError("Player Health is greater than 100. This is a error.");
            //This actuall stays Debug.LogError. ^ Because if this happens it will definetly be a error
            PlayerHealth = 100;
            //This fixes that error.
        }
        //These if statements below really need the GUI implemented before you can go farther with them. 
        //Damage can be implemented. Needs to be implemented anyways. 
        //GUI then damage. Power systems to.  I really need a worklist for this crap.
        if (PlayerHealth == 100.0)
            Debug.Log("Player Health at 100 Percent");
        if (PlayerHealth == 75.0)
        Debug.Log("Player Health at 75 Percent");
        if (PlayerHealth == 50.0)
            Debug.Log("Player Health at 50 Percent");
        if (PlayerHealth == 25.0)
            Debug.Log("Player Health at 25 Percent");
        if (PlayerHealth == 0)
            Debug.Log("Player Health is 0");

    }
    //The below is not implemented v. Its on a list... Of about 40 other things to do.
    public void TakeDamage(float amount)
    {
        // Decrement the player's health by amount.
        PlayerHealth -= amount;
    }
}