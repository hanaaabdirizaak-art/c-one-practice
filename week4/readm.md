# Chapter 4: Loops, Files, and Random Numbers – C#

## Topics
1. The while Loop
2. Increment and Decrement Operators
3. The for Loop
4. The do-while Loop
5. Using Files for Data Storage
6. OpenFileDialog and SaveFileDialog
7. Random Numbers
8. The Load Event

## 1. The while Loop
The while loop repeats statements as long as a Boolean expression is true.

- It is a pretest loop.
- It checks the condition before execution.
- The loop body contains the repeated statements.
- A counter variable tracks the number of iterations.
- An infinite loop continues until the program is interrupted.

## 2. Increment and Decrement Operators
Increment increases a variable's value by one.
Decrement decreases a variable's value by one.

- ++ means increment.
- -- means decrement.
- Postfix uses the old value before changing it.
- Prefix changes the value before using it.

## 3. The for Loop
The for loop is designed for situations requiring a counter to control the number of iterations.

It has three expressions:
- Initialization: Sets the initial counter value.
- Test: Checks the Boolean condition.
- Update: Increases or decreases the counter.

The for loop is a pretest loop.

## 4. The do-while Loop
The do-while loop repeats statements while a Boolean expression is true.

- It is a posttest loop.
- It executes statements before checking the condition.
- It always executes at least once.

## 5. Using Files for Data Storage
Files allow programs to save data for later use.

There are three main steps:
- Open the file.
- Process the file.
- Close the file.

Types of files:
- Text File: Contains data encoded as text.
- Binary File: Contains data that is not converted to text.

File classes:
- StreamWriter: Writes data to a text file.
- StreamReader: Reads data from a text file.

## 6. OpenFileDialog and SaveFileDialog
These controls allow applications to display standard Windows dialog boxes.

- OpenFileDialog: Opens a file selection dialog.
- SaveFileDialog: Opens a Save As dialog.
- ShowDialog(): Displays the dialog.
- DialogResult.OK: The user selects OK.
- DialogResult.Cancel: The user cancels.
- FileName: Stores the selected file path and name.
- InitialDirectory: Specifies the initial directory.

## 7. Random Numbers
The Random class generates random numbers.

Common methods:
- Next(): Generates a random integer.
- NextDouble(): Generates a floating-point number between 0.0 and 1.0.

## 8. The Load Event
The Load event occurs when a form is loaded into memory.

- It runs when the application form launches.
- It can be created by double-clicking the form in Designer.
- Code inside the Load event executes when the form starts.