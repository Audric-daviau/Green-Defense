using UnityEngine;
using TMPro;

public class Script_Affichage_Score : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI self;

    // Update is called once per frame
    void Update()
    {
        int score = player.getScore();
        self.text = (score <= 1) ? "Pollueur converti: " + score : "Pollueurs convertis: " + score;
    }
}
