// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswer.cs

using Robotango.Core.Types.Agency.Abilities;

namespace Robotango.Core.Types.Communications
{
    public interface IAnswer<T>
    {
        IQuestion< T > Question { get; set; }
        IRespondent Respondent { get; set; }
        IAnswerResult< T > Result { get; set; }
    }
}