// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IAnswer.cs

namespace Kolobok.Core.Types
{
    public interface IAnswer<T>
    {
        IQuestion< T > Question { get; set; }
        ISocial Respondent { get; set; }
        IAnswerResult<T> Result { get; set; }
    }
}