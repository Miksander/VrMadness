using UnityEngine;
using System.Collections;

public class ParticleTimer : MonoBehaviour {
    public float startDelay = 1f;
    public float playTime = 2f;
   
    ParticleSystem partikle; 

	// Use this for initialization
	void Start () {

   partikle = GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
       
        if (Time.time > startDelay + playTime)
        {
          
            partikle.Stop();
        }
        else if (Time.time > startDelay) {
           
            partikle.Play();
        }
	}
}
