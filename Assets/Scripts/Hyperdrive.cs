using UnityEngine;
using System.Collections;

public class Hyperdrive : MonoBehaviour
{
    public float HyperdriveSpeed = 25.0f;
    private bool HyperDriveToggle = false;
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.H))
        {HyperDriveToggle = !HyperDriveToggle;}
        if (HyperDriveToggle == true)
            transform.Translate(Vector3.forward * HyperdriveSpeed * Time.deltaTime);
        else
            HyperDriveToggle = false;
    }
    
   
}

//transform.Translate(Vector3.forward* HyperdriveSpeed * Time.deltaTime);