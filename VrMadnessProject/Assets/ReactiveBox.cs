using UnityEngine;
using System.Collections;

public class ReactiveBox : MonoBehaviour {

	public float toBounce;
	public float force;
	public AudioData _aData;
	Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		var _dataSum = 0f;
		var _micData = _aData.GetMicData();
		for (int i = 0; i < _micData.Length; i++) {
			_dataSum += _micData[i];
		}
		
		//transform.localScale = new Vector3(1, _dataSum, 1);
		if (_dataSum > toBounce) {
			rb.AddForce(Vector3.up * force, ForceMode.Impulse);
		}
	}
}
