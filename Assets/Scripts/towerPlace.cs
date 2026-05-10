using UnityEngine;
using UnityEngine.EventSystems;
public class towerPlace : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject towerToSpawn;
    private bool hasTower;
    GameObject newTower = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hasTower = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnPointerClick(PointerEventData eventData)
    {

        if (!hasTower)
        {
            newTower = Instantiate(towerToSpawn, transform);
            newTower.transform.localPosition = Vector3.zero;
            newTower.GetComponent<SpriteRenderer>().sortingOrder = 1;
            hasTower = true;

        }
        else
        {
            Destroy(newTower);
            hasTower = false;
        }
    }


    
}
