using UnityEngine;
using System.Collections;

public class SpawnByLoudness2 : MonoBehaviour
{

    public GameObject audioInputObject;
    public float threshold = 1.0f;
    public GameObject objectToSpawn;
    public ParticleController _pc;
    MicrophoneInput micIn;
    void Start()
    {
        if (objectToSpawn == null)
            Debug.LogError("You need to set a prefab to Object To Spawn -parameter in the editor!");
        if (audioInputObject == null)
            audioInputObject = GameObject.Find("AudioInputObject");
        micIn = (MicrophoneInput)audioInputObject.GetComponent("MicrophoneInput");
    }

    void Update()
    {
        float l = micIn.loudness;
        if (l > threshold)
        {
            _pc.StartCoroutine(_pc.Emit());
            //Vector3 scale = new Vector3(l, l, l);
            //GameObject newObject = (GameObject)Instantiate(objectToSpawn, this.transform.position, Quaternion.identity);
           // newObject.transform.localScale += scale;
        }
    }
}
