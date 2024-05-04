using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlacerScript : MonoBehaviour
{
    [SerializeField] Vector2 lowerBoundPosition;
    [SerializeField] Vector2 upperBoundPosition;
    // Start is called before the first frame update
   public void Awake()
   {
        gameObject.transform.position = gameObject.transform.position + Vector3.up * UnityEngine.Random.Range(lowerBoundPosition.x, upperBoundPosition.x);
        gameObject.transform.position = gameObject.transform.position + Vector3.up * UnityEngine.Random.Range(lowerBoundPosition.y, upperBoundPosition.y);
   }
}
