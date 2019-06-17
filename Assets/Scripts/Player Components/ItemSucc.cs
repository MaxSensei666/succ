using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemSucc : MonoBehaviour
{
    [BeforeStart]
    public GameObject succPrefab;

    [BeforeStart]
    public float maxSizeFactor;

    protected GameObject succObject = null;

    protected void Start() {
        succObject = Instantiate(succPrefab, transform);
        ItemCatcher itemCatcher = succObject.GetComponentInChildren<ItemCatcher>();
        Collider2D succCollider = itemCatcher.GetComponent<Collider2D>();
        itemCatcher.maxSize = succCollider.bounds.size.x * succCollider.bounds.size.y * maxSizeFactor;
    }

    protected void OnDisable() {
        succObject.SetActive(false);
    }

    protected void OnEnable() {
        if(succObject == null) return;
        succObject.SetActive(true);
    }
}