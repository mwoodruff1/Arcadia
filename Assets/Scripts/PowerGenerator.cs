using UnityEngine;
using System.Collections;

public class PowerGenerator : MonoBehaviour
{
    public PowerBaseScript powerGenerationAccess;
    private float PowerGenOutput;
    private float PowerGenActualOutput = 0.0f;
    private float PowerGenAddition = 25.0f;
    void Update()
    {
        PowerGenOutput += PowerGenAddition + PowerGenActualOutput;
        powerGenerationAccess.PowerSystemLevel = PowerGenOutput;

        //Quick fix for power gen problem of constant increase
        if (powerGenerationAccess.PowerSystemLevel > 2500)
        {
            powerGenerationAccess.PowerSystemLevel = 2500;
        }
    }
}