using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationIsDirection : MonoBehaviour
{
    protected Controls controls;

    protected void Start() {
        controls = gameObject.GetComponentInParent<Controls>();
    }

    protected void FixedUpdate() {
        transform.rotation = Quaternion.FromToRotation(Vector3.up, controls.Direction);
    }
}
