using System;
using static System.Console;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
		WriteLine("-------------------------------------------------------");
            	WriteLine("Type\t NumberOfBytes\t Min\t\t Max");
		WriteLine("-------------------------------------------------------");
		Write("{0}\t {1}\t\t {2}\t\t {3}\t\n","sbyte",sizeof(sbyte),sbyte.MinValue,sbyte.MaxValue);
		Write("{0}\t {1}\t\t {2}\t\t {3}\t\n","byte",sizeof(byte),byte.MinValue,byte.MaxValue);
		Write("{0}\t {1}\t\t {2}\t\t {3}\t\n","short",sizeof(short),short.MinValue,short.MaxValue);
		Write("{0}\t {1}\t\t {2}\t\t {3}\t\n","ushort",sizeof(ushort),ushort.MinValue,ushort.MaxValue);
		Write("{0}\t {1}\t\t {2}\t {3}\t\n","int",sizeof(int),int.MinValue,int.MaxValue);
		
        }
    }
}
