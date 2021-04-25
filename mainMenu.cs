using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject ComingSoon;
    float timer = 0f;
    public void level01() {
        SceneManager.LoadScene("cutScene");
    }

    public void settings() {
        ComingSoon.SetActive(true);
        timer = 5f;
    }

    public void quit() {
        Application.Quit();
    }

    void Update() {
        timer = timer - Time.deltaTime;
        if(timer <= 0 ) {
           ComingSoon.SetActive(false); 
        }
    }
}
