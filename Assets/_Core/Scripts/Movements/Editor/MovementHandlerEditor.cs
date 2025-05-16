#if UNITY_EDITOR
using UnityEditor;

namespace Pong.Movements.Editor
{
    [CustomEditor(typeof(MovementHandler))]
    public class MovementHandlerEditor : UnityEditor.Editor  
    {
        private SerializedProperty _isClampedMovement;
        private SerializedProperty _clampYMovement;
        
        private void OnEnable()
        {
            _isClampedMovement = serializedObject.FindProperty("_isClampedMovement");
            _clampYMovement = serializedObject.FindProperty("_clampYMovement");
            
        }

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            
            serializedObject.Update();
            if (_isClampedMovement.boolValue)
            {
                EditorGUILayout.PropertyField(_clampYMovement);
            }
            
            serializedObject.ApplyModifiedProperties();
        }
    }
}
#endif