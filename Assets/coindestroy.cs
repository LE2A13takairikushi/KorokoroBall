using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coindestroy : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.AddcoinCount();
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        GameObject managerObject = GameObject.Find("GameManager");
        gameManager = managerObject.GetComponent<GameManager>();
    }
}
