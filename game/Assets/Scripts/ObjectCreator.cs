using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour {

    public GameObject wallPrefab;
	/* is de multiplier van de verte dat je spawnt f achter de waarde want het is een float een int daar integen hoeft dat niet maar heeft ook een vaste waarde dus niet ahcter de komma een float wel.*/
	public float spawnDistance = 3f;

	void Update() 
	{
		/* als Inpoet spaties balk is en ingedrukt */
		if (Input.GetKeyDown("f")) 
		{
			/*scope hier in gebeurd alles als je space drukt dus als space waar is*/
			SpawnDeMuur();
		}
	}

	/* de functie heet spawn de muur dat boeit niet dit kan ook keesMetzeDikkelulheten*/
    public void SpawnDeMuur()
    {

		/* wallPrefab is de prefab die we bovenin gezet hebben nou eigenlijk niet gezet we zetten ofterwijl slepen het object/prefab in de inspecotr erin */
		/* Instantiate is gelijk aan spawnen van een object. nu spawnen we de wallPrefab dus de muur en je moet zetten waar die komt en de rotatie daarvan we pakken nu de rotatei van jezelf*/
		GameObject go = (GameObject)Instantiate(wallPrefab, this.transform.position + this.transform.forward * spawnDistance, this.transform.rotation);
		/* zet een naam van je wallPrefab die nu gevuld is in de variable go */
		go.name = "DikkeEzelMuurVanEnnioG";
    }
}
