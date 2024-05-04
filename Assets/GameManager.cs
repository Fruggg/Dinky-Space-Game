using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public PlayerScoreHandler playerScore;
    static readonly int endingScene = 1;
    internal void EndGame()
    {
        playerScore.score += playerScore.kScorePerEnemy * 2;
        SceneManager.LoadScene(endingScene);
    }
}
