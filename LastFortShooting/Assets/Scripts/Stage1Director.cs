using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1Director : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Stage2");
        }*/

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
