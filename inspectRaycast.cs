using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inspectRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    private objectController raycastedObj;

    [SerializeField] private Image crosshair;
    
    private bool isCrosshairActive;
    private bool doOnce;

    private void Update() {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, layerMaskInteract.value)) {
            if(hit.collider.CompareTag("InteractObject")) {
                if(!doOnce) {
                    raycastedObj = hit.collider.gameObject.GetComponent<objectController>();
                    raycastedObj.ShowObjectName();
                    CrosshairChange(true);
                }
                isCrosshairActive = true;
                doOnce = true;

                if(Input.GetMouseButton(0)) {
                    raycastedObj.ShowDesc();
                }
            }
        } else {
            if (isCrosshairActive) {
                raycastedObj.HideObjectName();
                CrosshairChange(false);
                doOnce = false;
            }
        }
    }

    void CrosshairChange(bool on) {
        if(on && !doOnce) {
            crosshair.color = Color.red;
        } else {
            crosshair.color = Color.white;
            isCrosshairActive = false;
        }
    }
}