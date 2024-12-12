using UnityEngine;
using TMPro;

public class DoughnutsUIInvetotyText : MonoBehaviour
{
    private TextMeshProUGUI tomatoesText;

    // Start is called before the first frame update
    void Start()
    {
        tomatoesText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDoughnutsText(PlayerInventory playerInventory)
    {
        tomatoesText.text = "Doughnuts: " + playerInventory.NumberOfDoughnutsCollected.ToString();
    }
}
