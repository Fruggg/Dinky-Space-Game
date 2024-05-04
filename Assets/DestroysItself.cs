using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class DestroysItself : MonoBehaviour
{
    public float timeAlive = 1; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Kaboom), timeAlive, 1);
    }

    private void Kaboom()
    {
        Destroy(gameObject);
    } 
    // Update is called once per frame
    void Update()
    {
        
    }
}
