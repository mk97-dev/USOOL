using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class finalMissionEndManager : MonoBehaviour
{
   public Text lowScoreText;
    // Start is called before the first frame update
    void Start()
    {
      
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void restartMissionFunc(){
        Application.LoadLevel ("FinalRaceScene");
    }

    public void nextMissionFunc(){
        if(indicatorLights.score > 4){
        Application.LoadLevel ("RULES2");
        }
        else
        {
            lowScoreText.text = "Your score is too low!!!";
        }
    }
     public void mainMenuFunc(){
        Application.LoadLevel ("MainMenu");
    }
}
