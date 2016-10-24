using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]

public class ParticlesOnAudio : MonoBehaviour
{
    
    public int _band;
    public float _minEmissionRate, maxEmissionRate;
    ParticleSystem _par;

    // Use this for initialization
    void Start()
    {
        _par = GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var emission = _par.emission;
        var rate = emission.rateOverTime;

        rate.constantMax = (AudioPeer._audioBandBuffer[_band] * (maxEmissionRate - _minEmissionRate)) + _minEmissionRate; 
        emission.rateOverTime = rate;
        // (AudioPeer._audioBandBuffer[_band] * (maxEmissionRate - _minEmissionRate)) + _minEmissionRate;
    }
}
