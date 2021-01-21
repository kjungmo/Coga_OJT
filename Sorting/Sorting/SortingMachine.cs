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
        public Sorts SortingAlgorithm { get; set; }
        List<string> InputTextSplitted;
        List<int> InputTextToInt;
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        public SortingMachine()
        {
            return;
        }

        public string SortInputToOutput(string inputText)
        {
            InputTextToInt = ConvertTextToInt(inputText);
            List<int> sortedText = new List<int>();
            if (SortingAlgorithm == Sorts.Bubble)
            {
                sortedText = SortBubble(InputTextToInt);
                return InputToOutput(sortedText);
            }
            else if (SortingAlgorithm == Sorts.Selection)
            {
                sortedText = SortSelection(InputTextToInt);
                return InputToOutput(sortedText);
            }
            else
            {
                sortedText = SortMerge(InputTextToInt);
                return InputToOutput(sortedText);
            }
        }


        public List<int> ConvertTextToInt(string inputText)
        {
            InputText = inputText;
            string[] inputTextToSplit = InputText.Split(delimiterChars);
            InputTextSplitted = new List<string>();
            InputTextToInt = new List<int>();

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

        public List<int> SortBubble(List<int> textToInt)
        {
            List<int> sortedText = InputTextToInt.ToList();
            int count = 0;
            int temp = 0;
            for (int j = 0; j < InputTextToInt.Count - 1; j++)
            {
                for (int i = 0; i < InputTextToInt.Count - 1; i++)
                {
                    if (InputTextToInt[i] > InputTextToInt[i + 1])
                    {
                        temp = InputTextToInt[i + 1];
                        InputTextToInt[i + 1] = InputTextToInt[i];
                        InputTextToInt[i] = temp;
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


        public List<int> SortSelection(List<int> textToInt)
        {
            int temp = 0;
            for (int i = 0; i < InputTextToInt.Count - 1; i++)
            {
                for (int j = i + 1; j < InputTextToInt.Count; j++)
                {
                    if (InputTextToInt[i] > InputTextToInt[j])
                    {
                        temp = InputTextToInt[j];
                        InputTextToInt[j] = InputTextToInt[i];
                        InputTextToInt[i] = temp;
                    }
                }
            }
            return InputTextToInt;
        }

        public List<int> SortMerge(List<int> textToInt)
        {
            if (textToInt.Count == 1)
                return textToInt;
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int midIndex = textToInt.Count / 2;
            for (int i = 0; i < midIndex; i++)
            {
                left.Add(textToInt[i]);
            }

            for (int i = midIndex; i < textToInt.Count; i++)
            {
                right.Add(textToInt[i]);
            }

            left = SortMerge(left);
            right = SortMerge(right);
            return Merge(left, right);
        }

        public List<int> Merge(List<int> mergeLeft, List<int> mergeRight)
        {
            
            List<int> merged = new List<int>();

            while(mergeLeft.Count >= 1 || mergeRight.Count >= 1)
            {
                if (mergeLeft.Count >= 1 && mergeRight.Count >= 1)
                {
                    if(mergeLeft.First() <= mergeRight.First())
                    {
                        merged.Add(mergeLeft.First());
                        mergeLeft.Remove(mergeLeft.First());
                    }
                    else
                    {
                        merged.Add(mergeRight.First());
                        mergeRight.Remove(mergeRight.First());
                    }
                }
                else if( mergeLeft.Count >= 1)
                {
                    merged.Add(mergeLeft.First());
                    mergeLeft.Remove(mergeLeft.First());
                }
                else if( mergeRight.Count >= 1)
                {
                    merged.Add(mergeRight.First());
                    mergeRight.Remove(mergeRight.First());
                }
            }

            return merged;
        }

    }
}
