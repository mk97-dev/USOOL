using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tempMissionEndSpeedCheck : MonoBehaviour
{
   public TextMeshProUGUI score,rulesFollowed,rulesBroken , overSpeeding , wrongChangeLane , correctLaneChange;
    // Start is called before the first frame update
    void Start()
    {
      
        score.text =indicatorLights.score.ToString();
        rulesFollowed.text = indicatorLights.rulesFollowed.ToString();
        rulesBroken.text = indicatorLights.rulesBroken.ToString();
        overSpeeding.text = (speedCheck.overSpeed/60).ToString();
        wrongChangeLane.text = speedCheck.WrongLaneChange.ToString();
        correctLaneChange.text = speedCheck.correctLaneChange.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void restartMissionFunc(){
        Application.LoadLevel ("FinalRaceSceneSpeedCheck");
    }

    public void nextMissionFunc(){
        Application.LoadLevel ("FinalRaceSceneSpeedCheck");
    }
     public void mainMenuFunc(){
        Application.LoadLevel ("MainMenu");
    }
}
