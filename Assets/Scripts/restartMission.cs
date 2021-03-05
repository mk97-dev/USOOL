using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartMission : MonoBehaviour
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
        
        SceneManager.LoadScene("GamePlay");
    }

    public void nextMissionFunc(){
        SceneManager.LoadScene("RULES1");
    }
     public void mainMenuFunc(){
        SceneManager.LoadScene("MainMenu");
    }
}
