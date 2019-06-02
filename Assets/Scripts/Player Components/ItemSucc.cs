using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemSucc : MonoBehaviour
{
    [BeforeStart]
    public GameObject succPrefab;
    
    protected GameObject succObject = null;

    protected void Start() {
        succObject = Instantiate(succPrefab, transform);
    }

    protected void OnDisable() {
        succObject.SetActive(false);
    }

    protected void OnEnable() {
        if(succObject == null) return;
        succObject.SetActive(true);
    }
}