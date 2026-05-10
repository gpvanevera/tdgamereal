using UnityEngine;

public class flamethrowerHurtbox : MonoBehaviour
{


    [SerializeField] private float dmg;
    [SerializeField] private float size;
    [SerializeField] private float pierce;
    [SerializeField] private float lifespan;
    [SerializeField] private float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Init(float setDmg, float setSize, float setPierce, float setLifespan, float setSpeed)
    {
        dmg=setDmg; size=setSize; pierce=setPierce; lifespan=setLifespan; speed=setSpeed;
        transform.localScale = new Vector3(size, size, size);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lifespan -= Time.deltaTime;
        if (lifespan <= 0 || pierce <= 0)
        {
            Destroy(gameObject);
        }
        transform.position += transform.rotation * new Vector3(0, speed, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out hitbox enemy))
        {
            //Debug.Log("Hit!");
            enemy.takeDamage(dmg);
            pierce += -1f;
        }
        //

    }
}
