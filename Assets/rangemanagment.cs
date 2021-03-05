using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rangemanagment : MonoBehaviour
{
	public Text warningtext;
	int count=0;
	bool check=false;
	bool check2=false;
	bool check3=false;
	bool check4=false;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(count==1 && check2==false)
		{
			check2=true;
			warningtext.enabled=true;
			StartCoroutine(warningtextdeactive());
		}
		else if(count==2 && check3==false){
			check3=true;
			warningtext.enabled=true;
			StartCoroutine(warningtextdeactive());
		}
		else if(count==3 && check4==false){
			check4=true;
			Time.timeScale=0f;
			GameManag3.Missionfailedmenu.SetActive(true);
		}
    }
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="TrafficCar" && check==false)
		{
			count=count+1;
			check=true;
		}
	}
	void OnTriggerExit(Collider col1){
		if(col1.gameObject.tag=="TrafficCar"){
			check=false;
		}
	}
	IEnumerator warningtextdeactive()
	{
		yield return new WaitForSeconds(4);
		warningtext.enabled=false;
	}
}
