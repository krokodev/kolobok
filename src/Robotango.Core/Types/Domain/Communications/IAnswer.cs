// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswer.cs

using Robotango.Core.Types.Domain.Abilities;

namespace Robotango.Core.Types.Domain.Communications
{
    public interface IAnswer<T>
    {
        IQuestion< T > Question { get; set; }
        ICommunicative Respondent { get; set; }
        IAnswerResult< T > Result { get; set; }
    }
}