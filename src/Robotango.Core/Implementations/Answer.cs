// Robotango (c) 2015 Krokodev
// Robotango.Core
// Answer.cs

using Robotango.Core.Types;

namespace Robotango.Core.Implementations
{
    internal struct Answer<T> : IAnswer< T >
    {
        public IQuestion< T > Question { get; set; }
        public ISocial Respondent { get; set; }
        public IAnswerResult< T > Result { get; set; }
    }
}