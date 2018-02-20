BDD WORD COUNTER

First, make sure it does not track the amount of instances  for numbers or symbols,
since the app is only meant for words.
For example, word input “12!” should return the message, “Please enter a word.”

Next, make sure it can recognize when the user inputs the word and the same word as the sentence.
For example, the word input is “dog”, and the sentence input is “dog”. The app should return 1.

Once that’s working, make sure that formatting does not affect the output results.
For example, word input is “dog”, and sentence input is “The Dog barked.” The app should return 1.

Then, work on being able to count plural instances of the word.
For example, word input “dog” and sentence input “The dogs barked” should return 1.

When you have that, move onto counting multiple instances of the word.
For example, word input “dog” and sentence input “The dog barked at the other dogs” should return 2.
