using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTimer : MonoBehaviour {

    public float startDelay = 1f;
    public float playTime = 2f;

    Light _light;

    // Use this for initialization
    void Start()
    {

        _light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > startDelay + playTime)
        {

            _light.enabled=false;
        }
        else if (Time.time > startDelay)
        {

            _light.enabled=true;
        }
    }
}
