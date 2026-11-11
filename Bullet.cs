using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage;

    private void OnCollisionEnter(Collision HitObject)
    {
        if (HitObject.gameObject.CompareTag("Target"))
        {
            print("hit" + HitObject.gameObject.name + "!");

            Destroy(gameObject);
        }
        if (HitObject.gameObject.CompareTag("Wall"))
        {
            print("hit a wall");
            Destroy(gameObject);
        }
        if (HitObject.gameObject.CompareTag("Enemy"))
        {
            HitObject.gameObject.GetComponent<Enemy>().TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
    }
}