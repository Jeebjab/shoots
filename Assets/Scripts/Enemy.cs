using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public int healthpoints;
    public GameObject Bulletprefab;
    public Transform bulletSpawnHere;
    public float bulletspeed;
    public float minShootInterval = 1f;
    public float maxShootInterval = 3f;

    void Start()
    {
        StartCoroutine(ShootAtRandomIntervals());
    }

    void Update()
    {
        if (healthpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator ShootAtRandomIntervals()
    {
        while (true)
        {
            float waitTime = Random.Range(minShootInterval, maxShootInterval);
            yield return new WaitForSeconds(waitTime);

            GameObject bullet = Instantiate(Bulletprefab, bulletSpawnHere.position, bulletSpawnHere.rotation);

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.linearVelocity = Vector2.down * bulletspeed; // Downward for enemy shots

            Destroy(bullet, 5f); // Bullet disappears after 5 seconds
        }
    }
}
