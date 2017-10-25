using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DryerAudio : MonoBehaviour
{
	public AudioClip attack;
	public AudioClip sustain;
	public AudioClip decay;

	private float attackSamples[];
	private float sustainSamples[];
	private float releaseSamples[];
	
	private bool keyDown = false;
	private bool keyHold = false;
	private bool keyUp = false;

	private int attackIndex;
	private int sustainIndex;
	private int decayIndex;

	private void Start()
	{

		attackIndex = 0;
		sustainIndex = 0;
		decayIndex = 0;
		//size our arrays for clip samples

		//get our audiosource so we can look at the clip
		//AudioSource aud = GetComponent<AudioSource>();

		//populate our samples array with correct size from clip
		//float[] samples = new float[aud.clip.samples * aud.clip.channels];

		//load clip data into our float array
		//clip.getdata(samples, 0);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("Space"))
		{
			keyDown = true;
		} else if (Input.GetKey("Space"))
		{
			keyHold = true;
		} else if (Input.GetKeyUp("Space"))
		{
			keyUp = true;
		}
		
	}

	private void OnAudioFilterRead(float[] data, int channels)
	{
		//data starts out as an array of 2048 0s
		//data is the bucket we need to fill
		//our separate arrays are what we use to fill the bucket
		//we have to test for what state we're in to determine what to populate our data with

/*		for (int i = 0; i < data.Length; i++)
		{
			data[i] = samples[index];
			index++;
			
			//index%samples.length; ??
			
			if index > samples.length, set index to 0 so we can clear out the buffer
		}*/
	}
}
