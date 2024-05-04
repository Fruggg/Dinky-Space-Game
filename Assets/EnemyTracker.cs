using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTracker : MonoBehaviour
{
    public TextMeshProUGUI text;
    [SerializeField] private int enemiesAlive;
    [SerializeField] public int EnemiesAlive
    {
        get { return enemiesAlive; }
        set { SetText(value); }
    }

    private void SetText(int value)
    {
        enemiesAlive = value; 
        text.text = value.ToString();
    }
}
