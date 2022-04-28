using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Shape : Color
{

    public Vector3 GeneratePosition() {
        float x = -10f;
        float y = 0.5f;
        float z = Random.Range(-7f, 7f);
        base.NewPrefab();        
        return new Vector3(x, y, z);
    }

}