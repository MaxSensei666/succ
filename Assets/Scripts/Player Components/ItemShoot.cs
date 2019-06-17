using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemShoot : MonoBehaviour
{
    [BeforeStart]
    public float shootForceMultiplier;

    protected ItemShooter itemShooter;

    protected void Start() {
        itemShooter = gameObject.AddComponent<ItemShooter>();
        itemShooter.force = shootForceMultiplier;
    }

    protected void OnDisable() {
        itemShooter.enabled = false;
    }

    protected void OnEnable() {
        itemShooter.enabled = true;
    }
}
