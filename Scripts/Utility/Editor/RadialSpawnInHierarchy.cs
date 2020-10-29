/**
 * Author: KHeartz
 */

using UnityEditor;
using UnityEngine;

public class RadialSpawnInHierarchy : ScriptableWizard
{
    [Tooltip("Reference Game Object (This will not be spawned).")]
    public GameObject referenceGO = null;

    [Tooltip("Number of students. (Num - 1 will be created)")]
    public int numberOfStudents = 16;

    [Tooltip("Radius of Character circle")]
    public float radius = 8.0f;

    [MenuItem("Tools/DREditor/Radial Spawn")]
    public static void CreateWizard()
        => DisplayWizard<RadialSpawnInHierarchy>("Radial Spawn", "Spawn");

    private void OnWizardCreate()
    {
        Transform parent = referenceGO.transform.parent;
        float dTheta = 360.0f / numberOfStudents;
        for (int i = 1; i < numberOfStudents; i++)
        {
            float newThetaDeg = dTheta * i;
            float newThetaRad = Mathf.Deg2Rad * newThetaDeg;
            GameObject newGO = GameObject.Instantiate(referenceGO, parent);
            Vector3 pos = new Vector3(radius * Mathf.Sin(newThetaRad), 0.0f, radius * Mathf.Cos(newThetaRad));
            newGO.transform.position = pos;
            newGO.transform.rotation = Quaternion.Euler(0.0f, newThetaDeg, 0.0f);
        }
    }
}
