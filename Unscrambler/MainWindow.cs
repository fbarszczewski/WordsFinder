using scrabbleMoreAble.Workers;
using System;
using System.Windows.Forms;

namespace scrabbleMoreAble
{


    public partial class MainWindow : Form
    {
        private static readonly FileReader reader = new FileReader();
        private static readonly WordMatcher matcher = new WordMatcher();
        
        public MainWindow()
        {
            InitializeComponent();
            //load word list
            reader.Read("Data\\wordlist_pl.txt");
        }

        private void UnscrambleButton_Click(object sender, EventArgs e)
        {
            FoundWordsTextBox.Clear();
            matcher.Match(reader.Output, ScrambledTextBox.Text);

            foreach (var foundWord in matcher.MatchedWords)
            {
                FoundWordsTextBox.Text += foundWord + ", ";
            }
        }


        private void FindWords()
        {
            matcher.Match(reader.Output, ScrambledTextBox.Text);

            foreach (var foundWord in matcher.MatchedWords)
            {
                FoundWordsTextBox.Text += foundWord + ", ";
            }
        }
    }
}
