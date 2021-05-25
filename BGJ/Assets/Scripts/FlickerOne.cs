using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class FlickerOne : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D Light;

    void Update()
    {
        Light.intensity = Random.Range(Mathf.Lerp(0.5f, 2f, 2f), Mathf.Lerp(0.5f, 2f, 2f));
    }
}