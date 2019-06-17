using System.Collections.Generic;
using UnityEngine;

public class ItemQueue : ItemInventory
{
    protected Queue<GameObject> queue;

    protected void Start() {
        queue = new Queue<GameObject>();
    }

    public override void Add(GameObject item) {
        queue.Enqueue(item);
    }

    public override GameObject Pop() {
        if(queue.Count < 1) return null;
        return queue.Dequeue();
    }

    public override GameObject Peek() {
        return queue.Peek();
    }
}

