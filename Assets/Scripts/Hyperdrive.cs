using UnityEngine;
using System.Collections;

public class Hyperdrive : MonoBehaviour
{
    public float HyperdriveSpeed = 25.0f;
    private bool HyperDriveToggle = false;
    public PowerBaseScript powerLevelAccess;
    void Update()
    {
       /* if(powerLevelAccess.PowerSystemLevel < 500)
        {
            print("Power Level to low to engage Hyperdrive");
        } */
        HyperDrive();
        
    }

    void HyperDrive()
    {
        if (Input.GetKeyDown(KeyCode.H))
        { HyperDriveToggle = !HyperDriveToggle; }

        if (HyperDriveToggle == true) { 
        transform.Translate(Vector3.forward * HyperdriveSpeed * Time.deltaTime);
        float PowerDecay = 500.0f;
        powerLevelAccess.PowerSystemLevel -= PowerDecay;
        }
        else
            HyperDriveToggle = false; 
    }
}

//transform.Translate(Vector3.forward* HyperdriveSpeed * Time.deltaTime);