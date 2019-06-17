using UnityEngine;

public abstract class ItemInventory : MonoBehaviour
{
    public abstract void Add(GameObject item);

    public abstract GameObject Pop();

    public abstract GameObject Peek();
}

