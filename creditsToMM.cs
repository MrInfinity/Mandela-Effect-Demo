using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditsToMM : MonoBehaviour
{
    float Timer = 25.2f;
    void Update()
    {
        Timer = Timer - Time.deltaTime;

        if(Timer <= 0) {
            SceneManager.LoadScene("mainMenu");
        }
    }
}
