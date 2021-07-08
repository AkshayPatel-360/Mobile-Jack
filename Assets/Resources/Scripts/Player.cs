using UnityEngine ;
using EasyJoystick ;

public class Player : MonoBehaviour {

    [SerializeField] private float speed;
    private float ShootTime;
    [SerializeField] private float fireRate;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Joystick moveJoystick;
    [SerializeField] private Joystick fireJoystick;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePos;
    [SerializeField] private Rigidbody2D bulletRB;

    private Rigidbody2D rb;

    
    private void Start()
    {
        TimeManager.Instance.Initialize();
        rb = GetComponent<Rigidbody2D>();
        ShootTime = 0f;

    }

    private void Update()
    {
        animator.SetFloat("Y",moveJoystick.Vertical());
        animator.SetFloat("X", moveJoystick.Horizontal());

        TimeManager.Instance.Refresh();
        float x1 = moveJoystick.Horizontal();
        float y1 = moveJoystick.Vertical();
        rb.velocity = new Vector2(x1, y1) * speed;

        if ((fireJoystick.Horizontal() != 0 || fireJoystick.Vertical() != 0)&& Time.time > ShootTime )
        {
            ShootTime = Time.time + fireRate;
            TimeManager.Instance.AddDelegate(() => Shoot(), 0, 1); 
        }
       
    }

    public void Shoot()
    {
            float x = fireJoystick.Horizontal();
            float y = fireJoystick.Vertical();

        GameObject newBullet = ObjectPuller.currentObjectPuller.DepullObject();
        newBullet.transform.position = firePos.position;
        
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(x, y).normalized * bulletSpeed;

    }
}
