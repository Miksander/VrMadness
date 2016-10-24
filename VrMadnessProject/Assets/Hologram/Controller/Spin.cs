using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	[SerializeField]
	public bool Direction;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Direction == true)
		{
			transform.Rotate(new Vector3(0,1,0));
		}
		else
		{
			transform.Rotate(new Vector3(0,-1,0));
		}
	}
}
