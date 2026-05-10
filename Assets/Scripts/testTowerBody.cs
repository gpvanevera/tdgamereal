using UnityEngine;
using UnityEngine.UIElements;

public class testTowerBody : MonoBehaviour
{
    private int defaultPrice = 200;
    [SerializeField] private int price;
    private float defaultDmg = 1f;
    [SerializeField] private float dmg;
    private float defaultRange = 5f;
    [SerializeField] private float range;
    private float defaultPierce = 10f;
    [SerializeField] private float pierce;
    private float defaultFireRate = 0.5f;
    [SerializeField] private float firerate;
    private Transform target;
    public GameObject rangePrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        price = defaultPrice;
        dmg = defaultDmg;
        range = defaultRange;
        pierce = defaultPierce;
        firerate = defaultFireRate;
        GameObject rangeObj = Instantiate(rangePrefab, transform);
        rangeObj.GetComponent<testTowerRange>().Init(range);
        rangeObj.transform.localPosition = Vector3.zero;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
