using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int points = 1;

    public Vector3 rotation;

    void Update()
    {
        Vector3 rotation = new Vector3(90, 90, 90) * Time.deltaTime;
        transform.Rotate(rotation);
    }
}
