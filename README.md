# Sentence-word-and-character-tosser
It is a window application that is used to edit text. When you type some text in the left text box, you have several editing options.
The buttons in the middle are used to use them. The edited text will be displayed in the right List Box. So what are these options?
##Load last
Allows you to load the last saved texts from a CSV file in appdata. If the file is empty, nothing is logically loaded.
##Browse sentences
The core functions of the program. If you are interested in more, take a look at the source code. 
Otherwise, in principle, the idea is to store numbers from 0 to a number one less than the length of the collection with input text from the user.
The generator from the Random class will then generate the number. I then insert the element from the input collection with this index into the output collection.
This is then displayed to the user.
##Browse the words
The function uses the same method as the previous command, but the input parameters are modified.
##Browse sentences and words
A little more interesting feature. It allows you to shuffle both sentences and words in one input. The result is displayed to the user.
##Replace characters
The function replaces a defined character with another defined character. If you do not specify a character to replace, the program will throw an error message.
##Save to file
Allows the user to insert user input and program output into a CSV file. You can then read the data from it with the first command.
