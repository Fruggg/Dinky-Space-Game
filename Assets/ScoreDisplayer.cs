using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayer : MonoBehaviour
{
    public TextMeshProUGUI text;
    public PlayerScoreHandler score;
    // Start is called before the first frame update
    void Start()
    {
        text.text = score.score.ToString();
    }
}
