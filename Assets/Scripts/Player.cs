using UnityEngine ;
using EasyJoystick ;

public class Player : MonoBehaviour {

    [SerializeField] private float speed;
    [SerializeField] private Joystick joystick;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = joystick.Horizontal();
        float y = joystick.Vertical();

       // transform.position += new Vector3(x,0, y) * speed * Time.deltaTime;
        rb.velocity = new Vector2(x, y) * speed;


    }



}
