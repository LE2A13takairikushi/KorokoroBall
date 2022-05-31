using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
        timer.count = 0;
        timer.Second = 5;
        timer.countStopF = false;

    }
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
        timer.count = 0;
        timer.Second = 5;
        timer.countStopF = false;

    }

    private int coinCount;
    public Text textComponent;

    private void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }

    public void AddcoinCount()
    {
        coinCount = coinCount + 1;
        timer.Second += 1;
        Debug.Log("Coincount" + coinCount);
        textComponent.text = "ÉRÉCÉìÇÃéÊìæêî : " + coinCount;
    }
}
