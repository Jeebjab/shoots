using UnityEngine;

public class RocketMove : MonoBehaviour
{
    public float MoveSpeed;
    public GameObject Bulletprefab;
    public Transform bulletSpawnHere;
    public float bulletspeed;
    public float hp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hp = 20;
    }

    // Update is called once per frame
    void Update()
    {

        /*if ( hp <= 0)
        {
            code for game over
        }*/

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            {
               GameObject bullet = Instantiate(Bulletprefab, bulletSpawnHere.position, bulletSpawnHere.rotation);

                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.linearVelocity = Vector2.up * bulletspeed;

                Destroy(bullet, 3f);
            }
        }
    }
}


// other code for movement 
// float horizontalinput = Input.GetAxisRaw("Horizontal");
// float verticalinput = input.getaxisraw("vertical");
// put in update
// private rigidbody2d rb;
// in void start
// rb = getcomponent<rigidbody2d>();
