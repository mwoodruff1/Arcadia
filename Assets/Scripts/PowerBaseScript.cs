using UnityEngine;
using System.Collections;

public class PowerBaseScript : MonoBehaviour{

float PowerSystemCap = 2500.00f;
public float PowerSystemLevel = 0.00f;
float PowerSystemDecayRate = 25.00f;
float PowerDecayFormula = 0.0f;
float PowerSystemOutput = 0.0f;

//These are the formulas for the actual system. One is the Default Power Output and one is the Decay Formula.

void Update() {
            PowerDecayFormula = PowerSystemLevel / PowerSystemCap;
            PowerSystemOutput = PowerDecayFormula - PowerSystemLevel;
        if (PowerSystemLevel == PowerSystemCap)
	Debug.Log("Power System is at 100 Percent");
        if(PowerSystemLevel == 1875.0f)
	Debug.Log("Power Level at 75 Percent");
        if (PowerSystemLevel == 1250.0f)
	Debug.Log("Power System at 50 Percent");
        if (PowerSystemLevel == 625.0f)
	Debug.Log("Power System at 25 Percent");
        if (PowerSystemLevel == 0.0f)
            Debug.Log("Power System at 0 Percent");

}

}