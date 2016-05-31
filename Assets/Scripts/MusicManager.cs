using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChange;

    private AudioSource audiosource;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    
    // Use this for initialization
    void Start () {
        audiosource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void OnLevelWasLoaded (int level) {
        AudioClip thisLevelMusic = levelMusicChange[level];

        if (thisLevelMusic)
        {
            audiosource.clip = thisLevelMusic;
            audiosource.loop = true;
            audiosource.Play();
        }
	
	}
}
