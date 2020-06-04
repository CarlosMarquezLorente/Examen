using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public int fuerzaDisparo = 50;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.green, 5f);

            RaycastHit hit;
            bool hacolisionado = Physics.Raycast(ray, out hit);

            if (hacolisionado)
            {
                Debug.Log(hit.collider.gameObject.name);
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(fuerzaDisparo * transform., ForceMode.Impulse);
            }
        }
    }
}
