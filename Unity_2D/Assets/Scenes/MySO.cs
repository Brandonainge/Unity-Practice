using UnityEngine;

[CreateAssetMenu]

public class MySO : ScriptableObject
{
  public new string name;
  public string description;

  public Sprite design;

  public int manaCost;
  public int power;
  public int stamina;

}
