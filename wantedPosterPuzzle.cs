using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wantedPosterPuzzle : MonoBehaviour
{
    public objectController OC;
    public GameObject PaperUI;

    public GameObject tornPoster;
    public GameObject fullPoster;
    public GameObject roof;

    public bool fixingPoster;

    public bool foundPaper;

    void Start() {
        PaperUI.SetActive(false);
        tornPoster.SetActive(true);
        fullPoster.SetActive(false);
        roof.SetActive(true);
    }
    
    void Update() {
        if(foundPaper) {
            PaperUI.SetActive(true);
        }
        if(fixingPoster) {
            tornPoster.SetActive(false);
            fullPoster.SetActive(true);
            PaperUI.SetActive(false);
        }

        Debug.Log("foundPaper: " + foundPaper);
        Debug.Log("fixingPoser: " + fixingPoster);
    }

    void OnTriggerEnter(Collider other)
    {
        if(foundPaper){
            fixingPoster = true;
        }
        Debug.Log("Entered");
    }
}