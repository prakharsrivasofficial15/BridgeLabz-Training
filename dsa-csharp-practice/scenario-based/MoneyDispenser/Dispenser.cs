using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyDispenser
{
    internal class Dispenser
    {
        //takes input of note types and their available count
        public Dictionary<int, int> NoteDetails(int numberOfNoteTypes)
        {
            Dictionary<int, int> totalNotes = new Dictionary<int, int>();

            for (int i = 0; i < numberOfNoteTypes; i++)
            {
                Console.WriteLine("Enter note value:");
                int noteValue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number of notes available:");
                int availableCount = Convert.ToInt32(Console.ReadLine());

                totalNotes.Add(noteValue, availableCount);
            }

            return totalNotes;
        }

        //scenario A & B
        public void DispenseMinimumNotes(int requestedAmount, int numberOfNoteTypes)
        {
            int originalAmount = requestedAmount;

            Dictionary<int, int> noteInventory = NoteDetails(numberOfNoteTypes);

            //sort notes in descending order
            var sortedNotes = noteInventory.OrderByDescending(note => note.Key);

            Dictionary<int, int> dispensedNotes = new Dictionary<int, int>();

            foreach (var note in sortedNotes)
            {
                int noteValue = note.Key;
                int availableCount = note.Value;

                if (requestedAmount >= noteValue)
                {
                    int requiredNotes = requestedAmount / noteValue;
                    int notesToUse = Math.Min(requiredNotes, availableCount);

                    if (notesToUse > 0)
                    {
                        dispensedNotes.Add(noteValue, notesToUse);
                        requestedAmount -= notesToUse * noteValue;
                    }
                }
            }

            //scenario C: Fallback case
            if (requestedAmount != 0)
            {
                int fallbackAmount = originalAmount - requestedAmount;
                Console.WriteLine($"Exact amount not possible. So, dispensing fallback amount: ₹{fallbackAmount}");
            }
            else
            {
                Console.WriteLine("Exact amount can be dispensed using the following notes:");
            }

            foreach (var note in dispensedNotes)
            {
                Console.WriteLine($"₹{note.Key} x {note.Value}");
            }
        }

        //Enter the amount needed and no. of types of notes 
        public void StartATM()
        {
            Console.WriteLine("Enter the amount to withdraw:");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of note types:");
            int numberOfNoteTypes = Convert.ToInt32(Console.ReadLine());

            DispenseMinimumNotes(amount, numberOfNoteTypes);
        }

        //main
        static void Main(string[] args)
        {
            Dispenser atm = new Dispenser();
            atm.StartATM();
        }
    }
}
