using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TextMeshProUGUI lives;
    [SerializeField] private Button startWave;
    private float liveNum;
    private float defaultLives = 100f;
    void Start()
    {
        liveNum = defaultLives;
        lives.text = "Lives: " + liveNum;
    }
    public void updateLives(float hp)
    {
        liveNum = hp + liveNum;
        lives.text = "Lives: " + liveNum;
    }
    public Button getButton()
    {
        return startWave;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
