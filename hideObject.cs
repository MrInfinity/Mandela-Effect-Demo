using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideObject : MonoBehaviour
{
    public wantedPosterPuzzle WPP;

    public GameObject thisObject;

    void Update()
    {
        if(WPP.foundPaper) {
            thisObject.SetActive(false);
        }
    }
}