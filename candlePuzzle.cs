using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candlePuzzle : MonoBehaviour
{
    public GameObject lights;
    public GameObject posters;
    public GameObject fire;
    public multiChoicePuzzle MCP;

    public int doOnce;

    void Start() {
        doOnce = 0;
    }
    public void lightsOut()
    {
        lights.SetActive(false);
        posters.SetActive(false);
        fire.SetActive(false);
        
        
        if(doOnce == 0) {
            MCP.Questions();
            doOnce = 1;
        }
    }
}