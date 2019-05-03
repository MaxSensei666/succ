using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : MonoBehaviour {
    void Update() {
        if(Input.GetMouseButtonDown(1)) {
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SendMessage("CreateGrapplingHook", worldPosition);
        }   
        else if(Input.GetMouseButtonUp(1)) {
            SendMessage("DestroyGrapplingHook");
        } 
    }    
}