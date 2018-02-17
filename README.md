*Word Counter specs*

**1. The user enters a word and a string, and both are turned into a separate list.**

  Input:
	Word: banana
	String: “Go eat a banana.”
	Output:
	{“Banana”}, {”go”,”eat”,”a”,”banana”}

	Having the word and string as a list containing strings will make it easier to
	Compare the results, and is a crucial behavior for the app.



**2. When a user inputs a word and a string, the app returns the amount of times the word occurs.**

    Input:
  	Word: Bagel
  	String: “I ate a bagel for breakfast this morning.”
  	Output:
  	1

    This is the simplest behavior of the spec. When a user enters a word  
    and  a sentence containing the word at least once, the app will return the
    amount of times that the user entered the word.

 **3. The user does not enter anything, the app returns “please enter a word.”**

    Input:
  	Word: “”
  	String: “”
  	Output:
  	Please enter a word..

  	This spec is important, because without accounting for this, the output would
  	Be 1.

  **4. The user enters symbols in the word form, the app returns “please enter a word.”**

      Input:
    	Word: @%^*
    	String:  “@%^*
    	Output:
    	“Please enter a word.”

    	To account for entries that are obviously not words, this spec ensures that output
    	Will not be 1.

   **5. The user enters a word and a string that contains a word that has a fragment of
	The word in the input form.**

      Input:
    	Word: Go
    	String: “Got milk?”
    	OutPut: 0

    	Even though go is in the string the user input, it does not exist as an  individual word..

    **6. The user enters a plural version of the word, and the app outputs the plural     
	Instance as one time.**

      Input:
  		Word: banana
  		String: “Don’t go bananas!”
  		Output: 1

  	  Unlike not counting when the word being searched for is the root of another
  	  Word, the plural version is still an instance of the word and should be counted.
