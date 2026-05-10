using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int id = -1;
    private float defaultSpeed = 0.05f;
    private float defaultHP = 100f;
    [SerializeField] private float currentHP;
    [SerializeField] private float currentSpeed;
    [SerializeField] private float currentRotation;
    private float defaultRotation = 180f;
    public GameObject hitboxPrefab;
    public GameObject hpPrefab;


    public void Init(int setID)
    {
        currentHP = defaultHP;
        currentSpeed = defaultSpeed;
        currentRotation = defaultRotation;
        transform.Rotate(0, 0, currentRotation);
        GameObject hitboxObject = Instantiate(hitboxPrefab, transform);
        hitboxObject.GetComponent<hitbox>().Init(1);
        hitboxObject.transform.localPosition = Vector3.zero;
        GameObject hpObject = Instantiate(hpPrefab, transform);
        hpObject.transform.localPosition = new Vector3(0, -0.5f, 0);
        id = setID;
    }

    // Fixedupdate is called once per cycle
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, currentRotation);
        transform.position += transform.rotation * new Vector3(0, defaultSpeed, 0);
        if(currentHP <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    public void takedmg(float dmg)
    {
        currentHP += -1 * dmg;
    }
    public void changeRotation(float rotation)
    {
        currentRotation = rotation;
    }
    public float getHP()
    {
        return currentHP;
    }
    public void killCommand()
    {
        Destroy(gameObject);
    }
}
