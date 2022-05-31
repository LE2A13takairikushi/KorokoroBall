using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static int count = 0;
    public static int Second = 5;
    public static bool countStopF = false;

    public Text textComponent;
    // Update is called once per frame
    void Start()
    {
        textComponent = GetComponent<Text>();
    }

    public void CountUp()
    {
        count++;
    }
    public void CountStop()
    {
        countStopF = true;
    }

    void Update()
    {
        if(countStopF == false) CountUp();

        if (count >= 120)
        {
            Second--;
            count = 0;
        }

        if(Second <= 0)
        {
            GameManager.SceneReset();
        }

        textComponent.text = "Žc‚èŽžŠÔ : " + Second;
    }
}
