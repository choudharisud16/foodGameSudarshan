using UnityEngine;
using TMPro;

public class TomatoesUIINvetotyText : MonoBehaviour
{
   private TextMeshProUGUI tomatoesText;

    // Start is called before the first frame update
    void Start()
    {
        tomatoesText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTomatoesText(PlayerInventory playerInventory)
    {
        tomatoesText.text = "Tomatoes: " + playerInventory.NumberOfTomatoesCollected.ToString();
    }
}
