using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Unity.VisualScripting;
public class spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool sendWaveCheck = false;
    [SerializeField] private int waveNum = 1;
    [SerializeField] private int enemyID = 1;
    [SerializeField] private float pathStartDir = 180f;
    [SerializeField] private float waveSpeed = 1.0f;
    [SerializeField] private float attackCountdown = 1.0f;
    [SerializeField] private uiManager ui;
    private Button startWave;
    private List<float> timer;
    private List<float> enemies;
    public GameObject testEnemy;

    void Start()
    {

        timer = new List<float>(); enemies = new List<float>();
        enemies.Add(1);
        enemies.Add(1);
        enemies.Add(1);
        enemies.Add(1);
        enemies.Add(1);
        timer.Add(1);
        timer.Add(1);
        timer.Add(1);
        timer.Add(1);
        timer.Add(1);
        startWave = ui.getButton();
        startWave.onClick.AddListener(OnButtonClick);
        transform.rotation =  Quaternion.Euler(0, 0, pathStartDir);
        //Debug.Log("Born");
    }

    // Update is called once per frame
    private void OnButtonClick()
    {
        if (sendWaveCheck == false)
        {
            sendWaveCheck = true;
            StartCoroutine(sendWave());


        }
    }
    private void Update()
    {

    }


    private  IEnumerator sendWave()
    {
        int itr = enemies.Count;
        for (int i = 0; i < itr; i++)
        {
            SpawnObject();
            yield return new WaitForSeconds(timer[i]);

        }
        yield return new WaitUntil(() => transform.childCount == 2);

        sendWaveCheck = false;
        waveNum++;

    }
    void SpawnObject()
    {
        // Spawns the prefab at the current script's position and rotation
        GameObject newEnemy = Instantiate(testEnemy, transform);
        newEnemy.GetComponent<EnemyMovement>().Init(enemyID);
        newEnemy.transform.localPosition = Vector3.zero;
        enemyID++;
    }

}
