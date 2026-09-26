Chapter 2: Processing Data

Overview

This chapter explains how to process data in C# Windows Forms using TextBox controls, variables, numeric data types, calculations, exception handling, constants, fields, the Math class, GUI features, and debugging.

Topics

2.1 Reading Input with TextBox Controls

- A TextBox accepts keyboard input.
- It is found in the Common Controls section of the Toolbox.
- Default names are "textBox1", "textBox2", etc.
- The "Text" property stores user input.
![Show Information](Screenshots/formating number.png)

textBox1.Text = "Hello";
textBox1.Clear();

2.2 Variables

- A variable is a storage location in memory.
- Syntax:

DataType VariableName;

- A variable must have a suitable data type.
- Variable names should be meaningful, contain no spaces, start with a letter or "_", and must not be reserved keywords.
- String variables store characters such as names and phone numbers.
- The "+" operator performs string concatenation.
- Local variables belong to the method where they are declared.
- Scope is where a variable can be accessed.
- Lifetime is how long the variable exists in memory.
- Variables cannot have duplicate names within the same scope.
- Variables must be initialized before use.
- Multiple variables of the same type can be declared together.
![Show Information](Screenshots/first look variable. png.png. )
2.3 Numeric Data T
![Show Information](Screenshots/variable.png.png)
Common numeric types:

- "int" – whole numbers
- "double" – numbers with fractional values
- "decimal" – high-precision numbers, commonly used for financial values

Numeric literals:
![Show Information](Screensh/formating.png)
int hoursWorked = 40;
double temperature = 87.6;
decimal payRate = 28.75m;

- "int" cannot store "double" or "decimal" values.
- "double" can store "int" and "double", but not "decimal".
- "decimal" can store "int" and "decimal", but not "double".
- Casting converts one numeric type to another:

int wholeNumber = (int)moneyNumber;

- "var" allows the compiler to determine the type automatically:

var interestRate = 12.0;
var stockCode = "D465U";

- "var" must be initialized and is used for local variables.

2.4 Performing Calculations

Arithmetic operators:

- "+" Addition
- "-" Subtraction
- "*" Multiplication
- "/" Division
- "%" Modulus/remainder

Example:

int x = 5, y = 4;
MessageBox.Show((x + y).ToString());

- Follow the order of operations.
- Use parentheses when necessary.
- Mixed numeric types follow compatibility rules.
- Integer division produces an integer result:

7 / 3

To get a decimal result, use "double" or casting.

2.5 Inputting and Outputting Numeric Values

TextBox input is always treated as a string, even when the user enters a number.

Use "Parse" methods to convert strings:

int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
decimal price = decimal.Parse(priceTextBox.Text);

To display numeric values in a Label or TextBox, convert them to strings:
![Show Information](Screenshots/local.png)
grossPayLabel.Text = grossPay.ToString();

2.6 Formatting Numbers with ToString()

"ToString()" can format numbers.

Format| Meaning
"N"| Number
"F"| Fixed-point
"E"| Exponential
"C"| Currency
"P"| Percentage

Example:

number.ToString("C");
number.ToString("P");

2.7 Simple Exception Handling

An exception is a runtime error, such as:

- Dividing by zero
- Opening a file that does not exist
- Invalid user input

Exception handling prevents the program from stopping unexpectedly.

Use "try-catch":

try
{
    // statements that may cause an error
}
catch
{
    // handle the error
}

- "try" contains code that may cause an exception.
- "catch" handles the exception.
- Throwing means an error/problem occurs.
- Catching means the program handles the error.

An exception's message can be displayed using:

catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}

2.8 Named Constants

A named constant represents a value that cannot change during program execution.

const double INTEREST_RATE = 0.129;

Constants are traditionally written using uppercase letters.

2.9 Variables as Fields

A field is a variable declared at class level, outside methods.

- Its scope is the entire class.
- It is created when the form is created.

Example:

private string name = "Charles";

2.10 Math Class

The ".NET Math" class provides mathematical methods:

Math.Sqrt(x)   // Square root
Math.Pow(x,y)  // Power
Math.Max(x,y)  // Larger value
Math.Min(x,y)  // Smaller value
Math.Round(x)  // Rounds a number

Constants:

Math.PI
Math.E

2.11 GUI Details

Tab Order

- Focus means a control receives keyboard input.
- The Tab Order determines the order controls receive focus.
- "TabIndex" specifies a control's position.
- The first control has index "0".
- Labels cannot receive keyboard focus.
- Focus can be changed using:

ControlName.Focus();

Access Keys

An access key uses "Alt" plus a letter.

Example:

&Save

The user can press Alt + S.

Colors

- "BackColor" sets background color.
- "ForeColor" sets text color.

Example:

messageLabel.BackColor = Color.Black;
messageLabel.ForeColor = Color.Yellow;

Background Images
![Show Information](Screenshots/example.png)

Forms support:

- "BackgroundImage"
- "BackgroundImageLayout"

Layout options include:

- None
- Tile
- Center
- Stretch
- Zoom

GroupBox vs Panel

- GroupBox is a container with a border and optional title.
- Panel is also a container.
- GroupBox has a "Text" property; Panel does not.
- Panel supports "BorderStyle".

2.12 Debugging Logic Errors

A logic error allows a program to run but produces incorrect results.

Examples:

- Mathematical mistakes
- Assigning a value to the wrong variable
- Assigning the wrong value

Visual Studio provides debugging tools.

Breakpoints

A breakpoint pauses program execution at a selected line so you can inspect variables and control properties.

Break Mode

In Break mode, you can examine variable values by placing the mouse over them.
![Show Information](Screenshots/local.png)
Locals Window

Shows:

- Variable names
- Current values
- Data types

Watch Window

Allows you to select variables that you want to monitor.

Single-Stepping

Runs the program one statement at a time.

You can use:

- F11
- Step Into
- Debug → Step Into

Key Summary

This chapter teaches how to:

1. Read user input with TextBoxes.
2. Declare and use variables.
3. Work with strings and numeric data types.
4. Perform arithmetic calculations.
5. Convert input using "Parse".
6. Convert and format values using "ToString()".
7. Handle runtime errors with "try-catch".
8. Use constants and class-level fields.
9. Perform calculations with the "Math" class.
10. Control GUI focus, colors, images, and containers.
11. Find and fix logic errors using Visual Studio debugging tools.