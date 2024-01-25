using System.Text;
using UnityEditor;
using UnityEngine;

namespace StdNounou.AssetsCreator.Editor
{
    public class EnumsCreator : MonoBehaviour
    {
        [MenuItem("StdNounou/CreateFile/ComponentEnum")]
        private static void CreateComponentEnum()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("namespace StdNounou.Core \n");
            sb.Append("{\n");
            sb.Append("    public enum E_ComponentsKeys\n");
            sb.Append("    {\n");
            sb.Append("        Rigidbody,\n");
            sb.Append("        AudioPlayer,\n");
            sb.Append("        Renderer,\n");
            sb.Append("        HealthSystem,\n");
            sb.Append("        StatsHandler\n");
            sb.Append("    }\n");
            sb.Append("}");

            EditorCreates.TryCreateFolder("StdNounou", "Assets");
            EditorCreates.TryCreateFolder("Keys", "Assets/StdNounou");
            EditorCreates.TryCreateFolder("Components", "Assets/StdNounou/Keys");
            EditorCreates.CreateFile("ComponentsKeys", "Assets/StdNounou/Keys/Components/", ".cs", sb.ToString(), false);

            //create assembly def with stdnounou.core.runtime
            EditorCreates.CreateAssemblyDefinition("StdNounou.core.runtime_ref", "Assets/StdNounou/Keys/Components/", true, "GUID:07390520b8bc5a54cb973a134834aabf");
        }

        [MenuItem("StdNounou/CreateFile/StatsEnum")]
        private static void CreateStatsEnum()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("namespace StdNounou.Stats \n");
            sb.Append("{\n");
            sb.Append("    public enum E_StatsKeys\n");
            sb.Append("    {\n");
            sb.Append("        Health,\n");
            sb.Append("        Damages,\n");
            sb.Append("        DamageReduction,\n");
            sb.Append("        CritChances,\n");
            sb.Append("        CritMultiplier,\n");
            sb.Append("        AttackCooldown,\n");
            sb.Append("        Speed,\n");
            sb.Append("        Weight,\n");
            sb.Append("        KnockbackForce\n");
            sb.Append("    }\n");
            sb.Append("}");

            EditorCreates.TryCreateFolder("StdNounou", "Assets");
            EditorCreates.TryCreateFolder("Keys", "Assets/StdNounou");
            EditorCreates.TryCreateFolder("Stats", "Assets/StdNounou/Keys");
            EditorCreates.CreateFile("StatsKeys", "Assets/StdNounou/Keys/Stats/", ".cs", sb.ToString(), false);

            //create assembly def with stdnounou.stats.runtime
            EditorCreates.CreateAssemblyDefinition("StdNounou.stats.runtime_ref", "Assets/StdNounou/Keys/Stats/", true, "GUID:6ddfdff7ac37b354883336b81ebb5114");
        }
    } 
}
