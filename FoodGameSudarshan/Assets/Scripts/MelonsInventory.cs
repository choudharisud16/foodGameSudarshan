using UnityEngine;

public class MelonsInventory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory!=null){
            playerInventory.MellonsCollected();
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
