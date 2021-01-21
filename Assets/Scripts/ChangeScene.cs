using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public string LevelToLoad;
    public Button changeSceneButton;
    public InputField  m_PlayerName;

    void Start()
    {
        changeSceneButton.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
         SceneManager.LoadScene(LevelToLoad);
        if(m_PlayerName.text == "")
        {
            PlayerPrefs.SetString("Name", "Joueur Inconnu car il n'a pas rentré son nom :)");
        } else {
            PlayerPrefs.SetString("Name", m_PlayerName.text);
        }
         
    }

}

