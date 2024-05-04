using TMPro;
using UnityEngine;

//Sloppy utility to see how many enemies there are; if I have infinite time, this would be much nicer, more complicated, scalable, and like 5 times the size

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
