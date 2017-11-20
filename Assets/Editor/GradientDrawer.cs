using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomPropertyDrawer (typeof (CustomGradient))]
public class GradientDrawer : PropertyDrawer {
	// public override float GetPropertyHeight (SerializedProperty property, GUIContent label) {
	// 	return 30;
	// }
	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label) {
		CustomGradient gradient = (CustomGradient) fieldInfo.GetValue (property.serializedObject.targetObject);
		GUIStyle gradientSyle = new GUIStyle ();
		float labelWidth = GUI.skin.label.CalcSize (label).x + 5;
		Rect texureRect = new Rect (position.x + labelWidth, position.y, position.width - labelWidth, position.height);
		gradientSyle.normal.background = gradient.GetTexture ((int) position.width);
		Event guiEvent = Event.current;
		if (guiEvent.type == EventType.Repaint) {
			GUI.Label (position, label);
			GUI.Label (texureRect, GUIContent.none, gradientSyle);
		} else {
			if (guiEvent.type == EventType.mouseDown && guiEvent.button == 0) {
				if (texureRect.Contains (guiEvent.mousePosition)) {
					EditorWindow.GetWindow<GradientEditor> ();
				}
			}
		}
	}
}