using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Handles dashboard elements.
/// </summary>
[AddComponentMenu("BoneCracker Games/Realistic Car Controller/UI/Dashboard Displayer")]
[RequireComponent (typeof(RCC_DashboardInputs))]



public class speedCheck : MonoBehaviour
{
    // Getting an Instance of Main Shared RCC Settings.
	#region RCC Settings Instance

	private RCC_Settings RCCSettingsInstance;
	private RCC_Settings RCCSettings {
		get {
			if (RCCSettingsInstance == null) {
				RCCSettingsInstance = RCC_Settings.Instance;
			}
			return RCCSettingsInstance;
		}
	}

	#endregion

    public int maxSpeed;
    public int carSpeed;
    public float carSpeedText;
    public static RCC_DashboardInputs inputs;
    public static int overSpeed , WrongLaneChange = 0 , correctLaneChange = 0 , score = 0;
    //public RCC_CarControllerV3 carController;

    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = 50;
        overSpeed = 0;
        inputs = GetComponent<RCC_DashboardInputs>();
       
    }

    // Update is called once per frame
    void Update()
    {
        carSpeedText = RCC_UIDashboardDisplay.inputs.KMH;
        
        carSpeed = (int)carSpeedText;
        

        if(carSpeed > maxSpeed){

            
          
                Debug.Log("overspeeding...");
            
            overSpeed++;
            Debug.Log(overSpeed);
            
        }
    }

    void OnTriggerEnter(Collider col){

            if (col.gameObject.name == "colSpeed80"){
                    maxSpeed = 80;
            }
            
            if (col.gameObject.name == "colSpeed50")
            {
                maxSpeed = 50;
            }

            if (col.gameObject.name == "colSpeed30")
            {
                maxSpeed = 30;
            }
            if (col.gameObject.name == "colSpeed100")
            {
                maxSpeed = 100;
            }

            if (col.gameObject.name == "laneChecker")
            {
                WrongLaneChange++;
                Debug.Log("Wrong Lane");
            }

            if (col.gameObject.name == "laneCheckerDoubleRoad")
            {
                if(indicatorLights.generalIndicator == false){
                    WrongLaneChange++;
                    score--;
                        Debug.Log("Wrong lane changed.");
                }
                 if(indicatorLights.generalIndicator == true){
                    correctLaneChange++;
                    score++;
                        Debug.Log("correct lane changed.");
                }
                
            }

    }
}
