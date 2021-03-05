using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManag5 : MonoBehaviour
{
	public GameObject Car1;
	public GameObject Car2;
	public GameObject Car3;
	public GameObject pechlaybtn;
	public GameObject pausemenu;
	public  GameObject Missionfailedmenu;
	public GameObject pausebtn;
	public GameObject firstanimcam;
	public GameObject othercam;
	public GameObject leftindicator;
	public GameObject rightindicator;
	public static GameObject missioncompletemenu;
	public GameObject missioncompletemenu1;
	public int col1,col2;
	public bool check;
	public bool checkcounter;
	public bool indcheck;
	public bool indcheck1;
	public bool indcheck2;
	public Text startCounter;
	public int start = 3; 
	public float timer ;
	public Text minText;
	public float min, sec;
    // Start is called before the first frame update
    void Start()
	{
		indcheck=false;
		indcheck1=false;
		indcheck2=false;
		missioncompletemenu =missioncompletemenu1;
		startCounter.enabled = true;
		StartCoroutine(coutnertto());
    }

    // Update is called once per frame
    void Update()
    {

		//CountDownTimer

		if(startCounter.text != "GO"){
			startCounter.text = start.ToString();
		}
		if(start == 0 && checkcounter==false){
			startCounter.text = "GO";
			checkcounter=true;
			othercam.SetActive(false);
			firstanimcam.SetActive(true);
			StartCoroutine(caractive());
			pechlaybtn.SetActive(false);
		}
//		if(PlayerPrefs.GetInt("firstcol") == 1 && PlayerPrefs.GetInt("secondcol") == 1)
//		{
//			if(check==true){
//				Time.timeScale=1f;
//				PlayerPrefs.SetInt("Level",1);
//				missioncompletemenu.SetActive(true);
//			}
//			else
//			{
//				Time.timeScale=0f;
//				PlayerPrefs.SetInt("Level",1);
//				missioncompletemenu.SetActive(true);
//			}
//		}



		//Time
		timer -= Time.deltaTime;
	

		min = Mathf.Floor(timer / 60);
		sec = timer % 60;
		if(sec > 60){
			sec = 59;
		}
		//minText.text=min.ToString();
		//secText.text=sec.ToString();
		minText.text = string.Format("{00:00}:{01:00}", min, sec);

		if(timer == 0){
			Missionfailedmenu.SetActive(true);
		}



		//statstimer.text = string.Format("{00:00}:{1:00}", min, sec);
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
		Application.LoadLevel("GamePlay");
	}
	public void nextonmissionComplete()
	{
		if(PlayerPrefs.GetInt("Level")==1){
			Time.timeScale=1f;
			check=true;
			Application.LoadLevel("Trafficlightscene");
		}
	}
	public void MainMenubtn()
	{
		Time.timeScale=1f;
		check=true;
		Application.LoadLevel("MainMenu");
	}
	public void leftind()
	{
		if(indcheck==false){
			leftindicator.SetActive(true);
			rightindicator.SetActive(false);
			indcheck=true;
		}
		else if(indcheck==true){
			leftindicator.SetActive(false);
			rightindicator.SetActive(false);
			indcheck=false;
		}
	}
	public void rightind()
	{
		if(indcheck1==false){
			leftindicator.SetActive(false);
			rightindicator.SetActive(true);
			indcheck1=true;
		}
		else if(indcheck1==true){
			leftindicator.SetActive(false);
			rightindicator.SetActive(false);
			indcheck1=false;
		}
	}
	public void bothleftrightind()
	{
		if(indcheck2==false){
			leftindicator.SetActive(true);
			rightindicator.SetActive(true);
			indcheck2=true;
		}
		else if(indcheck2==true){
			leftindicator.SetActive(false);
			rightindicator.SetActive(false);
			indcheck2=false;
		}
	}
	IEnumerator caractive()
	{
		yield return new WaitForSeconds(7);
		timer = 70f;
		minText.enabled=true;
		firstanimcam.SetActive(false);
		startCounter.enabled = false;
		if(PlayerPrefs.GetInt("Car")==0)
		{
			Car1.SetActive(true);
			pechlaybtn.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("Car")==1){
			Car2.SetActive(true);
			pechlaybtn.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("Car")==2){
			Car3.SetActive(true);
			pechlaybtn.SetActive(true);
		}
	}
	IEnumerator coutnertto()
	{
		yield return new WaitForSeconds(1);
		start = 2;
		yield return new WaitForSeconds(1);
		start = 1;
		yield return new WaitForSeconds(1);
		start = 0;
	}
}
