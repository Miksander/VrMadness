using UnityEngine;
using System.Collections;

public class Hologram_Controller : MonoBehaviour {

	[SerializeField]
	public float Frensel_Min = 0.0f;

	[SerializeField]
	public float Frensel_Max = 20.0f;

	[SerializeField]
	public float Ramp_Rate = 0.25f;

	private float Ramp_Timer = 0.0f;
	private Color Start_Color;
	private Color Temp_Color;


	// Use this for initialization
	void Start () 
	{
		Ramp_Timer = Ramp_Rate;
		Start_Color = GetComponent<Renderer>().material.GetColor("_EmmisionColor");
	}
	
	// Update is called once per frame
	void Update () 
	{
		Temp_Color = new Color(
			Start_Color.r + UnityEngine.Random.Range(0.0f,0.05f), 
			Start_Color.g+ UnityEngine.Random.Range(0.0f,0.05f), 
			Start_Color.b+ UnityEngine.Random.Range(0.0f,0.05f),
			1.0f);
		GetComponent<Renderer>().material.SetColor("_EmmisionColor",Temp_Color);
		Ramp_Timer -= Time.deltaTime;
		if(Ramp_Timer <= 0.0f)
		{
			Frensel_Min = Mathf.Clamp(Frensel_Min,0.0f,20.0f);
			Frensel_Max = Mathf.Clamp(Frensel_Max,0.0f,20.0f);
			GetComponent<Renderer>().material.SetFloat("_Frensel", UnityEngine.Random.Range(Frensel_Min,Frensel_Max));
			GetComponent<Renderer>().material.SetFloat("_Noise", UnityEngine.Random.Range(Frensel_Min,Frensel_Max));
			GetComponent<Renderer>().material.SetColor("_EmmisionColor",Start_Color);
			Ramp_Timer = Ramp_Rate;
		}
	}
}
