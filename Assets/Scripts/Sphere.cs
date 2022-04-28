using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(2f, 0f, 0f);
        transform.Translate(movement * 1.5f * Time.deltaTime);
        if(transform.position.x > 6f) {
            Destroy(transform.gameObject);
        }
    }

}