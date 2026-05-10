using UnityEngine;

public class FlamethrowerTest : MonoBehaviour
{
    [SerializeField] private float dmg;
    [SerializeField] private float lifespan;
    [SerializeField] private float pierce;
    [SerializeField] private float speed;
    [SerializeField] private float size;
    [SerializeField] private float range;
    [SerializeField] private float attackInterval;
    [SerializeField] private float attackCountdown;
    [SerializeField] private hitbox target;
    public GameObject flamePrefab;
    public GameObject rangePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {//
        dmg = 15f;
        lifespan = 3f;
        pierce = 1f;
        speed = 0.7f;
        size = 0.3f;
        range = 10f;
        attackInterval = 3f;
        GameObject rangeObj = Instantiate(rangePrefab, transform);
        rangeObj.GetComponent<testTowerRange>().Init(range);
        rangeObj.transform.localPosition = Vector3.zero;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Debug.Log("turning");
        if(target != null)
        {
            RotateToFace(target.transform.position);

        }
        if (attackCountdown <= 0f && target != null)
        {
            Shoot();
            attackCountdown = 1f / attackInterval;
        }
        attackCountdown -= Time.deltaTime;
    }
    private void Shoot()
    {
   
        Vector3 spawnhere = transform.position;
        Quaternion facehere = transform.rotation;
        GameObject rangeObj = Instantiate(flamePrefab, spawnhere, facehere);
        rangeObj.GetComponent<flamethrowerHurtbox>().Init(dmg, size, pierce, lifespan, speed);
    }
    public void changeTarget(hitbox newTargetPos)
    {
        target = newTargetPos;
    }
    void RotateToFace(Vector3 targetPosition)
    {
        Vector3 direction = (targetPosition - transform.position).normalized;
        transform.up = direction;
    }
    public void destroyTower()
    {
        Destroy(gameObject);
    }
}