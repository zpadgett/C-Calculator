using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//BUS 442 Project 2: Calculator App
//4/14/2020
//Developers: Ray Jones, Zach Padgett


namespace Project2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        //Global Arrays
        string[] numbersStr = new string[30];
        int[] numbersInt = new int[30];

        //2d Array
        int[,] numbers2d = new int[6, 5];

        private void button31_Click(object sender, EventArgs e)
        {
            //Coded: Ray Jones
            //Reviewed: Zach Padgett

            //Exit app with confirmation message

            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Coded: Ray Jones
            //Reviewed: Zach Padgett

            //Clear items in listbox
            resultsListBox.Items.Clear();
         }


        private void numericButton_Click(object sender, EventArgs e)
        {
            //Coded: Zach Padgett
            //Reviewed: Ray Jones

            Button button = (Button)sender;

            if (button.Text == "CE") 
            {
                xTextBox.Text = null;
                yTextBox.Text = null;
            } else if (button.Text == "C") 
            {
                if (yCheckBox.Checked == true) 
                {
                    yTextBox.Text = null;
                } else 
                {
                    xTextBox.Text = null;
                }
            } else if (yCheckBox.Checked == true) 
            {
                yTextBox.Text += button.Text;
            } else 
            {
                xTextBox.Text += button.Text;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Coded: Zach Padgett
            //Reviewed: Ray Jones

            Button button = (Button)sender;
            Double resultVal;
            int integerX, integerY;
            float floatX, floatY;

            switch (button.Name)
            {
                case "addButton":
                    //Coded: Zach Padgett
                    //Reviewed: Ray Jones

                    resultVal = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : float.Parse(xTextBox.Text)) + (string.IsNullOrEmpty(yTextBox.Text) ? 0 : float.Parse(yTextBox.Text));
                    resultsListBox.Items.Add("x+y = " + resultVal);
                    break;
                case "subtractButton":
                    //Coded: Zach Padgett
                    //Reviewed: Ray Jones

                    resultVal = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : float.Parse(xTextBox.Text)) - (string.IsNullOrEmpty(yTextBox.Text) ? 0 : float.Parse(yTextBox.Text));
                    resultsListBox.Items.Add("x-y = " + resultVal);
                    break;
                case "divideButton":
                    //Coded: Zach Padgett
                    //Reviewed: Ray Jones

                    resultVal = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : float.Parse(xTextBox.Text)) / (string.IsNullOrEmpty(yTextBox.Text) ? 0 : float.Parse(yTextBox.Text));
                    resultsListBox.Items.Add("x/y = " + resultVal);
                    break;
                case "reciprocalButton":
                    //Coded: Zach Padgett
                    //Reviewed: Ray Jones

                    integerX = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : int.Parse(xTextBox.Text));
                    if (integerX == 0)
                    {
                        resultsListBox.Items.Add("Cannot divide by 0");
                    }
                    else
                    {
                        resultVal = 1 / integerX;
                        resultsListBox.Items.Add("1/x = " + resultVal);
                    }
                    break;
                case "expButton":
                    //Coded: Ray Jones
                    //Reviewed: Zach Padgett

                    floatX = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : float.Parse(xTextBox.Text));
                    floatY = (string.IsNullOrEmpty(yTextBox.Text) ? 0 : float.Parse(yTextBox.Text));
                    resultVal = Math.Pow(floatX, floatY);
                    resultsListBox.Items.Add(floatX + " raised to the power of " + floatY + ": " + resultVal);
                    break;
                case "factButton":
                    //Coded: Ray Jones
                    //Reviewed: Zach Padgett

                    integerX = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : int.Parse(xTextBox.Text));
                    yTextBox.Text = null;
                    int number, fact;
                    number = integerX;
                    fact = number;
                    //Check for errors
                    if (integerX > 10) 
                    {
                        resultsListBox.Items.Add("Error, X cannot be greater than 10");
                    } else if (integerX < 0) 
                    {
                        resultsListBox.Items.Add("Error, X cannot be less than 0");
                    } else 
                    {
                        for (int i = number - 1; i >= 1; i--) 
                        {
                            fact = fact * i;
                        }
                        resultsListBox.Items.Add(integerX + "! " + ": " + fact);
                    }
                        break;
                case "multiplyTableButton":
                    //Coded: Ray Jones
                    //Reviewed: Zach Padgett

                    integerX = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : int.Parse(xTextBox.Text));

                    for (int i = 1; i <= 12; i++) 
                    {
                        var results = i * integerX;
                        resultsListBox.Items.Add(i + "*" + integerX + "=" + results);
                    }
                    break;
                case "stdevButton":
                    //Coded: Zach Padgett
                    //Reviewed: Ray Jones

                    int xRawVal = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : int.Parse(xTextBox.Text));
                    int yRawVal = (string.IsNullOrEmpty(yTextBox.Text) ? 0 : int.Parse(yTextBox.Text));

                    int xVal = 0;
                    int yVal = 0;

                    //Ensures x is always > y for calculation
                    if (xRawVal < yRawVal) 
                    {
                        xVal = xRawVal;
                        yVal = yRawVal;
                    } else 
                    {
                        xVal = yRawVal;
                        yVal = xRawVal;
                    }

                    int[] stdevList = new int[999];
                    int index = 0;

                    //Map all values in between x and y to array (can add a resize to grow dynamically)
                    for (int i = xVal; i <= yVal; i++) 
                    {
                        stdevList[index] = i;
                        index += 1;
                    }

                    //Resize array to ensure .Length is correct for calculation
                    Array.Resize(ref stdevList, index);

                    //find StdDev
                    double avg = stdevList.Average();
                    double sumSqrDiff = stdevList.Select(val => (val - avg) * (val - avg)).Sum();
                    double sd = Math.Sqrt(sumSqrDiff / stdevList.Length);

                    resultsListBox.Items.Add("Standard Deviation for range " + stdevList[0] + " to " + stdevList[index-1] + ": " + sd);
                    break;
                case "primeButton":
                    //Coded: Ray Jones
                    //Reviewed: Zach Padgett

                    integerX = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : int.Parse(xTextBox.Text));
                    integerY = (string.IsNullOrEmpty(yTextBox.Text) ? 0 : int.Parse(yTextBox.Text));
                    //Check for errors
                    if (integerX > integerY)
                    {
                        resultsListBox.Items.Add("Error, X cannot be greater Y");
                    }
                    else if (integerX < 0)
                    {
                        resultsListBox.Items.Add("Error, X cannot be less than 0");
                    }
                    else if (integerY > 500)
                    {
                        resultsListBox.Items.Add("Error, Y cannot be greater than 500");
                    }
                    else
                    {
                        for (int i = integerX; i <= integerY; i++)
                        {
                            bool isPrime = true;
                            for (long j = 2; j < i; j++)
                            {
                                if (i % j == 0)
                                {
                                    isPrime = false;
                                    resultsListBox.Items.Add(i + (" is not prime"));
                                    break;
                                }
                            }
                            if (isPrime)
                            {
                                resultsListBox.Items.Add(i + (" is prime"));
                            }
                        }
                    }
                    break;
                case "sumOfSquareButton":
                    //Coded: Zach Padgett
                    //Reviewed: Ray Jones

                    xRawVal = (string.IsNullOrEmpty(xTextBox.Text) ? 0 : int.Parse(xTextBox.Text));
                    yRawVal = (string.IsNullOrEmpty(yTextBox.Text) ? 0 : int.Parse(yTextBox.Text));

                    int sumXY = 0;
                    int sumSqr = 0;

                    int[] sumSqrList = new int[1];
                    index = 0;
                    
                    //Check for errors
                    if (xRawVal == 0 && yRawVal == 0) {
                        resultsListBox.Items.Add("Error, both X and Y cannot be 0");
                    } else if (xRawVal > yRawVal) {
                        resultsListBox.Items.Add("Error, X cannot be greater than Y");
                    } else { 
                        //Map all values in between x and y to array, can add a resize to grow dynamically so that array size is not set to a value (eg. 999)
                        for (int i = xRawVal; i <= yRawVal; i++)
                        {
                            //Add row to array 
                            Array.Resize(ref sumSqrList, index + 1);

                            sumSqrList[index] = i;

                            int iSquare = i * i;

                            resultsListBox.Items.Add("The number is: " + i + " and its square is: " + iSquare);

                            sumXY += i;
                            sumSqr += iSquare;
                            index += 1;
                        }
                        resultsListBox.Items.Add("The number is: " + sumXY + " and its square is: " + sumSqr);
                    }
                        break;
                        default:
                    resultsListBox.Items.Add("failed");
                        break;
            }
        }


        private void displayButton_Click(object sender, EventArgs e)
        {
            //Coded: Zach Padgett
            //Reviewed: Ray Jones

            string currentLine;

            StreamReader NumberReader = new StreamReader("..\\..\\..\\Numbers.txt");

            resultsListBox.Items.Clear();
            while(NumberReader.EndOfStream == false)
            {
                currentLine = NumberReader.ReadLine();
                resultsListBox.Items.Add(currentLine);

            }
            NumberReader.Close();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            //Coded: Zach Padgett
            //Reviewed: Ray Jones

            Button button = (Button)sender;

            string currentLine;
            int maxValue, minValue, rangeVal, index = 0;
            float avgVal, sumf = 0;
            int sum = 0;

            StreamReader NumberReader = new StreamReader("..\\..\\..\\Numbers.txt");
            resultsListBox.Items.Clear();

            while (NumberReader.EndOfStream == false)
            {
                currentLine = NumberReader.ReadLine();
                //split by comma
                numbersStr = currentLine.Split(',');

                numbersInt[index] = int.Parse(numbersStr[0]);
                index += 1;
                numbersInt[index] = int.Parse(numbersStr[1]);
                index += 1;
                numbersInt[index] = int.Parse(numbersStr[2]);
                index += 1;
                numbersInt[index] = int.Parse(numbersStr[3]);
                index += 1;
                numbersInt[index] = int.Parse(numbersStr[4]);
                index += 1;
            }
            NumberReader.Close();

            switch (button.Name)
            {
                case "maxFileButton":
                    maxValue = numbersInt.Max();
                    resultsListBox.Items.Add("Max file number is: " + maxValue);
                    break;
                case "sumOfFileButton":
                    foreach (int num in numbersInt) 
                    {
                        sum += num;
                    }
                    resultsListBox.Items.Add("Sum of file numbers is: " + sum);
                    break;
                case "rangeFileButton":
                    maxValue = numbersInt.Max();
                    minValue = numbersInt.Min();
                    rangeVal = maxValue - minValue;
                    resultsListBox.Items.Add("Range of file values: " + rangeVal);
                    break;
                case "averageFileButton":
                    float i = 0;
                    foreach (float num in numbersInt)
                    {
                        sumf += num;
                        i++;
                    }
                    avgVal = sumf / i;

                    resultsListBox.Items.Add("Average of values: " + avgVal);
                    break;
                case "arrayButton":
                    int row = 0;
                    StreamReader NumberReader2d = new StreamReader("..\\..\\..\\Numbers.txt");
                    while (NumberReader2d.EndOfStream == false)
                    {
                        currentLine = NumberReader2d.ReadLine();

                        //split by comma
                        numbersStr = currentLine.Split(',');

                        numbers2d[row, 0] = int.Parse(numbersStr[0]);
                        numbers2d[row, 1] = int.Parse(numbersStr[1]);
                        numbers2d[row, 2] = int.Parse(numbersStr[2]);
                        numbers2d[row, 3] = int.Parse(numbersStr[3]);
                        numbers2d[row, 4] = int.Parse(numbersStr[4]);

                        row += 1;
                    }
                    NumberReader.Close();

                    int xVal = string.IsNullOrEmpty(xTextBox.Text) ? 0 : int.Parse(xTextBox.Text); 
                    int yVal = string.IsNullOrEmpty(yTextBox.Text) ? 0 : int.Parse(yTextBox.Text);

                    if (xVal > 5)
                    {
                        resultsListBox.Items.Add("Error, X Location is outside of Array");
                    }
                    else if (yVal > 4)
                    {
                        resultsListBox.Items.Add("Error, Y Location is outside of Array");
                    }
                    else
                    {
                        var result2d = numbers2d[xVal, yVal];
                        resultsListBox.Items.Add("Value is: " + result2d);
                    }
                    break;
                default:
                    resultsListBox.Items.Add("failed");
                    break;

            }
            }
    }
}
