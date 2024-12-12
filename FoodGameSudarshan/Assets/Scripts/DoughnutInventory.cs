using UnityEngine;

public class DoughNutInventory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory!=null){
            playerInventory.DoughnutsCollected();
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
