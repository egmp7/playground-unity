using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    GameObject[] lights;

    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("Light");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TurnLights();
        }
    }

    void TurnLights()
    {
        foreach (GameObject go in lights)
        {
            Light lightComponent = go.GetComponentInChildren<Light>();
            lightComponent.enabled = !lightComponent.enabled;
        }
    }
}
