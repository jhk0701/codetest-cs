namespace Test
{
    public class SkillTree
    {
        public int Answer { get; private set; }

        public SkillTree(string skill, ref string[] skill_trees)
        {
            Answer = 0;

            for (int i = 0; i < skill_trees.Length; i++)
            {
                string curSkill = skill_trees[i];
                int idx = 0;

                for (int j = 0; j < curSkill.Length; j++)
                {
                    if (skill.Contains(curSkill[j]))
                    {
                        if (curSkill[j] == skill[idx])
                            idx++;
                        else
                            break;
                    }

                    if (j == curSkill.Length - 1)
                        Answer++;
                }
            }
        }
    }
}
