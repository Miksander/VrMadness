using UnityEngine;
using System.Collections;
 
public class ParticleController : MonoBehaviour {

    public GameObject _ps;
    public float _waitTime;
    ParticleSystem particleSystem;

    void Start ()
    {
        particleSystem = _ps.GetComponent<ParticleSystem>();
    }

    public IEnumerator Emit ()
    {
       // particleSystem.Emit(1000);
        _ps.SetActive(true);
        yield return new WaitForSeconds(_waitTime);
        _ps.SetActive(false);
    }
}
