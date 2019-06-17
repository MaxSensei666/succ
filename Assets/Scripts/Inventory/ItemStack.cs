using System.Collections.Generic;
using UnityEngine;

public class ItemStack : ItemInventory
{
    protected Stack<GameObject> stack;

    protected void Start() {
        stack = new Stack<GameObject>();
    }

    public override void Add(GameObject item) {
        stack.Push(item);
    }

    public override GameObject Pop() {
        return stack.Pop();
    }

    public override GameObject Peek() {
        return stack.Peek();
    }
}
