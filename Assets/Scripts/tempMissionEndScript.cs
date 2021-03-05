using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tempMissionEndScript : MonoBehaviour
{
    public TextMeshProUGUI score,rulesFollowed,rulesBroken;
    public Text lowScoreText;
    // Start is called before the first frame update
    void Start()
    {
      
        score.text =indicatorLights.score.ToString();
        rulesFollowed.text = indicatorLights.rulesFollowed.ToString();
        rulesBroken.text = indicatorLights.rulesBroken.ToString();
        
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
