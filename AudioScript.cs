using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {
	Transform transf;
	AudioSource source;
	GameObject o;
	float timeElapsed;
	// Use this for initialization
	void Start () {
		// face the audio towards the center
		// ideally it would face the "camera" which happens to be at the center
		transf = ((Transform)GetComponent<AudioSource>().transform);
		transf.LookAt(Vector3.zero);
		o = GameObject.Find("OVRCameraRig");
		source = ((AudioSource)GetComponent<AudioSource>());

		source.volume = 0.5f;
		source.Play();
		source.loop = false;
	}

	// Update is called once per frame
	void Update () {
		if (source.isPlaying) {
			timeElapsed += Time.deltaTime;
		}
		Vector3 targetDir = source.transform.position - o.transform.position;
		float degree = Vector3.Angle(targetDir, o.transform.forward);
		source.volume = 1 - degree / 180f;
		if (Input.GetButtonDown ("Jump")) {
            
            if (source.isPlaying) {
				source.Pause();
            }
            else {
				source.Play();
            }
        }
		if (timeElapsed > 238.966) {
			source.Play();
			timeElapsed = 0;
		}
	}
}