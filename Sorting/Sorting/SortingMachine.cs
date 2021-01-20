using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SortingMachine
    {
        public string InputText { get; private set; }
        public List<string> InputTextSplitted { get; set; }
        public List<int> InputTextToInt { get; private set; }
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        public SortingMachine()
        {
            return;
        }

        public List<int> ConvertTextToInt(string inputText)
        {
            InputText = inputText;
            string[] inputTextToSplit = InputText.Split(delimiterChars);
            foreach (var word in inputTextToSplit)
            {
                InputTextSplitted.Add(word);
            }
     
            for (int i = 0; i < InputTextSplitted.Count; i++)
            {
                InputTextToInt.Add(int.Parse(InputTextSplitted[i]));
            }
            return InputTextToInt;
        }

        public List<int> Sorted()
        {
            List<int> sortedText = InputTextToInt.ToList();
            int count = 0;
            int temp = 0;
            for (int i = 0; i < InputTextToInt.Count - 1; i++)
            {
                for (int j = 0; j < InputTextToInt.Count - 1; j++)
                {
                    if (InputTextToInt[i] > InputTextToInt[i + 1])
                    {
                        temp = InputTextToInt[i];
                        InputTextToInt[i] = InputTextToInt[i + 1];
                        InputTextToInt[i + 1] = temp;
                        sortedText[i] = InputTextToInt[i];
                        sortedText[i + 1] = InputTextToInt[i + 1];
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            if (count == InputTextToInt.Count - 1)
                return InputTextToInt;
            else 
                return sortedText;
        }

    }
}
