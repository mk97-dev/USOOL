using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManag : MonoBehaviour
{
	public AudioSource music;
	public static SoundManag instance;
    // Start is called before the first frame update
    void Start()
	{
		if(instance==null)
		{
			instance=this;
			DontDestroyOnLoad(this.gameObject);
		}
		else
		{
			Destroy (gameObject);
		}
    }

    // Update is called once per frame
    void Update()
    {
		if((SceneManager.GetActiveScene().name == "GamePlay") || (SceneManager.GetActiveScene().name == "FinalRaceScene") || (SceneManager.GetActiveScene().name == "FinalRaceSceneSpeedCheck")){
			music.volume=0f;
		}
		else
		{
			music.volume=1f;
		}
    }
}