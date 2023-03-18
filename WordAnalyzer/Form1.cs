using System.Linq;
using System.Text;

namespace WordAnalyzer
{
    public partial class WordAnalyzer : Form
    {
        static  List<string> TextWords = new List<string>();
        private CancellationTokenSource _cts;
        public WordAnalyzer()
        {
            InitializeComponent();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath);
                if (fileExtension.CompareTo(".txt") == 0)
                {
                    try
                    {
                        string? line = "";
                        StreamReader sr = new StreamReader(filePath);
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] words = line.Trim().Split(" ");
                            foreach (var word in words)
                            {
                                if (_cts.IsCancellationRequested)
                                {
                                    break;
                                }

                                if (word.Length > 2)
                                {
                                    TextWords.Add(word);
                                }
                            }
                        }

                        Thread longestWordThread = new Thread(FindLongestWord);
                        Thread shortestWordThread = new Thread(FindShortestWord);
                        Thread avgLengthThread = new Thread(FindAverageWordLength);
                        Thread topFiveMostCommonThread = new Thread(FindTopFiveMostCommonWords);
                        Thread topFiveLeastCommonThread = new Thread(FindTopFiveLeastCommonWords);

                        longestWordThread.Start(_cts.Token);
                        shortestWordThread.Start(_cts.Token);
                        avgLengthThread.Start(_cts.Token);
                        topFiveMostCommonThread.Start(_cts.Token);
                        topFiveLeastCommonThread.Start(_cts.Token);
                        

                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }
                }
            }
            NumberOfWordsLbl.Text = TextWords.Count.ToString();
            TextWords = new List<string>();
        }

        private void FindLongestWord(object tkn)
        {
            CancellationToken token = (CancellationToken)tkn;
            int wordLength = 0;
            string longestWord = "";
            foreach (var currentWord in TextWords)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                if (wordLength < currentWord.Length)
                {
                    wordLength = currentWord.Length;
                    longestWord = currentWord;
                }
            }
            LongestWordLbl.Text = longestWord;
        }

        private void FindShortestWord(object tkn)
        {
            CancellationToken token = (CancellationToken)tkn;

            int wordLength = Int32.MaxValue;
            string shortestWord="";
            foreach (var currentWord in TextWords)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                if (wordLength > currentWord.Length)
                {
                    wordLength = currentWord.Length;
                    shortestWord = currentWord;
                }
            }
            ShortestWordLbl.Text = shortestWord;
        }

        private void FindAverageWordLength(object tkn)
        {
            CancellationToken token = (CancellationToken)tkn;

            double wordLength = 0;
            double textWordsCount = TextWords.Count;
            foreach (var word in TextWords)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                wordLength += word.Length;
            }

            double averageWordLength = wordLength / textWordsCount;
            AvgWordLenght.Text = averageWordLength.ToString("F");
        }

        private void FindTopFiveMostCommonWords(object tkn)
        {
            CancellationToken token = (CancellationToken)tkn;
            Dictionary<string, int> topFiveCommonWords = new Dictionary<string, int>();
            foreach (var textWord in TextWords)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                if (topFiveCommonWords.ContainsKey(textWord))
                {
                    topFiveCommonWords[textWord]++;
                }
                else
                {
                    topFiveCommonWords[textWord] = 1;
                }
            }

            string[] mostCommonWords = topFiveCommonWords.OrderByDescending(x => x.Value).Select(x => x.Key).Take(5).ToArray();
            PrintWords(mostCommonWords, MostCommonWordsLbl);
        }
        private void FindTopFiveLeastCommonWords(object tkn)
        {
            CancellationToken token = (CancellationToken)tkn;
            Dictionary<string, int> topFiveCommonWords = new Dictionary<string, int>();
            foreach (var textWord in TextWords)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                if (topFiveCommonWords.ContainsKey(textWord))
                {
                    topFiveCommonWords[textWord]++;
                }
                else
                {
                    topFiveCommonWords[textWord] = 1;
                }
            }

            string[] leastCommonWords = topFiveCommonWords.OrderBy(x => x.Value).Select(x => x.Key).Take(5).ToArray();
            PrintWords(leastCommonWords, LeastCommonWordsLbl);
        }

        private void PrintWords(string[] words, Label label)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sb.AppendLine($"{i + 1}. {words[i]}");
            }

            label.Text = sb.ToString().TrimEnd();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (_cts != null) _cts.Cancel();
        }
    }
}