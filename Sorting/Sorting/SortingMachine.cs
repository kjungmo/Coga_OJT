using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SortingMachine
    {
        public string InputText { get; set; }
        List<string> InputTextSplitted = new List<string>();
        List<int> InputTextToInt = new List<int>();
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        public SortingMachine()
        {
            return;
        }

        public string SortInputToOutput(string inputText)
        {
            string outputs = "";
            InputTextToInt = ConvertTextToInt(inputText);
            List<int> sortedText = new List<int>();
            sortedText = Sorted(InputTextToInt);
            outputs = InputToOutput(sortedText);
            return outputs;
        }

        public List<int> ConvertTextToInt(string inputText)
        {
            InputText = inputText;
            string[] inputTextToSplit = InputText.Split(delimiterChars);
            foreach (var word in inputTextToSplit)
            {
                if (word == "")
                    continue;
                InputTextSplitted.Add(word);
            }
     
            for (int i = 0; i < InputTextSplitted.Count; i++)
            {
                
                InputTextToInt.Add(int.Parse(InputTextSplitted[i]));
            }
            return InputTextToInt;
        }

        public List<int> Sorted(List<int> textToInt)
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
                if (count == InputTextToInt.Count - 1)
                    return InputTextToInt;
            }
            return sortedText;
        }

        public string InputToOutput(List<int> sortedText)
        {
            string outputText = "";
            foreach (int number in sortedText)
            {
                outputText += number;
                outputText += " ";
            }
            return outputText;
        }

    }
}
