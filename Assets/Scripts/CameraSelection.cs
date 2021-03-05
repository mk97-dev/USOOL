using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSelection : MonoBehaviour
{
	public GameObject Camera1;
	public GameObject Camera2;
	public GameObject Camera3;
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	public void cameraFunction(){
		if(Camera1.activeInHierarchy){
			Camera1.SetActive(false);
			Camera2.SetActive(true);
			Camera3.SetActive(false);
		}
		else if(Camera2.activeInHierarchy){
			Camera1.SetActive(false);
			Camera2.SetActive(false);
			Camera3.SetActive(true);
		}
		else if(Camera3.activeInHierarchy){
			Camera1.SetActive(true);
			Camera2.SetActive(false);
			Camera3.SetActive(false);
		}
	}
}
