using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanecheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(PlayerPrefs.GetInt("leftlane")==1 && PlayerPrefs.GetInt("rightlane")==1){
			Debug.Log("MID");
		}
		else if(PlayerPrefs.GetInt("leftlane")==1){
			Debug.Log("LEFT");
		}
		else if(PlayerPrefs.GetInt("rightlane")==1){
			Debug.Log("RIGHT");
		}
    }

	void OnTriggerEnter(Collider col2){
		if(col2.gameObject.tag=="leftlane"){
			PlayerPrefs.SetInt("leftlane",1);
		}
		else if(col2.gameObject.tag=="rightlane"){
			PlayerPrefs.SetInt("rightlane",1);
		}
		else
		{
			PlayerPrefs.SetInt("leftlane",0);
			PlayerPrefs.SetInt("rightlane",0);
			PlayerPrefs.SetInt("midlane",0);
		}
	}
	void OnTriggerExit(Collider col3){
		if(col3.gameObject.tag=="leftlane"){
			PlayerPrefs.SetInt("leftlane",0);
		}
		else if(col3.gameObject.tag=="rightlane"){
			PlayerPrefs.SetInt("rightlane",0);
		}
		else
		{
			
		}
	}
}
