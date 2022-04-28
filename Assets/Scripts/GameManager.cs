using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SpawnObjects() {
        Shape s = new Shape();
        // ABSTRACTION
        Vector3 position = s.GeneratePosition();
        Instantiate(prefab, position, Quaternion.identity);
        Color c = new Color();
        prefab.GetComponent<Renderer>().sharedMaterial.color = c.RandomColor;
    }

}