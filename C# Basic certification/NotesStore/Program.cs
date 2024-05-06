using System;
using System.Collections.Generic;
using System.IO;

namespace Solution
{

    public class NotesStore
    {
        public const string completed = "completed";
        public const string active = "active";
        public const string others = "others";

        public string name { get; set; }
        public string state { get; set; }
        public NotesStore() {
            Notes = new List<string>();
        }
        public void AddNote(String state, String name) 
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }
            if(!state.Equals(completed) && !state.Equals(active) && !state.Equals(others))
            {
                throw new Exception($"Invalid state {state}");
            }
            Notes.Add(state+ " "+ name);
        }

        public List<string> Notes { get; set; }
        public List<String> GetNotes(String state) 
        {
            if (!state.Equals(completed) && !state.Equals(active) && !state.Equals(others))
            {
                throw new Exception($"Invalid state {state}");
            }
            if(Notes.Any(x => x.Contains(state)))
            {
                var notes =  Notes.Select(x => x).Where(x => x.Contains(state)).ToList();
                var result = new List<string>();
                foreach(var note in notes)
                {
                    var i = 0;
                    string[] words = note.Split(' ');
                    result[i]=  words[words.Length - 1];
                    i++;
                }
                return result;
            }
            return new List<string>();
        }
    }

    public class Solution
    {
        public static void Main()
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}