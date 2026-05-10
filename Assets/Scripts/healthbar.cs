using UnityEngine;

public class healthbar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float currhealth;
    [SerializeField] private float maxhealth;
    [SerializeField] private float percSize;
    private EnemyMovement ps;
    private Vector3 origScale;


    void Start()
    {
        ps = GetComponentInParent<EnemyMovement>();
        maxhealth = ps.getHP();
        currhealth = ps.getHP();
        origScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

            currhealth = ps.getHP();
            percSize = currhealth / maxhealth;

        
        Debug.Log(percSize);
        Vector3 currentScale = origScale;
        currentScale.x = origScale.x * percSize;
        transform.localScale = currentScale;

    }
}
