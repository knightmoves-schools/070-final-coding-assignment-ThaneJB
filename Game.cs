class Game{
    // Make your changes in this file

    public Game(string phrase)
    {
    }

    public string DisplayBlanks(){
        return "_ _ _ _  _ _ _ _  _ _ _ _  _ _ _  _ _ _ _";
    }

    public string Play(char[] guessedLetters){
        return "MAKE THIS WORK FOR REAL";
    }
        
    public bool IsValid(string guessedLetters){
        int lettersAsInt = guessedLetters.Length;

        if(lettersAsInt > 10 || lettersAsInt < 10 || guessedLetters.Contains(" ")){
            return false; 
        } 
            return true; 
            
    }
}
