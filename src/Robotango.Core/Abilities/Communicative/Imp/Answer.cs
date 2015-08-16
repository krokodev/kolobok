// Robotango (c) 2015 Krokodev
// Robotango.Core
// Answer.cs

namespace Robotango.Core.Abilities.Communicative.Imp
{
    internal struct Answer<T> : IAnswer< T >
    {
        public IQuestion< T > Question { get; set; }
        public IRespondent Respondent { get; set; }
        public IAnswerResult< T > Result { get; set; }
    }
}