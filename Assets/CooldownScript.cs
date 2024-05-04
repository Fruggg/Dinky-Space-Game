using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownScript : MonoBehaviour
{
      public Image cooldown;
    public void SetFill(float input)
    {
        cooldown.fillAmount = (1 - input);
    }

}
