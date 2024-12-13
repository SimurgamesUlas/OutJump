using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject levelUpdatPanel;
    [SerializeField] private UnityEngine.UI.Image[] stars;
    public bool isStart;
    public bool isDead;
    public int StarCount;
    private int CurrentLevelİndex;
    void Start()
    {
       isStart = false;
       isDead = false;
       CurrentLevelİndex = SceneManager.GetActiveScene().buildIndex; 
    }

    
    void Update()
    {
        for(int i = 0; i < StarCount; i++){
            stars[i].enabled = true;
        }
    }
    public void LevelUpdatPanel(){
        levelUpdatPanel.SetActive(true);
    }
    public void LevelUpdate(){
        SceneManager.LoadScene(CurrentLevelİndex+1);
    }
    public void GameOver(){
        SceneManager.LoadScene(CurrentLevelİndex);
    }
}
