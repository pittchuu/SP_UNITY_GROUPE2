using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetUserNameScript : MonoBehaviour
{
    string m_PlayerName, test;
    public Text UserName;
    void Start()
    {
        //Fetch the PlayerPref settings
        //m_PlayerName = PlayerPrefs.GetString("Name", "No Name");
        UserName.text = "Nom : " + PlayerPrefs.GetString("Name", "No Name");
        //Debug.Log(UserName.text);
    }

    void SetText()
    {
        //Fetch name (string) from the PlayerPrefs (set these Playerprefs in another script). If no string exists, the default is "No Name"
       // m_PlayerName = PlayerPrefs.GetString("Name", "No Name");
    }

    void OnGUI()
    {
        //Fetch the PlayerPrefs settings and output them to the screen using Labels
       // GUI.Label(new Rect(50, 50, 500, 30), "Nom : " + m_PlayerName);
        //UserName.text = "Nom : " + m_PlayerName;
    }
    

}
