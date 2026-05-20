class Game{
    // Make your changes in this file

    public Game(string phrase){
        this.phrase = phrase;
    }

    public string DisplayBlanks(){
        string result = " ";

        foreach (char c in phrase){
            if (c == ' '){
                result += " ";
            } else {
                result += "_";
            }
        }

        return result.TrimEnd();

        
    }

    public string Play(char[] guessedLetters){




        return ;
    }
        
    public bool IsValid(string guessedLetters){
        int lettersAsInt = guessedLetters.Length;

        if(lettersAsInt > 10 || lettersAsInt < 10 || guessedLetters.Contains(" ")){
            return false; 
        } 
            return true; 

    }
}
