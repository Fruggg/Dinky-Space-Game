using UnityEngine;
using UnityEngine.UI;

public class CooldownScript : MonoBehaviour
{
      public Image cooldown;
    public void SetFill(float input)
    {
        //Sets the fill of the GUI element to indicate how much cooldown is left
        cooldown.fillAmount = (1 - input);
    }

}
