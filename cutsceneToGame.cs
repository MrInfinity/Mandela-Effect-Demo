using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutsceneToGame : MonoBehaviour
{
    float Timer = 235f;
    float TimerText = -1f;

    float PPTimer = 33.6f;
    int skip = 0;

    public GameObject skipText;
    public GameObject PressButtonText;
    public GameObject PP;
    public GameObject VP;

    void Start() {
        PressButtonText.SetActive(false);
        skipText.SetActive(false);
        PP.SetActive(false);
        VP.SetActive(false);
    }
    void Update()
    {
        Timer = Timer - Time.deltaTime;
        TimerText = TimerText - Time.deltaTime;
        PPTimer = PPTimer - Time.deltaTime;

        if(Timer <= 0) {
            PressButtonText.SetActive(true);
        }

        if(Input.GetKeyDown("space")) {
            skip += 1;
            TimerText = 5f;
        }

        if(skip == 1) {
            skipText.SetActive(true);
        }

        if(PPTimer <= 0) {
            PP.SetActive(true);
            VP.SetActive(true);
        }

        if(TimerText <= 0) {
            skipText.SetActive(false);
        }

        if(skip == 2) {
            SceneManager.LoadScene("Level01");
        }

        if(Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene("Level01");
        }
    }
}
