using UnityEngine;

public class TomatoesInventory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory!=null){
            playerInventory.TomatoesCollected();
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
