using UnityEngine;
using System.Collections;

public class AudioData : MonoBehaviour {

	public int sampleRate = 2048;
	public AudioSource source;

	float[] samples;
	AudioClip clip;

	void Start () {
		samples = new float[sampleRate]; 
		clip = Microphone.Start(Microphone.devices[0], true, 1, 44100);
		source.clip = clip;
		source.Play();
	}

	void Update () {
		//clip = Microphone.Start(Microphone.devices[0], true, 1, sampleRate);
		//source.clip = clip;
		//source.Play();
		source.GetSpectrumData(samples, 0, FFTWindow.Rectangular);
	}

	public float[] GetMicData () {
		return samples;
	}
}
