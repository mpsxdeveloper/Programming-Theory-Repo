using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Shape : Color
{

    private Vector3 position;

    public Vector3 GeneratePosition() {
        float x = -10f;
        float y = 0.5f;
        float z = Random.Range(-7f, 7f);
        position = new Vector3(x, y, z);
        base.NewPrefab();
        NewPrefab();
        return position;
    }

    // POLYMORPHISM
    public override void NewPrefab() {
        Debug.Log("Prefab created at position: " + position);
    }

}