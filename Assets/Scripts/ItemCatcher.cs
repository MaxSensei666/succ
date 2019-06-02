using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemCatcher : MonoBehaviour
{
    protected Queue<GameObject> inventory;

    protected void Start() {
        inventory = new Queue<GameObject>();
    }

    protected private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Item") {
            GameObject otherObject = other.gameObject;
            otherObject.SetActive(false);
            inventory.Enqueue(otherObject);
        }
    }
}

