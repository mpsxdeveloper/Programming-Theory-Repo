using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color
{

    private Color32 color;

    // ENCAPSULATION
    public Color32 RandomColor {
        get {
            int r = Random.Range(0, 255);
            int g = Random.Range(0, 255);
            int b = Random.Range(0, 255);
            Color32 color = new Color32((byte)r, (byte)g, (byte)b, 255);
            return color;
        }
    }

    // POLYMORPHISM
    public virtual void NewPrefab() {
        Debug.Log("Prefab created");
    }

}