using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedCheckMissionEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
