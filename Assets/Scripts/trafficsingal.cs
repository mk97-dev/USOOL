using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficsingal : MonoBehaviour
{
	public GameObject redlightonA,redlightonB,redlightonC,redlightonD;
	public GameObject greenlightonA,greenlightonB,greenlightonC,greenlightonD;
	public GameObject yellowlightonA,yellowlightonB,yellowlightonC,yellowlightonD;
	public bool checklights = false;
    // Start is called before the first frame update
    void Start()
    {
        redlightonB.SetActive(true);
		redlightonC.SetActive(true);
		redlightonD.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
		if(checklights==false){
			checklights=true;
			StartCoroutine(lighton());
		}
    }
	IEnumerator lighton(){
		
		greenlightonA.SetActive(true);
		yellowlightonA.SetActive(false);
		yield return new WaitForSeconds(10);
		greenlightonA.SetActive(false);
		yellowlightonA.SetActive(true);

		redlightonB.SetActive(false);
		yellowlightonB.SetActive(true);
		yield return new WaitForSeconds(2);
		redlightonA.SetActive(true);
		yellowlightonA.SetActive(false);
		yellowlightonB.SetActive(false);
		greenlightonB.SetActive(true);
		yield return new WaitForSeconds(10);
		yellowlightonB.SetActive(true);
		greenlightonB.SetActive(false);

		redlightonC.SetActive(false);
		yellowlightonC.SetActive(true);
		yield return new WaitForSeconds(2);
		redlightonB.SetActive(true);
		yellowlightonB.SetActive(false);
		yellowlightonC.SetActive(false);
		greenlightonC.SetActive(true);
		yield return new WaitForSeconds(10);
		yellowlightonC.SetActive(true);
		greenlightonC.SetActive(false);

		yellowlightonD.SetActive(true);
		redlightonD.SetActive(false);
		yield return new WaitForSeconds(2);
		greenlightonD.SetActive(true);
		yellowlightonD.SetActive(false);
		redlightonC.SetActive(true);
		yellowlightonC.SetActive(false);
		yield return new WaitForSeconds(10);
		yellowlightonD.SetActive(true);
		greenlightonD.SetActive(false);
		yellowlightonA.SetActive(true);
		redlightonA.SetActive(false);
		yield return new WaitForSeconds(2);
		redlightonD.SetActive(true);
		yellowlightonD.SetActive(false);
		
		checklights=false;
	}
}
