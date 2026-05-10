using UnityEngine;

public class hitbox : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private EnemyMovement ps;
    [SerializeField] private int id;
    public void Init(int newID)
    {
        id = newID;
        ps = GetComponentInParent<EnemyMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takeDamage(float dmg)
    {
        ps.takedmg(dmg);
    }
    public void leakParent()
    {
        ps.killCommand();
    }
    public float getHP()
    {
        return ps.getHP();
    }
    public int getID()
    {
        return ps.id;
    }
}
