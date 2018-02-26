# _Repeat Counter App_

#### _.NET MVC Unit Testing Exercise, 02/25/2018_

#### By _**Tyler Kostelak**_

## Description

This application asks the user for a word and a sentence, and then returns the amount of times that the inputted word appears in the inputted sentence.

## Specifications/BDD

First, make sure it does not track the amount of instances  for numbers,
since the app is only meant for words.
For example, word input “12!” should return the message, “Please enter a word.”

Next, make sure it can recognize when the user inputs the word and the same word as the sentence.
For example, the word input is “dog”, and the sentence input is “dog”. The app should return 1.

Once that’s working, make sure that formatting does not affect the output results.
For example, word input is “dog”, and sentence input is “The Dog barked.” The app should return 1.

Then, work on being able to count instances of the word in a sentence.
For example, word input “dog” and sentence input “The dogs barked” should return 1.

When you have that, move onto counting multiple instances of the word.
For example, word input “dog” and sentence input “The dog barked at the other dogs” should return 2.


## Setup/Installation Requirements

* Installation Requirements:

.NET CORE 1.1 SDK
.NET RUNTIME
MONO
Setup:

* Clone this repository to your desktop.
* Navigate to this folder in your command prompt.
* Run dotnet restore, dotnet build, and then dotnet run commands.
* Navigate to localhost:5000 in your preferred web browser.

## Known Bugs

No known bugs at this time.

## Support and contact details

If you have suggestions for how to help me make any additions, or if you have other feedback, please feel free to contact me at tkostelak@gmail.com. All feedback is welcome, keep in mind that the primary focus of this project is C#/.NET, so I am not necessarily looking for HTML/CSS advice.

## Technologies Used

* C#/.NET MVC
* HTML
* CSS


### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **Tyler Kostelak**
