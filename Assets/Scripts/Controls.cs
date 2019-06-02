using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controls : MonoBehaviour {

    public abstract Vector2 Direction { get; }

    protected abstract void Update();
}