using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freePlayManager : MonoBehaviour
{
    public GameObject Car1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1f;
        Car1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
