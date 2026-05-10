using UnityEngine;
using UnityEngine.Lumin;

public class exit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float dmgTaken = 0;
    [SerializeField] private uiManager ui;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out hitbox enemy))
        {
            //Debug.Log("Test4444");
            ui.updateLives(enemy.getHP() * -1);
            enemy.leakParent();

        }


    }
}
