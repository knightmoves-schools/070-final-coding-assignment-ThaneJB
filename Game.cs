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
        if(guessedLetters > 10 || guessedLetters < 10 || guessedLetters == " "){
            return false;
        } 
            return true;
    }
}
