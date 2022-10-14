using UnityEngine;
using TMPro;

public class Script_Score : MonoBehaviour
{
    public TextMeshProUGUI self;
    public Player player;

    private void Start()
    {
        self.text = "Score: 0";
    }
    // Update is called once per frame
    void Update()
    {
        int score = player.getScore();
        self.text = "Score: " + score;
    }
}