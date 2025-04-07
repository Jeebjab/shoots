using UnityEngine;

public class bullet : MonoBehaviour
{
    public AudioClip damageSoundClip;

    public int dmg;
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            enemy.healthpoints -= dmg;
            //audio
            AudioSource.PlayClipAtPoint(damageSoundClip, transform.position, 1f);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            RocketMove player = collision.GetComponent<RocketMove>();
            player.hp -= dmg;
            Destroy(gameObject);
            
        }
    }
}
