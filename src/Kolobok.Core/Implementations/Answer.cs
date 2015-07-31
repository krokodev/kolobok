// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Answer.cs

using Kolobok.Core.Types;

namespace Kolobok.Core.Implementations
{
    internal struct Answer<T> : IAnswer< T >
    {
        public IQuestion< T > Question { get; set; }
        public ISocial Respondent { get; set; }
        public IAnswerResult< T > Result { get; set; }
    }
}