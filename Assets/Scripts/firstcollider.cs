using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstcollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		PlayerPrefs.SetInt("firstcol",0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="Player"){
			PlayerPrefs.SetInt("firstcol",1);
		}
	}
	void OnTriggerExit(Collider col1){
		if(col1.gameObject.tag=="Player"){
			PlayerPrefs.SetInt("firstcol",0);
		}
	}
}
