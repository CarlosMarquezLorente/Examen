using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Disparo : MonoBehaviour
{
    public int fuerzaDisparo = 50;

    public int scorePonits;
    public Text scoreText;
    public int score;

    public string sceneGo;


    private void Start()
    {
        score = 0;
    }

    void Update()
    {
         if(score >= 7)
        {
            SceneManager.LoadScene(sceneGo);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 750, Color.green, 5f);

            RaycastHit hit;
            bool hacolisionado = Physics.Raycast(ray, out hit);

            if (hacolisionado)
            {
                Debug.Log(hit.collider.gameObject.name);
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(fuerzaDisparo * transform.forward, ForceMode.Impulse);
                if (hit.collider.gameObject.GetComponent<Rigidbody>().CompareTag("PickUp"))
                {
                    if (score <= 7)
                    {
                        hit.collider.gameObject.SetActive(false);
                        score++;
                        scoreText.text = "Puntuación: " + score + "/7";
                        
                    }
                   
                }
                
            }

        }
    }

    
}
