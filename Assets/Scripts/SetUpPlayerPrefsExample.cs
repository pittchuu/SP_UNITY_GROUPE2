using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetUpPlayerPrefsExample : MonoBehaviour
{
    string m_PlayerName;

    void Start()
    {
        m_PlayerName = "";
    }

    void Update()
    {
        //Give the PlayerPrefs some values to send over to the next Scene
        PlayerPrefs.SetString("Name", m_PlayerName);
    }

    void OnGUI()
    {
        //Create a Text Field where the user inputs their name
        m_PlayerName = GUI.TextField(new Rect(400, 500, 200, 50), m_PlayerName, 50);

    }
}