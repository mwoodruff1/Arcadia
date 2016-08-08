using UnityEngine;
using System.Collections;

public class Hyperdrive : MonoBehaviour
{
    public float HyperdriveSpeed = 0.0f;
    bool HyperDriveToggle = false;
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.H))
        {
            HyperDriveToggle = !HyperDriveToggle;
        }
        if (HyperDriveToggle)
            transform.Translate(Vector3.forward * HyperdriveSpeed * Time.deltaTime);
    }
}

//transform.Translate(Vector3.forward* HyperdriveSpeed * Time.deltaTime);