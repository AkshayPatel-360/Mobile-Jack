using UnityEngine ;
using EasyJoystick ;

public class Player : MonoBehaviour {

    [SerializeField] private float speed;
    [SerializeField] private float ShootSpeed;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Joystick moveJoystick;
    [SerializeField] private Joystick fireJoystick;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePos;

    private Rigidbody2D rb;
    private Rigidbody2D bulletRB;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();


        bullet = Resources.Load<GameObject>("Prefabs / bullet");

        bulletRB = Resources.Load<Rigidbody2D>("Prefabs / bullet");


    }

    private void Update()
    {
        float x1 = moveJoystick.Horizontal();
        float y1 = moveJoystick.Vertical();
        rb.velocity = new Vector2(x1, y1) * speed;

        if (fireJoystick.Horizontal() != 0 || fireJoystick.Vertical()!= 0)
        {
            //Debug.Log("hiiiiiiii");
            Shoot();
        }
    }

    public void Shoot()
    {
        float x = fireJoystick.Horizontal();
        float y = fireJoystick.Vertical();

        GameObject newBullet = Instantiate(bullet, firePos.position,Quaternion.identity);

        //bulletRB.velocity = new Vector2(x, y) * bulletSpeed;

    }



}
