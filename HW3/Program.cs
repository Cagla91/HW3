	using System;
	
	//These classes can be used to reads and write data to files
	using System.IO;
	
	namespace HW2
	{
	    class Program
	    {

        public static void frequency_letter(String str)
        {

            int[] c = new int[(int)char.MaxValue];
            Console.Write("Please Enter Fıle Path:");

            string fdpath = Console.ReadLine();

            string text = File.ReadAllText(fdpath);

            foreach (char t in fdpath)
            {
                // Increment table.
                c[(int)t]++;
            }

            // 4.
            // Write all letters found.
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i] > 0 && char.IsLetterOrDigit((char)i))
                {
                    //Console.WriteLine("Letter: {0}  Frequency: {1}", (char)i, c[i]);
                    //(char)i,
                    //c[i]);

                    Console.Write((char)i + "->" + c[i] + ",");
                }
            }
        }

        //Shift Count Algorithm. Read the string characters one by one which is located inside the file and shifting the caharacters by shiftAmount.
        public static string ShiftText(char[] alphabet, string input, int shiftAmount)
	        {
	            if (input == null) return null;
	
	            int len = alphabet.Length;
	
	            shiftAmount %= len;
	
            var shiftedText = string.Empty;
	
	            foreach (var character in input)
	            {
	                var index = Array.IndexOf(alphabet, character);
	
                if (index< 0)
	                {
	                    // This character isn't in the array, so don't change it
	                    shiftedText += character;
                }
                else
                    {
    	                    var newIndex = index - shiftAmount;
    	
                    // If it's negative, wrap around to end of array
                    if (newIndex < 0) newIndex += len;
    
	                    shiftedText += alphabet[newIndex];
                    }
	            }

	            return shiftedText;
	        }
	
	        //Third field: Alphabet Type 0 for English, 1 for French, 2 for Spanish, 3 for Turkish. enalphabet represent English alphabet, fralphabet represent French alphabet 
	        //tralphabet represent Turkish alphabet and spalphabet represent Spanish alphabet.
	        public static string LanguageCipher(string input, int key, int Language)
	        {
  	
	            char[] enalphabet = new char[52] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; /*----ENGLİSH*/
  	
	            char[] fralphabet = new char[52] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; /*----FRENCH*/
   	
	            char[] tralphabet = new char[58] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };/* ----TURKÇE-- - 29*/
   
	            char[] spalphabet = new char[54] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'İ', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; /*----SPANISH-------- - 27*/
   	

            char[] alphabet = tralphabet;
    
            //Alphabet Type 0 for English, 1 for French, 2 for Spanish, 3 for Turkish
            if (Language == 0)
                    {
       	                alphabet = enalphabet;
                   }
               else
        
               if (Language == 1)
                    {
                        alphabet = fralphabet;
                    }
                else
                        if (Language == 2)
                   {
				       alphabet = spalphabet;
                  	            }
   	            else
        	                if (Language == 3)
                    {
                        alphabet = tralphabet;
                  }
             return ShiftText(alphabet, input, key);
    	
        }
	
	
	        //Read .txt file from given path which is you eneterd in the console.
	        static void Main(string[] args)
	        {
            int[] c = new int[(int)char.MaxValue];

            Console.Write("Option\n");
            Console.Write("1) Take replace rule\n");
            Console.Write("2) Exit:\n");
            Console.Write("Please Enter Fıle Path:");

            string fdpath = Console.ReadLine();
            string text = File.ReadAllText(fdpath);

            frequency_letter(fdpath);

            foreach (char t in fdpath)
            {
                // Increment table.
                c[(int)t]++;
            }

            _ = Console.ReadLine();

            // Read all the content in one string and display the string 
            //string text = File.ReadAllText(fdpath);

            //Read the ShiftCount value. Starting with 0 value and take 1st one.
            string ShiftCount = text.Substring(0, 1);
  	            // Read the EncDec value.That means read the selectipn of Encrypt or Decrypt.Starting with 2nd value and take 1st one.
	            string EncDec = text.Substring(2, 1);
   	            // Read the Alphabet choice.Starting with 4th value and take 1st one.
	            string Alphabet = text.Substring(4, 1);
  	
	
	            text = text.Substring(6);
   	
	
	            //Encryption and Decryption algorithm
	
	            string xText = "";
    	
	            //Logic of Encryption
	            if (EncDec == "0")
        	            {
        	                xText = LanguageCipher(text, Convert.ToInt32(ShiftCount) * -1, Convert.ToInt32(Alphabet));
        	            }
    	            else
        	
	            //Logic of Decryption
	                 if (EncDec == "1")
        	            {
        	                xText = LanguageCipher(text, Convert.ToInt32(ShiftCount), Convert.ToInt32(Alphabet));
        	            }
    	
	
	            Console.WriteLine(xText);
    	
	        }
	    }
	}

