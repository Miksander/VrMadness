using UnityEngine;
using System.Collections;


public class SpawnByLoudness : MonoBehaviour
{

   // public GameObject audioInputObject;
    public float threshold = 1.0f;
    public GameObject objectToSpawn;
    // MicrophoneInput micIn;
    public AudioData _aData;
   
   

    void Update()
    {
        var _dataSum = 0f;
        var _micData = _aData.GetMicData();
        for (int i = 0; i < _micData.Length; i++)
        {
            _dataSum += _micData[i];
        }
        if (_dataSum > threshold)
        {
            Vector3 scale = new Vector3(_dataSum, _dataSum, _dataSum);
            GameObject newObject = (GameObject)Instantiate(objectToSpawn, this.transform.position, Quaternion.identity);
            newObject.transform.localScale += scale;
        }
    }
}
