using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {
	Transform myTransform;
	AudioSource source;
	// Use this for initialization
	void Start () {
		// face the audio towards the center
		// ideally it would face the "camera" which happens to be at the center
		myTransform = ((Transform)GetComponent<Renderer>().transform);
		myTransform.LookAt(Vector3.zero);

		source = ((AudioSource)GetComponent<AudioSource>());

		// a miracle happens

		//source.volume = 1 - Quaternion.Angle(Transform(Camera.main).rotation, angleToAudioSrc) / 180f;
		source.volume = 1;
		source.Play();
	}

	// Update is called once per frame
	void Update () {
		
	}
}