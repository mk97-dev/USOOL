using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenlgihtcollider : MonoBehaviour
{
	// Start is called before the first frame update
	
	void Start()
	{
		PlayerPrefs.SetInt("greenlight",0);
	}

	// Update is called once per frame
	void Update()
	{

	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="Player"){
			PlayerPrefs.SetInt("greenlight",1);
		}
	}
}
