using UnityEngine;
using TMPro;

public class CandyCanesUIInvetotyText : MonoBehaviour
{
    private TextMeshProUGUI candyCanesText;

    // Start is called before the first frame update
    void Start()
    {
        candyCanesText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCandyCanesText(PlayerInventory playerInventory)
    {
        candyCanesText.text = "CandyCanes: " + playerInventory.NumberOfCandiesCollected.ToString();
    }
}
