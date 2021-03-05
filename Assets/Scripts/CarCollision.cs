using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollision : MonoBehaviour
{
    // Start is called before the first frame update
	

	void OnCollisionEnter(Collision otherObj) {
		if (otherObj.gameObject.tag == "Walls") {
			Time.timeScale=0f;
			Application.LoadLevel("parkingMissionFail");
			
		}
		
	}

	void OnTriggerEnter(Collider otherObj){
			if(otherObj.gameObject.tag == "endPoint"){
			Time.timeScale=0f;
			Application.LoadLevel("parkingMissionComplete");
		}
	}

}
