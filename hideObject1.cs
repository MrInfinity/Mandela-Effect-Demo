using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideObject1 : MonoBehaviour
{
    public redBookPuzzle RBP;

    public GameObject thisObject;

    void Update()
    {
        if(RBP.foundPage) {
            thisObject.SetActive(false);
        }
    }
}