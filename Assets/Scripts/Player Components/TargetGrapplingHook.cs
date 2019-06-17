using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGrapplingHook : MonoBehaviour
{
    [BeforeStart]
    public float maxForce;

    [BeforeStart]
    public float maxLength = Mathf.Infinity;

    [BeforeStart]
    public Material lineRendererMaterial;

    [BeforeStart]
    public AnimationCurve lineRendererWidthCurve;

    [BeforeStart]
    public Color lineRendererColor;

    protected Controls controls;
    protected TargetJoint2D joint;
    protected LineRenderer lineRenderer;

    protected void Start() {
        controls = gameObject.GetComponentInParent<Controls>();

        joint = gameObject.AddComponent<TargetJoint2D>();
        joint.maxForce = maxForce;
        joint.enabled = false;

        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = lineRendererMaterial;
        lineRenderer.widthCurve = lineRendererWidthCurve;
        lineRenderer.startColor = lineRendererColor;
        lineRenderer.endColor = lineRendererColor;
        lineRenderer.enabled = false;
    }

    public void GrapplingHookDown() {
        if(!joint.enabled) {
            RaycastHit2D raycast = Physics2D.Raycast(transform.position, controls.Direction, maxLength, LayerMask.GetMask(new string[] {"Wall"}));
            if(!raycast) return;

            joint.enabled = true;
            joint.target = raycast.point;
            
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, raycast.point);
        }
    }

    public void GrapplingHookUp() {
        if(joint.enabled) {
            joint.enabled = false;
            lineRenderer.enabled = false;
        }
    }

    protected void OnDisable() {
        joint.enabled = false;
        lineRenderer.enabled = false;
    }

    protected void Update() {
        if(lineRenderer.enabled) {
            lineRenderer.SetPosition(0, transform.position);
        }
    }

    //No OnEnable() ?
}
