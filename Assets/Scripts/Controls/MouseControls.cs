using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : Controls {

    public override Vector2 Direction {
        get {
            Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return (worldMousePosition-(Vector2)transform.position).normalized;
        }
    }

    protected override void Update() {
        if(Input.GetMouseButtonDown(1)) {
            BroadcastMessage("GrapplingHookDown");
        }   
        if(Input.GetMouseButtonUp(1)) {
            BroadcastMessage("GrapplingHookUp");
        }
        if(Input.GetMouseButtonDown(0)) {
            BroadcastMessage("ShootDown");
        }
        if(Input.GetMouseButtonUp(0)) {
            BroadcastMessage("ShootUp");
        }
    }    
}