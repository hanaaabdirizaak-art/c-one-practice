### 2. Assigning Variables

The values entered by the user in the TextBoxes are assigned to the corresponding variables.

```csharp
DayoftheWeek = dayOfWeekTextBox.Text;

Month = monthTextBox.Text;

Day = dayOfMonthTextBox.Text;

Year = yearTextBox.Text;
```

![Assigning Variables](assigment.1/week1/SCREANSHORTS/display out put.png)
 
 ### 1. Creating Variables

The following string variables are created to store the date information entered by the user.

```csharp
string DayoftheWeek, Month, Day, Year, FullDate;
```

![Creating Variables](assigment.1/week1/SCREANSHORTS/create variable.png)


### 3. Concatenation

The `+` operator is used to combine the values of the date variables into one complete date string.

```csharp
FullDate = DayoftheWeek + ", " + Month + " " + Day + ", " + Year;
```

![Concatenation](assigment.1/week1/SCREANSHORTS/concetination.jpeg)

### 4. Displaying the Result

The `FullDate` variable is assigned to the `Text` property of the `dateOutputLabel`. This displays the formatted date on the form.

```csharp
dateOutputLabel.Text = FullDate;
```

The `dateOutputLabel` is a Label control on `Form1` used to display the final date.

![Displaying Result](assigment.1/week1/SCREANSHORTS/display out put.png)



