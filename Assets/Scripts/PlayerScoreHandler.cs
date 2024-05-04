using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom Stuff", fileName = "Score SO")]
public class PlayerScoreHandler : ScriptableObject
{
    public int score;
    internal readonly int kScorePerEnemy = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
