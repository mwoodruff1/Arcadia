using UnityEngine;
using System.Collections;

public class Hyperdrive : MonoBehaviour
{
    float PowerDecay = 5.0f;
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

    void HyperDrive() {
        if (Input.GetKeyDown(KeyCode.H))
        { HyperDriveToggle = !HyperDriveToggle; }

        if (HyperDriveToggle == true) { 
            transform.Translate(Vector3.forward * HyperdriveSpeed * Time.deltaTime);
        print("This is where the drain code is");
            powerLevelAccess.PowerSystemLevel = 0;
            powerLevelAccess.PowerSystemLevel -= PowerDecay;
        }
        else
            HyperDriveToggle = false; 


   
             
    }
}

//transform.Translate(Vector3.forward* HyperdriveSpeed * Time.deltaTime);