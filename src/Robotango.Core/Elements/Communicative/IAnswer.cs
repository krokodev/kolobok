// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswer.cs

using Robotango.Core.Interfaces.Abilities;

namespace Robotango.Core.Elements.Communicative
{
    public interface IAnswer<T>
    {
        IQuestion< T > Question { get; set; }
        IRespondent Respondent { get; set; }
        IAnswerResult< T > Result { get; set; }
    }
}