using UnityEngine;
using TMPro;

public class PeachInventoryUIScript : MonoBehaviour
{
    private TextMeshProUGUI peachText;

    // Start is called before the first frame update
    void Start()
    {
        peachText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdatePeachText(PlayerInventory playerInventory)
    {
        peachText.text = "Peachs: " + playerInventory.NumberOfPeachsCollected.ToString();
    }
}
