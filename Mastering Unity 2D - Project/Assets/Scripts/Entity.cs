using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : ScriptableObject {
	public string entityName;
	public int age;
	string faction;
	public string occupation;
	public int level = 1;
	public int health = 2;
	public int strength = 1;
	public int magic = 0;
	public int defense = 0;
	public int speed = 1;
	public int damage = 1;
	public int armor = 0;
	public int noOfAttacks = 1;
	public string weapon;
	public Vector2 position;

	public void TakeDamage (int amount) {
		health = health - Mathf.Clamp ((amount - armor), 0, int.MaxValue);
	} 

	public void Attack (Entity entity){
		entity.TakeDamage (strength);
	}
}