using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour
{
    public float rotationSpeed = 20;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f,rotationSpeed * Time.deltaTime, 0f));
    }
}
