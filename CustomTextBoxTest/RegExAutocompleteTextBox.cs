using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTextBoxTest
{
    class RegExAutocompleteTextBox : TextBox
    {
        private Dictionary<string, string> searchIndex = new Dictionary<string, string>();
        private char[] searchSplitters = { '-', ' ', '#', ';', '.', ':', ',', '_', '\'', '+' };

        private bool isAutoCompletionTextChanged = false;

        public RegExAutocompleteTextBox()
        {
            searchIndex.Add("hallo", "hai");
            searchIndex.Add("dasdas", "hai");
            searchIndex.Add("haldasdlo", "hai");
            searchIndex.Add("haldasdalo", "hai");
            searchIndex.Add("halsdalo", "hai");
            searchIndex.Add("hadasallo", "hai");
            searchIndex.Add("hdallo", "hai");
            searchIndex.Add("hsdaallo", "hai");
            searchIndex.Add("hasallo", "hai");
            searchIndex.Add("hasdallo", "hai");
            searchIndex.Add("haallo", "hai");
            searchIndex.Add("hsallo", "hai");
            searchIndex.Add("hdasdallo", "hai");
            searchIndex.Add("haadallo", "hai");
            searchIndex.Add("hadsdallo", "hai");
            searchIndex.Add("hdaaallo", "hai");
            searchIndex.Add("hdadasdasdllo", "hai");
            searchIndex.Add("dadsads", "hai");
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            long ticksBefore = DateTime.Now.Ticks;
            var result = GetAutoCompleteList(base.Text);
            Console.WriteLine("Time: " + ((DateTime.Now.Ticks - ticksBefore) / TimeSpan.TicksPerMillisecond));
            foreach (KeyValuePair<string, string> kvp in result)
            {
                Console.WriteLine(kvp.Key);
            }
        }

        protected Dictionary<string, string> GetAutoCompleteList(string searchText)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> kvp in searchIndex)
            {
                string[] keySearches = kvp.Key.Split(searchSplitters);
                string[] searchTextParts = searchText.Split(searchSplitters);
                bool[] textPartExists = new bool[searchTextParts.Length];
                for (int i = 0; i < textPartExists.Length; i++)
                {
                    textPartExists[i] = false;
                }
                for (int i = 0; i < searchTextParts.Length; i++)
                {
                    string currSearchText = searchTextParts[i];
                    for (int x = 0; x < keySearches.Length; x++)
                    {
                        string currKeySearch = keySearches[x];

                        if (MatchesRegEx(currSearchText, currKeySearch))
                        {
                            textPartExists[i] = true;
                            break;
                        }

                    }
                }
                bool isMatch = true;
                for (int i = 0; i < textPartExists.Length; i++)
                {
                    if (!textPartExists[i])
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch) result.Add(kvp.Key, kvp.Value);
            }

            return result;
        }

        protected bool MatchesRegEx(string stringToSearch, string stringToBeSearched)
        {
            long ticksBefore = DateTime.Now.Ticks;
            bool result = false;
            string regExPattern = "(" + stringToSearch + ")";
            result = System.Text.RegularExpressions.Regex.IsMatch(stringToBeSearched, regExPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            Console.WriteLine("Time-single: " + ((DateTime.Now.Ticks - ticksBefore) / TimeSpan.TicksPerMillisecond));
            return result;
        }

    }
}
