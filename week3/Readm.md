Chapter 3: Making Decisions – C#
1. Decision Structures and the if Statement
A control structure controls the order in which statements execute in a program.
- Sequence Structure: Executes statements in order.
- Decision Structure: Executes statements depending on a condition.
- Selection Structure: Another name for a decision structure.
The if statement executes statements when a Boolean expression is true.

Relational Operators:
- > Greater than
- < Less than
- >= Greater than or equal to
- <= Less than or equal to
- == Equal to
- != Not equal to
2. The if-else Statement
The if-else statement executes one block when the condition is true and another block when the condition is false.

It has two parts:
- If clause
- Else clause
3. Nested Decision Structures
A nested decision structure is a decision placed inside another decision. It is used to test more than one condition.

if-else-if Statement

Evaluates multiple conditions to make a final decision. If none of the conditions is true, the else section executes.
4. Logical Operators
Logical operators connect or reverse Boolean expressions.
- AND (&&): Both conditions must be true.
- OR (||): One or both conditions must be true.
- NOT (!): Reverses the Boolean value.
5. bool Variables and Flags
A bool variable stores two values: true or false.

A flag is a variable that signals whether a particular condition exists.
- False: The condition does not exist.
- True: The condition exists.
6. Comparing Strings
Strings can be compared using relational operators and methods.
- == Compares two strings.
- != Checks whether two strings are different.
- String.Compare Compares two strings.
7. Preventing Data Conversion Exceptions with TryParse
TryParse methods help prevent exceptions when users enter invalid data.

Common methods:
- int.TryParse
- double.TryParse
- decimal.TryParse
The out keyword specifies the output variable that receives the converted value.
8. Input Validation
Input validation checks data entered into a program to make sure it is valid before it is used.

TryParse checks whether input can be converted into a data type, but it does not check whether the value is reasonable.

Examples:
- Working hours must be greater than 0 and less than or equal to 168.
- Test scores must be between 0 and 100.
9. Radio Buttons and Check Boxes
Radio Buttons

Radio buttons allow users to select one choice from several possible choices.

Selecting one automatically deselects the others. This is called mutually exclusive selection.

Properties:
- Text: Displays text next to the radio button.
- Checked: Determines whether it is selected.
Check Boxes

Check boxes allow users to select multiple options.

Properties:
- Text: Displays text next to the check box.
- Checked: Determines whether it is selected.
CheckedChanged Event

This event occurs whenever the Checked property of a radio button or check box changes.
10. The switch Statement
The switch statement allows the value of a variable or expression to determine which path the program follows.

It is a multiple-alternative decision structure.
- Case: Represents a possible value.
- Break: Ends the case.
- Default: Executes when no case matches. It is optional.
11. Introduction to List Boxes
A ListBox control displays a list of items and allows the user to select an item.

Common ListBox Properties:
- Text: Contains the text of the selected item.
- Items: Contains all items in the ListBox.
- Items.Count: Gives the total number of items.
- SelectedItem: Gets or sets the selected item.
- SelectedIndex: Gets or sets the zero-based index.
Adding Items
The Items.Add method adds new items to a ListBox.

SelectedItem and SelectedIndex
- The first item has index 0.
- The second item has index 1.
- The nth item has index n - 1.
- If no item is selected, SelectedIndex is -1.
Accessing SelectedItem when no item is selected can cause an exception.

Difference Between Text and SelectedItem
- Text is a string and is useful when only the displayed text is needed.
- SelectedItem is an object and is more flexible.
- Text may return an empty string.
- SelectedItem may return null.
Removing Items
- Items.Remove: Removes a specific item.
- Items.RemoveAt: Removes an item using its index.
- Items.Clear: Removes all items from the ListBox.