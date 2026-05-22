using System.Text;
using System.Linq;

class Game{
    // Make your changes in this file

    private string phrase;

    public Game(string phrase){
        this.phrase = phrase.ToUpper();
    }

    public string DisplayBlanks(){
        StringBuilder blanks = new StringBuilder();

        foreach (char c in phrase){
            if (c == ' '){
                blanks.Append(" ");
            } else {
                blanks.Append("_");
            }
        }

        return blanks.ToString().TrimEnd();

        
    }

    public string Play(char[] guessedLetters){

        string guessed = new string(guessedLetters).ToUpper();

        if (!IsValid(guessed)){
            return DisplayBlanks();
        }

        StringBuilder result = new StringBuilder();

        foreach (char c in phrase){
            if (c == ' '){
                result.Append(c + " ");
            }
            else if (guessed.Contains(c)){
                result.Append(c + " ");
            }
            else{
                result.Append("_");
            }
        }

        return result.ToString().TrimEnd();
    }
        
    public bool IsValid(string guessedLetters){
        if (guessedLetters.Length != 10){
            return false;
        }

        if (guessedLetters.Contains(" ")){
            return false;
        }

        if (!guessedLetters.All(char.IsLetter)){
            return false;
        }

        return true;

    }
}
