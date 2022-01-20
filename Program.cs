// <copyright file="Program.cs" company="Alyona">
// Copyright (c) 2022 All Rights Reserved
// </copyright>

namespace MethodGetAllStudents
{
   using System;
   using System.Linq;

   /// <summary>
   /// Program Class. 
   /// </summary>
   public class Program
   {
      /// <summary>
      /// Main Method.
      /// </summary>
      static void Main(string[] args)
      {
         var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
         var allStudents = GetAllStudents(classes);
         Console.WriteLine(string.Join(" ", allStudents));
      }

      /// <summary>
      /// Getting an array with all students.
      /// </summary>
      /// <returns>Array with all students.</returns>
      static string[] GetAllStudents(Classroom[] classes)
      {
         var students = from c in classes from s in c.Students select s;
         string[] allStudents = students.ToArray();
         return allStudents;
      }
   }
}
