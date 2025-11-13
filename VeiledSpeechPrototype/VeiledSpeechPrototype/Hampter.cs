using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiledSpeechPrototype
{
    public class Hampter
    {
        public Hampter() { }
        public string GenerateEmotionalInterpretation(List<Emotion> emotions)
        {
            string interpretation = "";
            if (emotions.Count == 0)
            {
                interpretation += "I see that there is not much for you to say.";
            }
            if (emotions.ElementAt(0) == Emotion.Undetermined)
            {
                interpretation += "I understand that it is hard to articulate how you feel. I will give you space, yet I will always be by your side.";
            }
            else
            {
                interpretation += "I can tell that you are feeling ";
                for (int i = 0; i <= emotions.Count - 1; i++)
                {
                    if (emotions.Count > 2)
                    {
                        if (i == emotions.Count - 1) { interpretation += "and " + emotions.ElementAt(i).ToString().ToLower(); }
                        else { interpretation += emotions.ElementAt(i).ToString().ToLower() + ", "; }
                    }
                    else if (emotions.Count == 2 && i == 1)
                    {
                        interpretation += " and " + emotions.ElementAt(i).ToString().ToLower();
                    }
                    else
                    {
                        interpretation += emotions.ElementAt(i).ToString().ToLower();
                    }
                }
                interpretation += ".";
            }
            return interpretation;
        }
    }
}
