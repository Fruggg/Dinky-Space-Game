using UnityEngine;

//Functions to destroy an object after some time
public class DestroysItself : MonoBehaviour
{
    public float timeAlive = 1; 

    void Start()
    {
        //uses invokeRepeating to use the method after a delay; this doesn't repeat, as this object (and script) are both destroyed.
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
