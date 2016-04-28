using UnityEngine;
using System.Collections;

public class PlayMovieScript : MonoBehaviour {
	MovieTexture movie;
	AudioSource source;
	// Use this for initialization
	void Start () {
		movie = ((MovieTexture)GetComponent<Renderer>().material.mainTexture);
		movie.loop = true;
		movie.Play();
		
		source = ((AudioSource)GetComponent<AudioSource>());
		source.Play();
		source.loop = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown ("Jump")) {
            
            if (movie.isPlaying) {
                movie.Pause();
				source.Pause();
            }
            else {
                movie.Play();
				source.Play();
            }
        }
    }
}
