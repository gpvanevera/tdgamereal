using TMPro;
using UnityEngine;

public class livesText : MonoBehaviour
{
    [SerializeField] private TextMeshPro lives;
    private int liveNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Init(int setLives)
    {
        liveNum = setLives;
        lives.text = "Lives: " + liveNum; 
    }
    public void updateLives(int hp)
    {
        lives.text = "Lives: " + liveNum;
    }
    // Update is called once per frame
    
}
