using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemCatcher : MonoBehaviour
{

    public float maxSize;

    protected new Collider2D collider;
    
    protected ItemInventory inventory;

    protected void Start() {
        inventory = GetComponentInParent<ItemInventory>();
        collider = GetComponent<Collider2D>();
    }

    protected private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Item") {
            if(other.bounds.size.x * other.bounds.size.y <= maxSize) {
                GameObject otherObject = other.gameObject;
                otherObject.SetActive(false);
                inventory.Add(otherObject);
            }
        }
    }
}

