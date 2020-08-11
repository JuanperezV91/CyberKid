using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionsDataT2", menuName = "QuestionsDataT2", order = 1)]
public class QuizDataScriptableT2 : ScriptableObject
{
    public List<QuestionT2> questions;
}
