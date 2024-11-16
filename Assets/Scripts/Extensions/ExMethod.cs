namespace Extensions {
    public static class ExMethod
    {
        public static string[] GetSplitChar(this string input){        
            string[] splited = new string[input.Length];
            for (int i = 0; i< input.Length; i++) {
                splited[i] = input[i].ToString();
            }
            return splited;
        }
    }
}