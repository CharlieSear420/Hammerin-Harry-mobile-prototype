using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BossEnemy : Enemy
{

    public GameObject VictoryScreen;

    
    void Update()
    {
        if (currentHealth <= 0 )
        {
            VictoryScreen.SetActive(true);
        }
    }

    public void LoadGame()
    {
        //Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
        //^^^Slash this out when building^^^
        Debug.Log("Quit");


    }


    
}
