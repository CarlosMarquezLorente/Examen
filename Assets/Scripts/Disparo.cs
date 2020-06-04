using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparo : MonoBehaviour
{
    public int fuerzaDisparo = 50;

    public int scorePonits;
    public Text scoreText;
    int score;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 5000, Color.green, 5f);

            RaycastHit hit;
            bool hacolisionado = Physics.Raycast(ray, out hit);

            if (hacolisionado)
            {
                Debug.Log(hit.collider.gameObject.name);
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(fuerzaDisparo * transform.forward, ForceMode.Impulse);
                if (hit.collider.gameObject.GetComponent<Rigidbody>().CompareTag("PickUp"))
                {
                    hit.collider.gameObject.gameObject.SetActive(false);
                }
            }
        }
    }
}
