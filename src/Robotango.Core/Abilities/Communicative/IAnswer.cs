// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswer.cs

namespace Robotango.Core.Abilities.Communicative
{
    public interface IAnswer<out T>
    {
        IQuestion< T > Question { get; }
        IRespondent Respondent { get; }
        IAnswerResult< T > Result { get; }
    }
}