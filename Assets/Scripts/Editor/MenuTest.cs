using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR 
using UnityEditor;
#endif

public class MenuTest : MonoBehaviour
{
	// Add a menu item to create custom GameObjects.
	// Priority 1 ensures it is grouped with the other menu items of the same kind
	// and propagated to the hierarchy dropdown and hierarch context menus.
	[MenuItem("GameObject/MG Objects/MG Character", false, 10)]
	static void CreateMGCharacter(MenuCommand menuCommand)
	{
		GameObject go = Instantiate (Resources.Load ("Prefab/Citizens/C-F-Default")) as GameObject;

		// Ensure it gets reparented if this was a context click (otherwise does nothing)
		GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
		// Register the creation in the undo system
		Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
		Selection.activeObject = go;
	}

	// Add a menu item to create custom GameObjects.
	// Priority 1 ensures it is grouped with the other menu items of the same kind
	// and propagated to the hierarchy dropdown and hierarch context menus.
	[MenuItem("GameObject/MG Objects/MG Merchant", false, 10)]
	static void CreateMGMerchant(MenuCommand menuCommand)
	{
		GameObject go = Instantiate (Resources.Load ("Prefab/Citizens/C-F-Default")) as GameObject;

		// Ensure it gets reparented if this was a context click (otherwise does nothing)
		GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
		// Register the creation in the undo system
		Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
		Selection.activeObject = go;
	}

}