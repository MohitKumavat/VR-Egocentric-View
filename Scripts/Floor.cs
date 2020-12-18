using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Floor : MonoBehaviour
{
    public static int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zenga"))
        {
            count++;
        }
       
        if(count > 9)
        {
            Restart();
        }
    }

    void Restart()
    {
        new WaitForSeconds(1);
        ScoreB.Score = 0;
        count = 0;
        SceneManager.LoadScene(0);
    }

}
