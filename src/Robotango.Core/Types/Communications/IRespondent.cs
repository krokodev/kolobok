// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRespondent.cs

namespace Robotango.Core.Types.Communications
{
    public interface IRespondent
    {
        IAnswer< T > Reply<T>( IQuestion< T > question );
       
    }
}