using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManag3 : MonoBehaviour
{
	public GameObject Car1;
	public GameObject Car2;
	public GameObject Car3;
	public GameObject pausemenu;
	public static GameObject Missionfailedmenu;
	public GameObject Missionfailedmenu1;
	public GameObject pausebtn;
	public GameObject firstanimcam;
	public GameObject missioncompletemenu;
	public float speed;
	public int col1,col2;
	public bool chck;


    // Start is called before the first frame update
    void Start()
    {
		Missionfailedmenu=Missionfailedmenu1;
		StartCoroutine(caractive());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

	public void PauseBtn()
	{
		Time.timeScale=0f;
		pausemenu.SetActive(true);
		pausebtn.SetActive(false);
	}
	public void ResumeBtn()
	{
		Time.timeScale=1f;
		pausemenu.SetActive(false);
		pausebtn.SetActive(true);
	}
	public void RestartBtn()
	{
		Time.timeScale=1f;
		Application.LoadLevel("MissionLane");
	}
	public void MainMenubtn()
	{
		Time.timeScale=1f;
		Application.LoadLevel("MainMenu");
	}

	IEnumerator caractive()
	{
		yield return new WaitForSeconds(5);
		firstanimcam.SetActive(false);
		if(PlayerPrefs.GetInt("Car")==0)
		{
			Car1.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("Car")==1){
			Car2.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("Car")==2){
			Car3.SetActive(true);
		}
	}
}
