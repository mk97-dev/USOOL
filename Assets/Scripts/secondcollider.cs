using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondcollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		PlayerPrefs.SetInt("secondcol",0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter(Collider col2){
		if(col2.gameObject.tag=="Player"){
			PlayerPrefs.SetInt("secondcol",1);
		}
	}
	void OnTriggerExit(Collider col3){
		if(col3.gameObject.tag=="Player"){
			PlayerPrefs.SetInt("secondcol",0);
		}
	}
}
