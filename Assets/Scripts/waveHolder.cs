using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class waveHolder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private List<List<float>> waves;
    void Start()
    {

        
        //waves are declared as enemyTypeID, cooldown, enemyTypeID, cooldown etc
        waves = new List<List<float>>();
        //wave1
        waves.Add(new List<float> { 1, 0.5f, 1, 0.5f });
        waves.Add(new List<float> { 1, 0.5f, 1, 0.5f, 1, 0.5f });
        waves.Add(new List<float> { 1, 0.5f, 1, 0.5f, 1, 0.5f, 1, 0.5f});
        waves.Add(new List<float> { 1, 0.5f, 1, 0.5f, 1, 0.5f, 1, 0.5f, 1, 0.5f});
        waves.Add(new List<float> { 1, 0.5f, 1, 0.5f, 1, 0.5f, 1, 0.5f, 1, 0.5f, 1, 0.5f});
        //wave2
        //Declaring waves

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<float> sendWave(int waveID)
    {
        return waves.ElementAt(waveID);
    }
}
