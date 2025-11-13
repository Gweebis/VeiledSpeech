#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiledSpeechPrototype
{
    /// <summary>
    /// Value that determines the emotion from a prompt.
    /// </summary>
    public enum Emotion
    {
        Undetermined,
        Happy,
        Angry,
        Sad,
        Scared
    }

    /// <summary>
    /// Represents the prompt a user will receive & answer
    /// </summary>
    public class Prompt(string question)
    {
        public string Question { get; } = question;

        public string? Response { get; set; }

        public List<Emotion> DetermineResponseEmotions()
        {
            List<Emotion> emotions = new();
            if (Response != null)
            {
                List<string> words = Response.Split(' ').Where(x => !Int32.TryParse(x, out _)).ToList();
                foreach (var word in words)
                {
                    Emotion foundEmotion;
                    if(Enum.TryParse(word, true, out foundEmotion))
                    {
                        emotions.Add(foundEmotion);
                    }
                }
            }
            return emotions.Count != 0 ? emotions : [Emotion.Undetermined];
        }
    }
}
