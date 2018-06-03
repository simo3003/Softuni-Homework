using System;
using System.Numerics;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.242);
            uint hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong miliseconds = seconds * 1000;
            ulong microseconds = miliseconds * 1000;
            BigInteger nanoseconds = microseconds;
            nanoseconds *= 1000;
            Console.WriteLine($"{centuries:f0} centuries = {years:f0} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes = {seconds:f0} seconds = {miliseconds:f0} milliseconds = {microseconds:f0} microseconds = {nanoseconds:f0} nanoseconds");
        }
    }
}
