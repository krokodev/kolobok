// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswer.cs

using Robotango.Core.Abilities;

namespace Robotango.Core.Elements.Communicative
{
    public interface IAnswer<out T>
    {
        IQuestion< T > Question { get; }
        IRespondent Respondent { get; }
        IAnswerResult< T > Result { get; }
    }
}