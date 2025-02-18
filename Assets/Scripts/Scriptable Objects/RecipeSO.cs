using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Crafting/Recipe")]
public class RecipeSO : ScriptableObject
{
    public string recipeName;
    public string recipe;
}