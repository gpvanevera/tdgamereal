using UnityEngine;

public class damageSource : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float dmg = 1f;
    [SerializeField] private float pierce = 1f;
    [SerializeField] private float hp = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if(hp <= 0 || pierce <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out hitbox enemy))
        {
            //Debug.Log("Test");
            enemy.takeDamage(dmg);
            pierce += -1;
        }


    }
}
