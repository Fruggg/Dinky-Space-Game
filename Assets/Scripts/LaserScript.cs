using System;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] GameObject kaboom;
    [SerializeField] string damagingTag;
    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * Vector3.right * speed * Math.Sign(transform.localScale.x);
    }
    public void OnTriggerEnter2D(UnityEngine.Collider2D col)
    {
        Debug.Log(col.gameObject.name + " debug things");
        //Check if we are in contact with the thing we are supposed to damage
       if (col.gameObject.tag == damagingTag)
       {
        //todo invert this (make objects take damage, instead of damaging objects doing damage)
            col.gameObject.GetComponentInChildren<EntityBase>().TakeDamage();
            Destroy(gameObject);
       }
    }
}
