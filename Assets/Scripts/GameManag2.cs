using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManag2 : MonoBehaviour
{
	public GameObject Car1;
	public GameObject Car2;
	public GameObject Car3;
	public GameObject pausemenu;
	public GameObject Missionfailedmenu;
	public GameObject pausebtn;
	public GameObject firstanimcam;
	public GameObject missioncompletemenu;
	public float speed;
	public int col1,col2;
	public bool chck;
	public GameObject beltslider;
	public float slidervalue;


    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(caractive());

    }

    // Update is called once per frame
    void Update()
    {
       speed = RCC_UIDashboardDisplay.inputs.KMH;
		slidervalue = beltslider.GetComponent<Slider>().value; 
		if(slidervalue == 1){

					}


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
		Application.LoadLevel("MissionSpeed");
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
