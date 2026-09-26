Chapter 1 – Introduction to Visual C#

Overview

This chapter introduces the basic concepts of Visual C#, objects, controls, Visual Studio, Windows Forms, C# code, events, and syntax errors.

Topics Covered

1. Objects
2. Getting Started with Visual Studio
3. Forms and Controls
4. Creating the GUI for a Visual C# Application
5. Introduction to C# Code
6. Writing Code for the Hello World Application
7. Label Controls
8. IntelliSense
9. PictureBox Controls
10. Comments, Blank Lines, and Indentation
11. Closing an Application's Form
12. Dealing with Syntax Errors

1. Objects

An object is a program component that contains data and performs operation
![Show Information](Screenshots/object.png)

- Properties: Data stored in an object.
- Methods: Operations an object can perform.
- Controls: Visible objects in a GUI, such as Labels, Buttons, and TextBoxes.
- Some GUI objects are invisible, such as Timers and OpenFileDialog.
- A class is code that describes a particular type of object.

2. .NET Framework

.NET is a collection of classes and other code that can be used to create programs for Windows.

Controls are defined by specialized classes provided by .NET. You can also create your own classes to perform special tasks.

3. Getting Started with Visual Studio

Visual Studio is a professional Integrated Development Environment (IDE).

Important parts of Visual Studio include:

- Designer Window
- Solution Explorer Window
- Properties Window
- Toolbox
- Menu Bar
- Standard Toolbar

Toolbox

The Toolbox is a window used for selecting controls to use in an application.

Common controls include:

- Button
- CheckBox
- ComboBox
- Label
- ListBox
- ListView
- MaskedTextBox
- MonthCalendar

Tooltip

A Tooltip is a small box that appears when you move the mouse pointer over an item on the toolbar or toolbox.

Docked and Floating Windows

- A docked window is attached to an edge of the Visual Studio environment.
- A floating window can be moved around the screen.
- A window can be changed between Dock and Float.

4. Projects and Solutions

A Solution is an entire container that can hold one or more projects.

A Project is one application inside the solution.

Project files are the actual code and resources that make the application run.

Typical files include:

- "Program.cs" – contains the application's startup code.
- "Form1.cs" – contains code associated with the Form1 form.

If the form is not automatically displayed, right-click "Form1.cs" in Solution Explorer and select View Designer.
![Show Information](Screenshots/display.png)
5. Forms and Controls

When you start a new Windows Forms App, an empty form named "Form1" is automatically created.

The form has a bounding box with sizing handles that can be used to resize the form.

Properties Window

The Properties Window determines how a GUI object looks and behaves.

Each property has two columns:

- Property name
- Property value

The Text property determines the text displayed in the form's title bar.
Adding Controls

You can add a control by:

- Double-clicking the control in the Toolbox.
- Dragging the control from the Toolbox to the form.

You can also resize, move, change, or delete controls.

6. Rules for Naming Controls

Controls are identified by their names in code. Control names are also called identifiers.

Rules:

- The first character must be a letter or underscore "_".
- Other characters can be letters, numbers, or underscores.
- The name cannot contain spaces.

Examples:

showDayButton
DisplayTotal
_ScoreLabel

C# programmers commonly use the camelCase naming convention.

7. Creating the GUI

A simple Visual C# application can contain a Form and a Button.

When the Button is clicked, the application can display:

Hello World

8. Introduction to C# Code

C# code is primarily organized in three ways:

- Namespace: A container that holds classes.
- Class: A container that holds methods.
- Method: A group of programming statements that perform operations.

A file that contains program code is called a source code file.

9. Events and Event Handlers

GUI applications are event-driven. This means that the program waits for the user to do something and then responds.

Examples of events include:

- Mouse clicking
- Key pressing
- Moving the mouse

An event handler is a method that executes when a specific event takes place.

For example, double-clicking a Button in the Designer can create a default event handler.

MessageBox

A MessageBox displays a message.

Example:

private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}
![Show Information](Screenshots/.png)
10. Hello World Application

A Button event handler can display the message "Hello World".

private void messageButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}

11. Label Controls

A Label control displays text on a form. It can display unchanging text or program output.

Common Label properties include:

- Text: Gets or sets the text associated with the Label.
- Name: Gets or sets the name of the Label.
- Font: Sets the font, font style, and font size.
- BorderStyle: Displays a border around the text.
- AutoSize: Controls how the control can be resized.
- TextAlign: Sets the text alignment.

TextAlign Values

- TopLeft
- TopCenter
- TopRight
- MiddleLeft
- MiddleCenter
- MiddleRight
- BottomLeft
- BottomCenter
- BottomRight

Example:

answerLabel.Text = "";

This clears the text of the Label.

12. IntelliSense

IntelliSense provides automatic code completion while writing programming statements.

It can suggest:

- Keywords
- Variables
- Methods
- Classes
- Properties

IntelliSense makes language references easier to find and insert into code.

13. PictureBox Controls

A PictureBox control displays a graphic image on a form.

Common properties include:

- Image: Specifies the image to display.
- SizeMode: Specifies how the image is displayed.
- Visible: Determines whether the control is visible at run time.

A PictureBox can also have a Click event handler.

14. Sequential Execution of Statements

Program statements execute in the order in which they appear.

Example:

private void showBackButton_Click(object sender, EventArgs e)
{
    cardBackPictureBox.Visible = true;
    cardFacePictureBox.Visible = false;
}

The sequence of statements is important because an incorrect sequence can cause logic errors.

15. Comments, Blank Lines, and Indentation

Comments are brief notes placed in source code to explain how parts of a program work.

Single-Line Comment

// Make image of the card back visible.

Block Comment

/*
   Line one
   Line two
*/
![Show Information](Screenshots/commends.png)
Blank lines and indentation make code easier to read and understand.

16. Closing an Application

To close the current form:

this.Close();

To close the whole application:

Application.Exit();

17. Syntax Errors

The Visual Studio code editor examines each statement as you type it and reports syntax errors.

When a syntax error is found, it is normally shown with a red jagged underline.

If a syntax error exists and you try to compile and execute the program, Visual Studio displays an error.
![Show Information](Screenshots/dealing.png)
Quick Revision

- Object: A program component that contains data and performs operations.
- Property: Data or a setting stored in an object.
- Method: An operation an object can perform.
- Control: A visible GUI object such as a Button, Label, or TextBox.
- Class: Code that describes a particular type of object.
- IDE: Integrated Development Environment.
- Solution: A container that can hold one or more projects.
- Project: One application inside a solution.
- Event: An action such as clicking a button or pressing a key.
- Event Handler: A method that responds to an event.
- IntelliSense: Automatic code completion.
- PictureBox: A control used to display an image.
- Syntax Error: An error in the syntax or rules of the code.

Source

Based on:

Starting Out with Visual C#, Sixth Edition – Chapter 1: Introduction to Visual C#

