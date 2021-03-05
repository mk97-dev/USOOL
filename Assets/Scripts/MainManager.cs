using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
	public GameObject firstMenu;
	public GameObject secondMenu;
	public GameObject thirdMenu;
	public static GameObject audio;
	int i;

    // Start is called before the first frame update
    void Start()
    { 
		 i = 0;
		//PlayerPrefs.SetInt ("music", 0 ); 
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	public void Afun(){
		firstMenu.SetActive (false);
		secondMenu.SetActive (true);
		thirdMenu.SetActive (false);
	}
	public void Bfun(){
		firstMenu.SetActive (false);
		secondMenu.SetActive (false);
		thirdMenu.SetActive (true);
	}
	public void xfun(){
		firstMenu.SetActive (true);
		secondMenu.SetActive (false);
		thirdMenu.SetActive (false);
	}
	public void audiofun(){
		//audio.SetActive (false);
		/*if (PlayerPrefs.GetInt ("music") == 0) {
			audio.SetActive (false);
		} else if (PlayerPrefs.GetInt ("music") == 1) {
			audio.SetActive (true);
		} */
		if (i == 0) {
			audio.SetActive (true);
			i = 1;
		} else if (i == 1) {
			audio.SetActive (false);
			i = 0;
		}

	}





}
