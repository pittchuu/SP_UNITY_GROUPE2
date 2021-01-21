using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    private void FixedUpdate()
    {
        if (score == 3)
        {
            Debug.Log("Jeu fini");
            SceneManager.LoadScene("GameOverScene");
        }


    }
    

}
