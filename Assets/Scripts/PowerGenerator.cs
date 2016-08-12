using UnityEngine;
using System.Collections;

public class PowerGenerator : MonoBehaviour
{
    public PowerBaseScript powerGenerationAccess;
    private float PowerGenOutput;
    private float PowerGenActualOutput = 0.0f;
    private float PowerGenAddition = 25.0f;
    private bool PowerGeneratorToggle = false;
    void Update()
    {
        //The below adds in a power on and off switch when clicking why.
        if (Input.GetKey(KeyCode.Y))
            PowerGeneratorToggle = !PowerGeneratorToggle;

        if (PowerGeneratorToggle == true)
        {
            PowerGenOutput += PowerGenAddition + PowerGenActualOutput;
            powerGenerationAccess.PowerSystemLevel = PowerGenOutput;
            //Quick fix for power gen problem of constant increase
            if (powerGenerationAccess.PowerSystemLevel > 2500)
                powerGenerationAccess.PowerSystemLevel = 2500;}
        else
            PowerGeneratorToggle = false;

    }
}
/*   
            */
             