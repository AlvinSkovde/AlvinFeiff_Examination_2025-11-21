using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void updateLives(int lives)
    {
        text.text = "Lives: " + lives;
    }
}
