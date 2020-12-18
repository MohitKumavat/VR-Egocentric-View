using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator trans;
 
    // Update is called once per frame
    void Update()
    {
       //if (OVRInput.GetDown(OVRInput.Button.Two))
        if(ScoreB.Score == 10)
        {
            ScoreB.Score++;
            Floor.count = 0;
            StartCoroutine(LoadLevel(1));
        }   
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        trans.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelIndex);
    }
}
