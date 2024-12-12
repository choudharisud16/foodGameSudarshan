using UnityEngine;
using TMPro;

public class MellonsUIInvetotyText : MonoBehaviour
{
    private TextMeshProUGUI mellonsText;

    // Start is called before the first frame update
    void Start()
    {
        mellonsText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateMellonsText(PlayerInventory playerInventory)
    {
        mellonsText.text = "Melons: " + playerInventory.NumberOfMelonsCollected.ToString();
    }
}
