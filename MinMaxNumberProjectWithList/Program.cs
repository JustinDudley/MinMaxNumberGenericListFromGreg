using System;
using System.Collections.Generic;

namespace MinMaxNumberProjectWithList {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int>();
            numbers.Add(5930);
            numbers.Add(7643);
            numbers.Add(6168);
            numbers.Add(9491);
            numbers.Add(5296);
            numbers.Add(6762);
            numbers.Add(7554);
            numbers.Add(1751);
            numbers.Add(9037);
            numbers.Add(8939);
            numbers.Add(9206);
            numbers.Add(2021);

            var min = int.MaxValue;
            var max = int.MinValue;
            foreach(var nbr in numbers) {
                if(nbr < min) { min = nbr; }
                if(nbr > max) { max = nbr; }
            }

            #region Short answer
            numbers.Sort();
            min = numbers[0];
            max = numbers[numbers.Count - 1];
            #endregion
            Console.WriteLine($"Min is {min} and max is {max}");
        }
    }
}
