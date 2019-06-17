using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyButtons;


public class TrashSpawner : MonoBehaviour
{
    public GameObject trashPrefab;

    public int quantity;

    public float minScale = 0.1f;
    public float maxScale = 1f;

    [BeforeStart]
    public bool burstOnStart = true;

    protected void Start() {
        Burst();
    }

    [Button]
    public void Burst() {
        for(int i = 0; i < quantity; i++) {
            GameObject trash = Instantiate(trashPrefab, transform.position, Quaternion.identity);
            trash.transform.localScale = new Vector3(Random.Range(minScale, maxScale), Random.Range(minScale, maxScale));
        }
    }
}

