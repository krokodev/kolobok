// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswer.cs

using Robotango.Core.Types.Abilities;

namespace Robotango.Core.Types.Domain.Communications
{
    public interface IAnswer<T>
    {
        IQuestion< T > Question { get; set; }
        IRespondent Respondent { get; set; }
        IAnswerResult< T > Result { get; set; }
    }
}