using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject FiringPoint;
    [SerializeField] private GameObject LaserPrefab;

    [SerializeField ]float speed = 5;
    [SerializeField] float baseShootCoolDown = 2;
    private float shootCD = 0;
    [SerializeField] CooldownScript CD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

     private void InputMethod()
    {

         if( CanShoot() &&  Input.GetKeyUp(KeyCode.Space))
      {
            Shoot();
      }
        //tomove
        Vector2 direction;
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        direction = new Vector2(horizontal, vertical);

        rb.MovePosition(rb.position+ direction*speed);
        
    }

    private bool CanShoot()
    {
        return shootCD <= 0;
    }

    private void Shoot()
    {
        Instantiate(LaserPrefab, FiringPoint.transform);
        shootCD = baseShootCoolDown;
    }
    public void Update()
    {
        InputMethod();
        shootCD -= Time.deltaTime;
        CD.SetFill(shootCD / baseShootCoolDown);
    }
    
}
