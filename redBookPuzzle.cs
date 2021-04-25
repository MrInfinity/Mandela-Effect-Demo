using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBookPuzzle : MonoBehaviour
{
    public bool foundPage = false;
    public GameObject bookFullUI;
    public GameObject bookTornUI;
    public GameObject tornPageUI;
    bool bookState = false;
    public MouseLook ML;
    void Start()
    {
        bookFullUI.SetActive(false);
        bookFullUI.SetActive(false);
        tornPageUI.SetActive(false);
    }

    void Update()
    {
        if(bookState && Input.GetMouseButton(1)) {
            bookFullUI.SetActive(false);
            bookTornUI.SetActive(false);
            bookState = false;
            ML.mouseSens = 200f;
        }
        if(foundPage) {
            tornPageUI.SetActive(true);
        }
    }

    public void bookFull() {
        bookFullUI.SetActive(true);
        Destroy(tornPageUI);
        bookState = true;
        ML.mouseSens = 0f;
    }
    public void bookTorn() {
        bookTornUI.SetActive(true);
        bookState = true;
        ML.mouseSens = 0f;
    }
}