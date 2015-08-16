// Robotango (c) 2015 Krokodev
// Robotango.Common
// OutlineWriter.cs

using System.Text;

namespace Robotango.Common.Utils.Tools
{
    public class OutlineWriter
    {
        private string _indent;
        private readonly StringBuilder _sb;
        private int _level;

        public OutlineWriter( int level, int n = 2 )
        {
            _sb = new StringBuilder();
            Width = n;
            Level = level;
        }

        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                _indent = new string( ' ', _level*Width );
            }
        }

        public int Width { get; set; }

        public override string ToString()
        {
            return _sb.ToString();
        }

        public void Append( string str )
        {
            _sb.Append( str );
        }

        public void Append( string template, params object[] args )
        {
            _sb.AppendFormat( template, args );
        }

        public void Indent()
        {
            _sb.Append( _indent );
        }

        public void Line( string template, params object[] args )
        {
            _sb.Append( _indent );
            _sb.AppendFormat( template, args );
            _sb.AppendLine();
        }

        public void NewLine( string template, params object[] args )
        {
            _sb.AppendLine();
            _sb.Append( _indent );
            _sb.AppendFormat( template, args );
        }

        public void Line( string str = "" )
        {
            _sb.Append( _indent );
            _sb.Append( str );
            _sb.AppendLine();
        }

        public static string Line( int level, string template, params object[] args )
        {
            var wr = new OutlineWriter( level );
            wr.Line( template, args );
            return wr.ToString();
        }

        public static string NewLine( int level, string template, params object[] args )
        {
            var wr = new OutlineWriter( level );
            wr.Line();
            wr.Indent();
            wr.Append( template, args );
            return wr.ToString();
        }

    }
}