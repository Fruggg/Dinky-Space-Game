using UnityEngine;
using UnityEngine.UI;

public class ProgressScript : MonoBehaviour
{
    public Image cooldown;
    
    public GameObject player;
    public int playerEndpoint = 200;
   
   public void Start()
   {
        cooldown.fillMethod = Image.FillMethod.Horizontal;
   }
    void Update()
    {
        cooldown.fillAmount = player.transform.position.x / playerEndpoint; 
        
        if (player.transform.position.x / playerEndpoint >= 1)
            {
            FindAnyObjectByType<GameManager>().EndGame();
            }
    }
    
}