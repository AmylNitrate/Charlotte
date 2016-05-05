using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Darkness : MonoBehaviour {

   // public bool hasLight;
    public AudioClip darkness;
    public AudioSource audioSource;
	public float timer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		timer -= Time.deltaTime;

		Debug.Log ("timer:" + timer);

		if (!audioSource.isPlaying)
        {
			if (timer <= 0) 
			{
				audioSource.clip = darkness;
				audioSource.PlayOneShot (audioSource.clip);
			}
        }
		if (timer > 0)
        {
            audioSource.Stop();

        }
		if (timer <= -24) 
		{
			SceneManager.LoadScene ("transition");
		}

    }
}
