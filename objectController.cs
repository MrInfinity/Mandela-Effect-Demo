using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class objectController : MonoBehaviour
{
    [SerializeField] private string objectName;
    [TextArea] [SerializeField] private string itemDesc;
    [SerializeField] private inspectController inspectController;

    public GameObject table;
    public GameObject bottle;
    public GameObject closedChest;
    public GameObject openChest;
    public GameObject openedChest;
    public GameObject redBook;
    public GameObject candle;
    public wantedPosterPuzzle WPP;
    public redBookPuzzle RBP;
    public candlePuzzle canP;
    public GameObject jumpText;

    public void ShowObjectName() {
        inspectController.ShowName(objectName);
    }

    public void HideObjectName() {
        inspectController.HideName();
    }

    public void ShowDesc() {
        inspectController.ShowDesc(itemDesc);
        if(table && !WPP.foundPaper){
            WPP.foundPaper = true;
            table.tag = "Untagged";
        }
        if(bottle && !RBP.foundPage){
            RBP.foundPage = true;
            bottle.tag = "Untagged";
        }
        if(redBook && !RBP.foundPage) {
            RBP.bookTorn();
        }
        if(redBook && RBP.foundPage) {
            RBP.bookFull();
            itemDesc = "Now this makes a lot more sense.";
        }
        if(closedChest){
            closedChest.SetActive(false);
            openedChest.SetActive(true);
        }
        if(openChest){
            jumpText.SetActive(true);
        }
        
        if(candle && RBP.foundPage) {
            canP.lightsOut();
            itemDesc = "oh wow...it's dark.";
        }
        if(candle && canP.doOnce == 1) {
            itemDesc = "";
            objectName = "";
        }
    }

    void Update() {
        if(openChest && Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene("Level02");
        }
    }
}