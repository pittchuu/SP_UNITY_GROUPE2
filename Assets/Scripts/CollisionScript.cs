using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    private AudioSource _audioSource;
    private AudioClip _audioClip;
    public Text Count;
    public bool isDestroyed;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    //OnTriggerEnter est appelé quand le Collider other entre dans le déclencher
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player" && !isDestroyed)
        {
            GameObject.Find("FPSPlayer").GetComponent<ScoreScript>().score++;
            _audioSource.Play();
            Destroy(gameObject,1f);
            isDestroyed = true;
            Count.text = GameObject.Find("FPSPlayer").GetComponent<ScoreScript>().score + "/3";


        }
    }
    private void OnTriggerExit(Collider other)
    {
        isDestroyed = false;
    }
}
