using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCandiesCollected {get; private set;}
    public int NumberOfDoughnutsCollected {get; private set;}
    public int NumberOfSodasCollected {get; private set;}
    public int NumberOfTomatoesCollected {get; private set;}
    public int NumberOfMelonsCollected {get; private set;}
    public int NumberOfPeachsCollected {get; private set;}

    public UnityEvent<PlayerInventory> OnCandyCollected;
    public UnityEvent<PlayerInventory> OnDoughnutCollected;
    public UnityEvent<PlayerInventory> OnSodaCollected;
    public UnityEvent<PlayerInventory> OnTomatoCollected;
    public UnityEvent<PlayerInventory> OnMelonCollected;
    public UnityEvent<PlayerInventory> OnPeachCollected;
    public UnityEvent<PlayerInventory> OnGameOver;

    public void CandiesCollected(){
        NumberOfCandiesCollected++;
        OnCandyCollected.Invoke(this);
    }

    public void DoughnutsCollected(){
        NumberOfDoughnutsCollected++;
        OnDoughnutCollected.Invoke(this);
    }

    public void SodasCollected(){
        NumberOfSodasCollected++;
        OnSodaCollected.Invoke(this);
    }

    public void TomatoesCollected(){
        NumberOfTomatoesCollected++;
        OnTomatoCollected.Invoke(this);
    }

    public void MellonsCollected(){
        NumberOfMelonsCollected++;
        OnMelonCollected.Invoke(this);
    }

    public void PeachsCollected(){
        NumberOfPeachsCollected++;
        OnPeachCollected.Invoke(this);
    }

    public void GameOver(){
        Debug.Log("here");
        OnGameOver.Invoke(this);
    }
}
