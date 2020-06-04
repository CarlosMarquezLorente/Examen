using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Chronometer : MonoBehaviour
{
    public Text time;
    public float totalTime;
    public string restart;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        time.text = "Time: " + Mathf.Floor(totalTime);
        if (totalTime <= 0)
        {
            SceneManager.LoadScene(restart);
        }
    }
}
