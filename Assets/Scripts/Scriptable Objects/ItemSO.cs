using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/ItemSO")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public Sprite itemSprite;
    public string itemDescription; // Adicione outras propriedades conforme necessário
}
