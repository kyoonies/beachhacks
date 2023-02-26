using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 10;
    public HealthBar health;

    void Start()
    {
        Hitpoints = MaxHitpoints;
        health.SetHealth(Hitpoints, MaxHitpoints);
    }

    public void TakeHit(float damage){
        Hitpoints -= damage;
        health.SetHealth(Hitpoints, MaxHitpoints);

        if (Hitpoints <= 0){
            Destroy(gameObject);
        }
    }
}
