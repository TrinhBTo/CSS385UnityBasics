using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    bool gameOver = false;
    int count = 0;

    void Update()
    {
        if(gameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (count==2){
            gameOver = true;
        }
        count++;
        
    }

    // Called when restart button is clicked
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Scene1");
    }
}
