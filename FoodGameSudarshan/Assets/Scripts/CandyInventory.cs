using UnityEngine;

public class CandyInventory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory!=null){
            playerInventory.CandiesCollected();
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
