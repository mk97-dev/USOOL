using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indicatorLights : MonoBehaviour
{
    public GameObject cubeRight, cubeLeft, brakeLightRight, brakeLightLeft;
    public GameObject redlightonA,redlightonB,redlightonC,redlightonD;
	public GameObject greenlightonA,greenlightonB,greenlightonC,greenlightonD;
	public GameObject yellowlightonA,yellowlightonB,yellowlightonC,yellowlightonD;

    public Animator indicatorBlinking;

    public static bool generalIndicator = false, rightIndicator = false, LeftIndicator = false , trafficLightFlag = false;
    public bool chowk1Col1 = false ,chowk1Col2 = false,chowk1Col3=false,chowk1Col4=false,chowk1Col6 = false,chowk1Col5 = false,chowk1Col7 = false,chowk1Col8 = false;
    public bool isButton;
    public bool brakeLight = false;
    public string buttonName;
    public static int score = 0,rulesFollowed = 0,rulesBroken = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

         if (Input.GetAxis("DButton") > 0.0f || Input.GetKey(KeyCode.B))
        {
           
            Application.LoadLevel ("missionEndTempSpeedCheck");
        }
       



        //----------------------------BRAKES LIGHTS FUNTIONALITY-----------------------------//

        if (Input.GetAxis("accelerator") > 0.0f || Input.GetKey(KeyCode.B))
        {
           
            brakeLight = true;
           
            Invoke("startBrakeLight", 0.0f);
        }

        else if (Input.GetAxis("accelerator") == 0.0f || Input.GetKeyUp(KeyCode.B))
        {

            brakeLight = false;
            Invoke("stopBrakeLight", 0.0f);
        }


        //----------------------------INDICATOR LIGHTS FUNTIONALITY-----------------------------//



        if (Input.GetButton("BButton") || Input.GetKeyDown(KeyCode.Space))
        {
               
            if (rightIndicator == false)
            {

                StartCoroutine(startIndicator("right"));

                // indicatorBlinking.Play("RightIndicatorAnim");

            }

            else
            {

                Invoke("stopIndicator", 0.3f);

            }
        }

        else if (Input.GetButton("AButton") || Input.GetKeyDown(KeyCode.A))
        {

            if (LeftIndicator == false)
            {


                StartCoroutine(startIndicator("Left"));

                // indicatorBlinking.Play("LeftIndicatorAnim");

            }

            else
            {
                Invoke("stopIndicator", 0.3f);
            }
        }


    }


    //======================Helper Methods=========================//


    IEnumerator startIndicator(string side)
    {

        yield return new WaitForSeconds(0.2f);
        if (side == "right")
        {

            rightIndicator = true;
            LeftIndicator = false;
            generalIndicator = true;

            indicatorBlinking.Play("rightIndicatorAnim");

        }

        else
        {
            rightIndicator = false;
       
       
       
       
       
       
            LeftIndicator = true;
            generalIndicator = true;
            indicatorBlinking.Play("leftIndicatorAnim");
        }


    }

    public void stopIndicator()
    {

        rightIndicator = false;
        LeftIndicator = false;
        generalIndicator = false;
        indicatorBlinking.Play("stopIndicator");
    }

    public void startBrakeLight()
    {
        

        brakeLightRight.SetActive(true);
        brakeLightLeft.SetActive(true);

    }
    public void stopBrakeLight()
    {

        brakeLightRight.SetActive(false);
        brakeLightLeft.SetActive(false);

    }


    void OnTriggerEnter(Collider col)
    {


       /* if (redLight.activeInHierarchy == true && trafficLightFlag == false){
            Debug.Log("you have crossed the indicator illegaly.");
        trafficLightFlag = true;

            score--;
            Debug.Log(score);
        }*/
        


        if (col.gameObject.name == "chowk1Col1")
        {
            if(redlightonA.activeInHierarchy == true ){
                score--;
                rulesBroken++;
                Debug.Log("Rule Broken");
            }
            else if (redlightonA.activeInHierarchy == false){
                score++;
                rulesFollowed++;
                Debug.Log("Rule followed");
            }
            chowk1Col1 = true;
            chowk1Col2 = false;
            chowk1Col3 = false;
            chowk1Col4 = false;
            chowk1Col5 = false;
            chowk1Col6 = false;
            chowk1Col7 = false;
            chowk1Col8 = false;

        }
         if (col.gameObject.name == "chowk1Col3")
        {
            if(redlightonC.activeInHierarchy == true ){
                score--;
                rulesBroken++;
                Debug.Log("Rule Broken");
            }
            else if (redlightonC.activeInHierarchy == false){
                score++;
                rulesFollowed++;
                 Debug.Log("Rule followed");
            }
            chowk1Col1 = false;
            chowk1Col2 = false;
            chowk1Col3 = true;
            chowk1Col4 = false;
            chowk1Col5 = false;
            chowk1Col6 = false;
            chowk1Col7 = false;
            chowk1Col8 = false;
        }
         if (col.gameObject.name == "chowk1Col6")
        {
            if(redlightonB.activeInHierarchy == true ){
                score--;
                rulesBroken++;
                Debug.Log("Rule Broken");
            }
            else if (redlightonB.activeInHierarchy == false){
                score++;
                rulesFollowed++;
                 Debug.Log("Rule followed");
                 
            }
            
            chowk1Col1 = false;
            chowk1Col2 = false;
            chowk1Col3 = false;
            chowk1Col4 = false;
            chowk1Col5 = false;
            chowk1Col6 = true;
            chowk1Col7 = false;
            chowk1Col8 = false;
        }
         if (col.gameObject.name == "chowk1Col8")
        {
            if(redlightonD.activeInHierarchy == true ){
                score--;
                rulesBroken++;
                Debug.Log("Rule Broken");
            }
            else if (redlightonD.activeInHierarchy == false){
                score++;
                rulesFollowed++;
                 Debug.Log("Rule followed");
                
            }
            chowk1Col1 = false;
            chowk1Col2 = false;
            chowk1Col3 = false;
            chowk1Col4 = false;
            chowk1Col5 = false;
            chowk1Col6 = false;
            chowk1Col7 = false;
            chowk1Col8 = true;
        }

        if(col.gameObject.name == "chowk1Col2"){

            trafficLightFlag = false;

            if (LeftIndicator == true && chowk1Col1 == true)
            {
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
                //missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            }
            else if (rightIndicator == true && chowk1Col3 == true){
                
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
                //missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            
            }
             else if (rightIndicator == false && LeftIndicator == false && chowk1Col8 == true){
                
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
                //missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            
            }
            else
            {
                Debug.Log("sed lyf");
                indicatorBlinking.Play("stopIndicator");
                //missionFail.SetActive(true);
                score--;
                rulesBroken++;
                Debug.Log(score);

            }
        }
        if (col.gameObject.name == "chowk1Col4")
        {
            trafficLightFlag = false;
            if (rightIndicator == true && chowk1Col1 == true)
            {
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
               // missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            }
            else if (LeftIndicator == true && chowk1Col3 == true){
                
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
                //missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            
            }
            else if (rightIndicator == false && LeftIndicator == false && chowk1Col6 == true){
                
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
                //missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            
            }
            else
            {
                Debug.Log("sed lyf");
                indicatorBlinking.Play("stopIndicator");
               // missionFail.SetActive(true);
               rulesBroken++;
                score--;
                Debug.Log(score);

            }
        }

         if (col.gameObject.name == "chowk1Col7")
        {
            trafficLightFlag = false;
            if (rightIndicator == true && chowk1Col8 == true)
            {
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
               // missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            }
            else if (LeftIndicator == true && chowk1Col6 == true){
                
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
                //missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            
            }
            else if (rightIndicator == false && LeftIndicator == false && chowk1Col1 == true){
                
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
                //missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            
            }
            else
            {
                Debug.Log("sed lyf");
                indicatorBlinking.Play("stopIndicator");
               // missionFail.SetActive(true);
               rulesBroken++;
                score--;
                Debug.Log(score);

            }
        }

         if (col.gameObject.name == "chowk1Col5")
        {
            trafficLightFlag = false;
            if (rightIndicator == true && chowk1Col6 == true)
            {
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
               // missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            }
            else if (LeftIndicator == true && chowk1Col8 == true){
                
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
                //missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            
            }
            else if (rightIndicator == false && LeftIndicator == false && chowk1Col3 == true){
                
                Debug.Log("congratz");
                indicatorBlinking.Play("stopIndicator");
                //missionComplete.SetActive(true);
                rulesFollowed++;
                score++;
                Debug.Log(score);
            
            }
            else
            {
                Debug.Log("sed lyf");
                indicatorBlinking.Play("stopIndicator");
               // missionFail.SetActive(true);
                rulesBroken++;
                score--;
                Debug.Log(score);

            }
        }
       


    }
}
