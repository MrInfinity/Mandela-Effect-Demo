using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class glyphPuzzle : MonoBehaviour
{
    public string glyphStringJewel;
    public string glyphStringWell;
    public string glyphStringWater;

    public static bool inPuzzle;
    public static bool doorOpened;

    public GameObject puzzleUI;
    public GameObject door;

    public AudioClip doorOpen;
    private AudioSource source;

    public GameObject AButton;
    public GameObject TButton;
    public GameObject RButton;
    public GameObject JButton;

    public Text input;

    public GameObject doorTriggerBox;

    void Start()
    {
        glyphStringJewel = "";
        glyphStringWell = "";
        glyphStringWater = "";
        doorOpened = false;
        source = GetComponent<AudioSource>();

        AButton.SetActive(false);
        TButton.SetActive(false);
        RButton.SetActive(false);
        JButton.SetActive(false);

        puzzleUI.SetActive(false);
        doorTriggerBox.SetActive(true);
        
        input.text = "";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (inPuzzle) {
                Resume();
            } else {
                Pause();
            }
        }

        input.text = glyphStringJewel.ToString();
    }

    public void Resume() {
        Cursor.lockState = CursorLockMode.Locked;
        puzzleUI.SetActive(false);
        Time.timeScale = 1f;
        inPuzzle = false;
    }

    void Pause() {
        Cursor.lockState = CursorLockMode.None;
        puzzleUI.SetActive(true);
        Time.timeScale = 0f;
        inPuzzle = true;
    }

    public void submit() {
        if (glyphStringJewel == "jewel") {
            Debug.Log("JEWEL Found!");
            //source.PlayOneShot (doorOpen);
            door.SetActive(false);
            doorOpened = true;
            doorTriggerBox.SetActive(false);
        } else {
            Debug.Log("NO!");
        }

        if (glyphStringWell == "well") {
            Debug.Log("WELL Found!");
            AButton.SetActive(true);
            TButton.SetActive(true);
            RButton.SetActive(true);
        } else {
            Debug.Log("NO!");
        }

        if (glyphStringWater == "water") {
            Debug.Log("WATER Found!");
            JButton.SetActive(true);
        } else {
            Debug.Log("NO!");
        }

        glyphStringJewel = "";
        glyphStringWell = "";
        glyphStringWater = "";
    }

    public void debugButton() {
        glyphStringJewel = "jewel";
    }

    public void restart() {
        glyphStringJewel = "";
        glyphStringWell = "";
        glyphStringWater = "";
    }

    public void a() {
        glyphStringJewel = glyphStringJewel + "a";
        glyphStringWell = glyphStringWell + "a";
        glyphStringWater = glyphStringWater + "a";
    }

    public void b() {
        glyphStringJewel = glyphStringJewel + "b";
        glyphStringWell = glyphStringWell + "b";
        glyphStringWater = glyphStringWater + "b";
    }

    public void c() {
        glyphStringJewel = glyphStringJewel + "c";
        glyphStringWell = glyphStringWell + "c";
        glyphStringWater = glyphStringWater + "c";
    }

    public void d() {
        glyphStringJewel = glyphStringJewel + "d";
        glyphStringWell = glyphStringWell + "d";
        glyphStringWater = glyphStringWater + "d";
    }

    public void e() {
        glyphStringJewel = glyphStringJewel + "e";
        glyphStringWell = glyphStringWell + "e";
        glyphStringWater = glyphStringWater + "e";
    }

    public void f() {
        glyphStringJewel = glyphStringJewel + "f";
        glyphStringWell = glyphStringWell + "f";
        glyphStringWater = glyphStringWater + "f";
    }

    public void g() {
        glyphStringJewel = glyphStringJewel + "g";
        glyphStringWell = glyphStringWell + "g";
        glyphStringWater = glyphStringWater + "g";
    }

    public void h() {
        glyphStringJewel = glyphStringJewel + "h";
        glyphStringWell = glyphStringWell + "h";
        glyphStringWater = glyphStringWater + "h";
    }

    public void i() {
        glyphStringJewel = glyphStringJewel + "i";
        glyphStringWell = glyphStringWell + "i";
        glyphStringWater = glyphStringWater + "i";
    }

    public void j() {
        glyphStringJewel = glyphStringJewel + "j";
        glyphStringWell = glyphStringWell + "j";
        glyphStringWater = glyphStringWater + "j";
    }

    public void k() {
        glyphStringJewel = glyphStringJewel + "k";
        glyphStringWell = glyphStringWell + "k";
        glyphStringWater = glyphStringWater + "k";
    }

    public void l() {
        glyphStringJewel = glyphStringJewel + "l";
        glyphStringWell = glyphStringWell + "l";
        glyphStringWater = glyphStringWater + "l";
    }

    public void m() {
        glyphStringJewel = glyphStringJewel + "m";
        glyphStringWell = glyphStringWell + "m";
        glyphStringWater = glyphStringWater + "m";
    }

    public void n() {
        glyphStringJewel = glyphStringJewel + "n";
        glyphStringWell = glyphStringWell + "n";
        glyphStringWater = glyphStringWater + "n";
    }

    public void o() {
        glyphStringJewel = glyphStringJewel + "o";
        glyphStringWell = glyphStringWell + "o";
        glyphStringWater = glyphStringWater + "o";
    }

    public void p() {
        glyphStringJewel = glyphStringJewel + "p";
        glyphStringWell = glyphStringWell + "p";
        glyphStringWater = glyphStringWater + "p";
    }

    public void q() {
        glyphStringJewel = glyphStringJewel + "q";
        glyphStringWell = glyphStringWell + "q";
        glyphStringWater = glyphStringWater + "q";
    }

    public void r() {
        glyphStringJewel = glyphStringJewel + "r";
        glyphStringWell = glyphStringWell + "r";
        glyphStringWater = glyphStringWater + "r";
    }

    public void s() {
        glyphStringJewel = glyphStringJewel + "s";
        glyphStringWell = glyphStringWell + "s";
        glyphStringWater = glyphStringWater + "s";
    }

    public void t() {
        glyphStringJewel = glyphStringJewel + "t";
        glyphStringWell = glyphStringWell + "t";
        glyphStringWater = glyphStringWater + "t";
    }

    public void u() {
        glyphStringJewel = glyphStringJewel + "u";
        glyphStringWell = glyphStringWell + "u";
        glyphStringWater = glyphStringWater + "u";
    }

    public void v() {
        glyphStringJewel = glyphStringJewel + "v";
        glyphStringWell = glyphStringWell + "v";
        glyphStringWater = glyphStringWater + "v";
    }

    public void w() {
        glyphStringJewel = glyphStringJewel + "w";
        glyphStringWell = glyphStringWell + "w";
        glyphStringWater = glyphStringWater + "w";
    }

    public void x() {
        glyphStringJewel = glyphStringJewel + "x";
        glyphStringWell = glyphStringWell + "x";
        glyphStringWater = glyphStringWater + "x";
    }

    public void y() {
        glyphStringJewel = glyphStringJewel + "y";
        glyphStringWell = glyphStringWell + "y";
        glyphStringWater = glyphStringWater + "y";
    }

    public void z() {
        glyphStringJewel = glyphStringJewel + "z";
        glyphStringWell = glyphStringWell + "z";
        glyphStringWater = glyphStringWater + "z";
    }
}
