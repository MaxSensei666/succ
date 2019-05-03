using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGrapplingHook : MonoBehaviour
{
    [BeforeStart]
    public float maxForce;

    private TargetJoint2D joint;

    void Start() {
        joint = gameObject.AddComponent<TargetJoint2D>();
        joint.maxForce = maxForce;
        joint.enabled = false;
    }

    void CreateGrapplingHook(Vector2 worldSpaceTarget) {
        if(!joint.enabled) {
            RaycastHit2D raycast = Physics2D.Raycast(transform.position, worldSpaceTarget-(Vector2)transform.position);
            if(!raycast) return;
            joint.enabled = true;
            joint.target = raycast.point;
        }
    }

    void DestroyGrapplingHook() {
        if(joint.enabled) {
            joint.enabled = false;
        }
    }
}
