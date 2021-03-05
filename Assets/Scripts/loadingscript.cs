using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(loadingco());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	IEnumerator loadingco()
	{
		yield return new WaitForSeconds(4.88f);
		Application.LoadLevel("MainMenu");
	}
}
