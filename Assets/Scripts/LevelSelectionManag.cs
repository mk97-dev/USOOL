using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSelectionManag : MonoBehaviour
{
	public GameObject level2btn;
	public Sprite lockimage;
	public Sprite normalimage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(PlayerPrefs.GetInt("Level")==1){
			level2btn.GetComponent<Button>().interactable=true;
			level2btn.GetComponent<Image>().sprite=normalimage;
		}
		else{
			level2btn.GetComponent<Button>().interactable=false;
			level2btn.GetComponent<Image>().sprite=lockimage;
		}
    }  
	public void backbtn()
	{
		Application.LoadLevel("CarSelection");
	}
	public void level1click()
	{
		Application.LoadLevel("GamePlay");
	}
	public void level2click()
	{
		Application.LoadLevel("Trafficlightscene");
	}
}
