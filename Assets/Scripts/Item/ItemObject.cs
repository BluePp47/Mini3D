using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface IInteractable
{
    public string GetInteractPrompt();
    public void OnInteract();
}

public class ItemObject : MonoBehaviour, IInteractable
{
    public Data data;
    public bool use;


    public string GetInteractPrompt()
    {
        string str = $"{data.name}\n{data.description}";
        return str;
    }

    public void OnInteract()
    {
        //Player 스크립트 먼저 수정
        CharacterManager.Instance.Player.itemData = data;
        CharacterManager.Instance.Player.addItem?.Invoke();
        Destroy(gameObject);
        use = true;
    }
}









