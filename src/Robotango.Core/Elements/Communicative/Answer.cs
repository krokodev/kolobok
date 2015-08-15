// Robotango (c) 2015 Krokodev
// Robotango.Core
// Answer.cs

using Robotango.Core.Abilities;

namespace Robotango.Core.Elements.Communicative
{
    internal struct Answer<T> : IAnswer< T >
    {
        public IQuestion< T > Question { get; set; }
        public IRespondent Respondent { get; set; }
        public IAnswerResult< T > Result { get; set; }
    }
}