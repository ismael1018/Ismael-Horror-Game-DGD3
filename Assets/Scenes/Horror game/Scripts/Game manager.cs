using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    public int kills;
    public TextMeshProUGUI killText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        killText.text = "Kills: 0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnemyKilled()
    {
        kills++;
        killText.text = "kills: " + kills;
    }
}