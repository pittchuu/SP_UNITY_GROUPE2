using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftScript : MonoBehaviour
{
    public int totalCount;
    public Text TimeLeft;
    public string LevelToLoad;
    void Start()
    {
        StartCoroutine(Pause());
    }
    IEnumerator Pause ()
    {
        while (totalCount > 0)
        {
            yield return new WaitForSeconds(1);
            totalCount--;
            TimeLeft.text = "Temps restant : " + totalCount;
        }
        SceneManager.LoadScene(LevelToLoad);
    }



}
