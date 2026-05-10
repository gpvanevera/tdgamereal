using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class testTowerRange : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private List<hitbox> targets;
    [SerializeField] private hitbox currTarget;
    [SerializeField] private int counter;
    private FlamethrowerTest ps;
    public void Init(float setRange)
    {
        range = setRange;
        transform.localScale = new Vector3(range, range, range);
        ps = GetComponentInParent<FlamethrowerTest>();

    }


    // Update is called once per frame
    void Update()
    { 
        while(targets.First() != currTarget)
        {
            currTarget = targets.First();
            ps.changeTarget(currTarget);
            counter++;
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out hitbox enemy))
        {

            
            targets.Add(enemy);



        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out hitbox enemy))
        {
            int findID = enemy.getID();
            targets.RemoveAll(hitbox => hitbox.getID() == findID);
            if (targets.Count <= 0)
            {
                ps.changeTarget(null);
            }

        }


    }


}
