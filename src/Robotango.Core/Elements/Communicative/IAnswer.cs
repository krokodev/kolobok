// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswer.cs

using Robotango.Core.Interfaces.Abilities;

namespace Robotango.Core.Elements.Communicative
{
    public interface IAnswer<out T>
    {
        IQuestion< T > Question { get; }
        IRespondent Respondent { get; }
        IAnswerResult< T > Result { get; }
    }
}