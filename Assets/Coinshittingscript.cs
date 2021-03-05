using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coinshittingscript : MonoBehaviour
{
	public AudioSource Coinss;
	public Text points;
	public Text HighScore;
	public int highscore;
	public int counterpoints;
    // Start is called before the first frame update
    void Start()
    {
		highscore=PlayerPrefs.GetInt("highscore");
		HighScore.text = highscore.ToString();


		counterpoints = 0;
	}

    // Update is called once per frame
    void Update()
    {
		//points
		if(counterpoints >= 120)
		{
			GameManag5.missioncompletemenu.SetActive(true);
			Time.timeScale =0f;
		}
		points.text = counterpoints.ToString();



		if(counterpoints > highscore)
		{
			PlayerPrefs.SetInt("highscore",counterpoints);
			HighScore.text = counterpoints.ToString();
		}

	}
    
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="Coin"){
			Coinss.Play();
			counterpoints = counterpoints + 10;
			col.gameObject.SetActive(false);
		}
	}

}

