using UnityEngine;
using TMPro;

public class SodaCansUIInvetotyText : MonoBehaviour
{
    private TextMeshProUGUI sodaCansText;

    // Start is called before the first frame update
    void Start()
    {
        sodaCansText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateSodaCansText(PlayerInventory playerInventory)
    {
        sodaCansText.text = "SodaCans: " + playerInventory.NumberOfSodasCollected.ToString();
    }
}
