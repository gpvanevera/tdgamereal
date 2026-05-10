using UnityEngine;

public class DirectionPointScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private EnemyMovement ps;
    
    void Start()
    {
        ps = GetComponentInParent<EnemyMovement>();
        if (ps == null) Debug.LogError("EnemyMovement script not found on parent!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.TryGetComponent(out ChangePath changepath))
        {
            ps.changeRotation(changepath.transform.eulerAngles.z);

            Debug.Log("turning");

        }





    }
}
