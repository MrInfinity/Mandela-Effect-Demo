using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inspectController : MonoBehaviour
{
    [SerializeField] private GameObject objectNameBG;
    [SerializeField] private Text objectNameUI;
    [SerializeField] private float onScreenTimer;
    [SerializeField] private Text itemDescUI;
    [SerializeField] private GameObject itemDescBG;
    [HideInInspector] public bool startTimer;
    private float timer;

    private void Start() {
        objectNameBG.SetActive(false);
        itemDescBG.SetActive(false);
    }

    private void Update() {
        if(startTimer) {
            timer -= Time.deltaTime;

            if(timer <= 0) {
                timer = 0;
                ClearDesc();
                startTimer = false;
            }
        }
    }

    public void ShowName(string objectName) {
        objectNameBG.SetActive(true);
        objectNameUI.text = objectName;
    }

    public void HideName() {
        objectNameBG.SetActive(false);
        objectNameUI.text = "";
    }

    public void ShowDesc(string newInfo) {
        timer = onScreenTimer;
        startTimer = true;
        itemDescBG.SetActive(true);
        itemDescUI.text = newInfo;
    }

    void ClearDesc() {
        itemDescBG.SetActive(false);
        itemDescUI.text = "";
    }
}