﻿using UnityEngine;
using System.Collections;
 
public class ParticleController : MonoBehaviour {

    public GameObject _ps;
    public float _waitTime;

    public IEnumerator Emit ()
    {
        _ps.SetActive(true);
        yield return new WaitForSeconds(_waitTime);
        _ps.SetActive(false);
    }
}
