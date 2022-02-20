using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    public Text gameOver;
    public Button restart;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        gameOver.gameObject.SetActive(true);
        Time.timeScale = 0;
        restart.gameObject.SetActive(true);


    }
}
