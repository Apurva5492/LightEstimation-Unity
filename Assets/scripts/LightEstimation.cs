using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LightEstimation : MonoBehaviour
{

    public float testvalue = 0.5f;

    void onValidate()
    {
        setGlobalLightEstimation(testvalue);
    }

    void setGlobalLightEstimation(float testvalue)
    {
        Shader.SetGlobalFloat("_GlobalLightEstimation", lightvalue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
