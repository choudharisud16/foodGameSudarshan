using UnityEngine;

public class PeachesInventory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory!=null){
            playerInventory.PeachsCollected();
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
