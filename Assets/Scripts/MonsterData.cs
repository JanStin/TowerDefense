using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterData : MonoBehaviour
{
    public List<MonsterLevel> levels;

    private MonsterLevel _currentLevel;

    public MonsterLevel CurrentLevel
    {
        get
        {
            return _currentLevel;
        }

        set
        {
            _currentLevel = value;
            int currentLevelIndex = levels.IndexOf(_currentLevel);

            GameObject levelVisualization = levels[currentLevelIndex].visualization;
            for (int i = 0; i < levels.Count; i++)
            {
                if (levelVisualization != null)
                {
                    if (i == currentLevelIndex)
                    {
                        levels[i].visualization.SetActive(true);
                    }
                    else
                    {
                        levels[i].visualization.SetActive(false);
                    }
                }
            }
        }
    }

    private void OnEnable()
    {
        CurrentLevel = levels[0];
    }
}
