using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource audioSource;
    public timer timer;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("?S?[??!");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        audioSource.Play();
        timer.countStopF = true;
    }
}
