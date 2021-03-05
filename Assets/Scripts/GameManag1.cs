using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManag1 : MonoBehaviour
{
	public GameObject Car1;
	public GameObject Car2;
	public GameObject Car3;
    public GameObject Car4;

	//public GameObject pausemenu;
	//public GameObject Missionfailedmenu;
	//public GameObject pausebtn;
	//public GameObject firstanimcam;
	//public GameObject missioncompletemenu;
	//public GameObject missionfailanim;
	//public GameObject missioncompleteanim;
	//public GameObject policeofficer;
	//public GameObject normalanim;
	//public GameObject Cam1;
	//public GameObject Cam2;
	//public GameObject Cam3;
	//public GameObject Cam4;
	//public GameObject Cam5;
	//public Animator anim;


	public int col1,col2;
	public bool chck;


    // Start is called before the first frame update
    void Start()
    {
		Time.timeScale=1f;
		PlayerPrefs.SetInt("greenlight",0);
		PlayerPrefs.SetInt("redlight",0);
        caractive();
        
        //StartCoroutine(caractive());
    }

    // Update is called once per frame
    void Update()
    {
		//if(PlayerPrefs.GetInt("redlight") == 1 && chck==false)
		//{
          //  Debug.Log ("BAD!!!");
			//StartCoroutine(missionfail());
	//	}
	//	if(PlayerPrefs.GetInt("greenlight") == 1 && chck==false)
	//	{
      //      Debug.Log ("GOOD!!!");
			//StartCoroutine(missioncomplete());
	//	}
    }

	
	
	
	public void MainMenubtn()
	{
		Time.timeScale=1f;
		Application.LoadLevel("MainMenu");
	}

	public void caractive()
	{
		//yield return new WaitForSeconds(5);
		//firstanimcam.SetActive(false);
		
        
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
        else if (PlayerPrefs.GetInt("Car") == 3)
        {
            Car4.SetActive(true);
        }
	}

	//IEnumerator missionfail()
	//{
		//yield return new WaitForSeconds(2);
		//chck=true;
		//missionfailanim.SetActive(true);
		//normalanim.SetActive(false);
		//Cam1.SetActive(true);
		//yield return new WaitForSeconds(3);
		//Cam1.SetActive(false);
		//Cam2.SetActive(true);
		//yield return new WaitForSeconds(8);
		//Cam2.SetActive(false);
		//Cam5.SetActive(true);
		//anim.CrossFadeInFixedTime("Movewalk",0.01f);
		//policeofficer.GetComponent<bezierMove>().enabled=true;
		//yield return new WaitForSeconds(3);
		//policeofficer.GetComponent<bezierMove>().Stop();
		//anim.CrossFadeInFixedTime("chairanim",0.01f);
		//yield return new WaitForSeconds(5);
		//Time.timeScale=0f;
		//Missionfailedmenu.SetActive(true);
	}//


	//IEnumerator missioncomplete()
	//{
		//yield return new WaitForSeconds(2);
		//chck = true;
		//missioncompleteanim.SetActive(true);
		//normalanim.SetActive(false);
		//Cam3.SetActive(true);
		//yield return new WaitForSeconds(3);
		//Cam3.SetActive(false);
		//Cam4.SetActive(true);
		//yield return new WaitForSeconds(12);
		//Time.timeScale=0f;
		//missioncompletemenu.SetActive(true);
	//}
//}
