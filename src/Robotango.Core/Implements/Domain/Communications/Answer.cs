// Robotango (c) 2015 Krokodev
// Robotango.Core
// Answer.cs

using Robotango.Core.Types.Domain.Communications;

namespace Robotango.Core.Implements.Domain.Communications
{
    internal struct Answer<T> : IAnswer< T >
    {
        public IQuestion< T > Question { get; set; }
        public IRespondent Respondent { get; set; }
        public IAnswerResult< T > Result { get; set; }
    }
}