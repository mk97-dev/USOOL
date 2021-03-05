using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MainMenuManager : MonoBehaviour
{
   



    public GameObject mainmenupanel;
    public GameObject opitionpanel;
	public GameObject controlpanel;
    public GameObject creditspanel;
    public GameObject exitpanel;
	public GameObject audio;
	public GameObject Offbtn;
	public GameObject Onbtn;
	public GameObject lowbtn;
	public GameObject medbtn;
	public GameObject highbtn;
	public GameObject nextBtn;
	public GameObject steeringbtn;
	public GameObject btnbtn;
	public GameObject tiltbtn;

   

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
	 audio=GameObject.FindGameObjectWithTag("Audio");

		if (PlayerPrefs.GetInt ("music") == 0) { //0 matlab on
			audio.GetComponent<AudioSource>().volume=1f;
			Onbtn.GetComponent<Image> ().color = Color.green;
			Offbtn.GetComponent<Image> ().color = Color.white;
		}
		if (PlayerPrefs.GetInt ("music") == 1) { //1 matlab off
			audio.GetComponent<AudioSource>().volume=0f;
			Offbtn.GetComponent<Image> ().color = Color.green;
			Onbtn.GetComponent<Image> ().color = Color.white;
		}
		if (PlayerPrefs.GetInt ("quality") == 0) { //5 matlab Start Quality
			QualitySettings.SetQualityLevel (5);
			highbtn.GetComponent<Image> ().color = Color.green;
			medbtn.GetComponent<Image> ().color = Color.white;
			lowbtn.GetComponent<Image> ().color = Color.white;
		}
		if (PlayerPrefs.GetInt ("quality") == 1) { //3 matlb medium
			QualitySettings.SetQualityLevel (3);
			medbtn.GetComponent<Image> ().color = Color.green;
			lowbtn.GetComponent<Image> ().color = Color.white;
			highbtn.GetComponent<Image> ().color = Color.white;
		}
		if (PlayerPrefs.GetInt ("quality") == 2) { //1 matlab loww
			QualitySettings.SetQualityLevel (1);
			lowbtn.GetComponent<Image> ().color = Color.green;
			medbtn.GetComponent<Image> ().color = Color.white;
			highbtn.GetComponent<Image> ().color = Color.white;

		}
		if (PlayerPrefs.GetInt ("control") == 0) {
			RCC_Settings.instance.useSteeringWheelForSteering = true;
			RCC_Settings.instance.useAccelerometerForSteering = false;
			steeringbtn.GetComponent<Image> ().color = Color.green;
			btnbtn.GetComponent<Image> ().color = Color.white;
			tiltbtn.GetComponent<Image> ().color = Color.white;
		}
		if (PlayerPrefs.GetInt ("control") == 1) {
			RCC_Settings.instance.useSteeringWheelForSteering = false;
			RCC_Settings.instance.useAccelerometerForSteering = false;
			steeringbtn.GetComponent<Image> ().color = Color.white;
			btnbtn.GetComponent<Image> ().color = Color.green;
			tiltbtn.GetComponent<Image> ().color = Color.white;
		}
		if (PlayerPrefs.GetInt ("control") == 2) {
			RCC_Settings.instance.useSteeringWheelForSteering = false;
			RCC_Settings.instance.useAccelerometerForSteering = true;
			steeringbtn.GetComponent<Image> ().color = Color.white;
			btnbtn.GetComponent<Image> ().color = Color.white;
			tiltbtn.GetComponent<Image> ().color = Color.green;
		}


      

    }

    public void playbtnfunc()
    { 
		Application.LoadLevel ("CarSelection 1");
		
    }
	public void freePlayFunc()
    { 
		Application.LoadLevel ("FreePlayScene");
		
    }

	public void controlbtnfunc()
	{
		controlpanel.SetActive (true);
		opitionpanel.SetActive (false);
		mainmenupanel.SetActive (false);
		creditspanel.SetActive (false);
		exitpanel.SetActive (false);
	}

    public void opitionbtnfunc()
    {
		controlpanel.SetActive (false);
		opitionpanel.SetActive (true);
		mainmenupanel.SetActive (false);
		creditspanel.SetActive (false);
		exitpanel.SetActive (false);
    }

    public void creditbtnfunc()
    {
		controlpanel.SetActive (false);
		creditspanel.SetActive (true);
		mainmenupanel.SetActive (false);
		opitionpanel.SetActive (false);
		exitpanel.SetActive (false);
    }

    public void exitbtnfunc()
    {
		controlpanel.SetActive (false);
		exitpanel.SetActive (true);
		mainmenupanel.SetActive (false);
		opitionpanel.SetActive (false);
		creditspanel.SetActive (false);
    }

	public void yesbtnfunc()
	{
		Application.Quit ();
	}
	public void nobtnfunc()
	{
		exitpanel.SetActive (false);
		mainmenupanel.SetActive (true);
		opitionpanel.SetActive (false);
		creditspanel.SetActive (false);
		controlpanel.SetActive (false);
	}
	public void musiconfunc()
	{
		PlayerPrefs.SetInt ("music", 0);
		Onbtn.GetComponent<Image> ().color = Color.green;
		//audio.SetActive (true);                 simple solution
	}
	public void musicofffunc()
	{
		PlayerPrefs.SetInt ("music", 1);
		//audio.SetActive (false);                simple solution
	}
	public void lowquality()
	{
		PlayerPrefs.SetInt ("quality", 2);
		//QualitySettings.SetQualityLevel (1);
	}
	public void medquality()
	{
		PlayerPrefs.SetInt ("quality", 1);
		//QualitySettings.SetQualityLevel (3);		
	}
	public void highquality()
	{
		PlayerPrefs.SetInt ("quality", 0);
		//QualitySettings.SetQualityLevel (5);	
	}
	public void steering()
	{
		
		PlayerPrefs.SetInt("control",0);
	}

	public void buttons()
	{

		PlayerPrefs.SetInt("control",1);
	}

	public void tild()
	{

		PlayerPrefs.SetInt("control",2);
	}
}