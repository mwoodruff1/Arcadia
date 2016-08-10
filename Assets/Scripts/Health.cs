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
    void HealthOfPlayer()
    {
        if (PlayerHealth <= 0)
        {
            Debug.Log("Player Health is 0");
        }
        if (PlayerHealth > 100)
            Debug.LogWarning("Player Health is greater than 100. This is a error.");

        
    }
    //The below is not implemented
    public void TakeDamage(float amount)
    {
        // Decrement the player's health by amount.
        PlayerHealth -= amount;
    }
}