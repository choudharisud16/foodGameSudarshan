using UnityEngine;
using TMPro;

public class WinOrLose : MonoBehaviour
{
    private TextMeshProUGUI winOrLoseText;
    private int healthyFood = 0;
    private int junkFood = 0;

    public PlayerInventory playerInventory;

    // Start is called before the first frame update
    void Start()
    {
        winOrLoseText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateGameOverText()
    {
        healthyFood = playerInventory.NumberOfMelonsCollected + playerInventory.NumberOfPeachsCollected + playerInventory.NumberOfTomatoesCollected;
        junkFood = playerInventory.NumberOfCandiesCollected + playerInventory.NumberOfDoughnutsCollected + playerInventory.NumberOfSodasCollected;
        if(healthyFood >= junkFood){
            winOrLoseText.text = "You Win!";
            winOrLoseText.color = Color.green;
        }else{
            winOrLoseText.text = "You Lose!";
            winOrLoseText.color = Color.red;
        }
    }
}
