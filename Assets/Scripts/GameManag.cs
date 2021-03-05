using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManag : MonoBehaviour
{
	public GameObject Car1;
	public GameObject Car2;
	public GameObject Car3;
    public GameObject Car4;


	public GameObject pechlaybtn;
	public GameObject pausemenu;
	public static GameObject Missionfailedmenu;
	public GameObject pausebtn;
	public GameObject firstanimcam;
	public GameObject missioncompletemenu;
	public int col1,col2;
	public bool check;

    // Start is called before the first frame update
    void Start()
	{
		Time.timeScale=1f;
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

	IEnumerator caractive()
	{
		yield return new WaitForSeconds(1);
		//firstanimcam.SetActive(false);
		
		if(CarSelectionManager.carSelected == 0)
		{
			Car1.SetActive(true);
			//pechlaybtn.SetActive(true);
		}
		else if(CarSelectionManager.carSelected == 1){
			
			Car2.SetActive(true);
			//pechlaybtn.SetActive(true);
		}
		else if(CarSelectionManager.carSelected == 2){
			
			Car3.SetActive(true);
			//pechlaybtn.SetActive(true);
		}
        else if (CarSelectionManager.carSelected == 3)
        {
			
            Car4.SetActive(true);
            //pechlaybtn.SetActive(true);
        }
	}
}
