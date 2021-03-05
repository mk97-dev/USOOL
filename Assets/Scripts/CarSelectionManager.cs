using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarSelectionManager : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;
	public static int carSelected = 0;

   // public Animator car1animator;
	//public Animator car2animator;
//	public Animator car3animator;

    // Start is called before the first frame update
    void Start()
    {
      //  car1animator=car1.GetComponent<Animator>();
		//car2animator=car2.GetComponent<Animator>();
		//car3animator=car3.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
   
    }

   // public void BackbtnFunc()
    //{
    //    Application.LoadLevel("MainMenu");
    //}

    //public void LeftbtnFunc()
    //{
		//if (car1.activeInHierarchy)
		//{
		//	car1animator.CrossFadeInFixedTime("car1anim2",0.01f);
		//	StartCoroutine(leftbtncar1());
		//}
		//else if (car2.activeInHierarchy)
		//{
			//car2animator.CrossFadeInFixedTime("car2anim2",0.01f);
		//	StartCoroutine(leftbtncar2());
		//}
		//else if (car3.activeInHierarchy)
		//{
			//car3animator.CrossFadeInFixedTime("car3anim2",0.01f);
			//StartCoroutine(leftbtncar3());
	//	}
    //}

    //public void RightbtnFunc()
    //{
      //  if (car1.activeInHierarchy) {
		//	car1animator.CrossFadeInFixedTime("car1anim2",0.01f);
			//StartCoroutine(rightbtncar1());
        //}
        //else if (car2.activeInHierarchy)
        //{
		//	car2animator.CrossFadeInFixedTime("car2anim2",0.01f);
			//StartCoroutine(rightbtncar2());
        //}
        //else if (car3.activeInHierarchy)
       // {
			/// <summary>
			/// 
			/// </summary>
			/// <param name="?"></param>
//car3animator.CrossFadeInFixedTime("car3anim2",0.01f);
	//		StartCoroutine(rightbtncar3());
      //  }
    //}

//	public void NextbtnFunc(){
	//	if (car1.activeInHierarchy)
		//{
			//PlayerPrefs.SetInt("Car",0);
			//Application.LoadLevel("LevelSelection");
		//}
		//else if (car2.activeInHierarchy)
		//{
			//PlayerPrefs.SetInt("Car",1);
			//Application.LoadLevel("LevelSelection");
	//	}
		//else if (car3.activeInHierarchy)
		//{
		//	PlayerPrefs.SetInt("Car",2);
			//Application.LoadLevel("LevelSelection");
		//}
        //else if (car4.activeInHierarchy)
        //{
         //   PlayerPrefs.SetInt("Car", 3);
           // Application.LoadLevel("LevelSelection");
        //}

//	}

	//IEnumerator leftbtncar1()
//	{
	//	yield return new WaitForSeconds(3);
		//car2.SetActive(false);
		//car1.SetActive(false);
		//car3.SetActive(true);
	//}
	//IEnumerator leftbtncar2()
//	{
	//	yield return new WaitForSeconds(3);
	//	car2.SetActive(false);
	//	car1.SetActive(true);
	//	car3.SetActive(false);
	//}
	//IEnumerator leftbtncar3()
	//{
	//	yield return new WaitForSeconds(3);
	//	car2.SetActive(true);
		//car1.SetActive(false);
		//car3.SetActive(false);
	//}
	//IEnumerator rightbtncar1()
	//{
	//	yield return new WaitForSeconds(3);
		//car2.SetActive(true);
		//car1.SetActive(false);
		//car3.SetActive(false);
	//}
	//IEnumerator rightbtncar2()
	//{
		//yield return new WaitForSeconds(3);
		//car2.SetActive(false);
		//car1.SetActive(false);
		//car3.SetActive(true);
	//}
	//IEnumerator rightbtncar3()
	//{
		//yield return new WaitForSeconds(3);
		//car2.SetActive(false);
		//car1.SetActive(true);
		//car3.SetActive(false);
	//}


    public void car1Selection()
    {
        PlayerPrefs.SetInt("Car", 0);
       carSelected = 0;
        Application.LoadLevel("GamePlay");
    }
    public void car2Selection()
    {
        PlayerPrefs.SetInt("Car", 1);
		carSelected = 1;
        Application.LoadLevel("GamePlay");
    }
    public void car3Selection()
    {
        PlayerPrefs.SetInt("Car", 2);
		carSelected = 2;
        Application.LoadLevel("GamePlay");
    }
    public void car4Selection()
    {
        PlayerPrefs.SetInt("Car", 3);
		carSelected = 3;
        Application.LoadLevel("GamePlay");
    } 
}
