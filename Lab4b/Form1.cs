namespace Lab4b
{
    
    public partial class Form1 : Form
    {
        private double firstArgument = 0;
        private double secondArgument = 0;
        private string lastOperation = "";
        private string[] standardOperations = ["+","-","*","/"];
        public double memory;


        public Form1()
        {
            InitializeComponent();
        }

        private void NumButtonClicked(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                inputTextBox.Text += clickedButton.Text;
            }
        }

        private void OperationButtonClicked(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && inputTextBox.Text != "")
            {
                double result = 0;
                string currentOperation = clickedButton.Text;
                if (standardOperations.Contains(currentOperation))
                {
                    firstArgument = double.Parse(inputTextBox.Text);

                    operationTextBox.Text = $"{firstArgument.ToString()}{currentOperation}";
                    lastOperation = currentOperation;
                    inputTextBox.Text = "";


                }
                else if (currentOperation == "=")
                {
                    secondArgument = double.Parse(inputTextBox.Text);
                        operationTextBox.Text += $"{secondArgument} =";
                    switch (lastOperation)
                    {
                        case "+":
                            result = firstArgument + secondArgument;
                            break;
                        case "-":
                            result = firstArgument - secondArgument;
                            break;
                        case "*":
                            result = firstArgument * secondArgument;
                            break;
                        case "/":
                            result = firstArgument / secondArgument;
                            break;
                        default:
                            break;

                    }
                    inputTextBox.Text = result.ToString();

                }else if (currentOperation == "%")
                {
                    if (operationTextBox.Text != "")
                    {
                        secondArgument = double.Parse(inputTextBox.Text);
                        double percentage = secondArgument / 100;
                        switch (lastOperation)
                        {
                            case "+":
                            case "-":
                                secondArgument = percentage * firstArgument;
                                break;
                            case "*":
                            case "/":
                                secondArgument = percentage;
                                break;
                        }

                        inputTextBox.Text = secondArgument.ToString();
                    }
                    else
                    {
                        inputTextBox.Text = "0";
                    }
                }
                else if (currentOperation == "\u221ax")
                {
                    firstArgument = double.Parse(inputTextBox.Text);
                    operationTextBox.Text = $"\u221a{firstArgument.ToString()}";
                    result = Math.Sqrt(firstArgument);
                    inputTextBox.Text = result.ToString();
                }else if (currentOperation == "x\u00b2")
                {
                    firstArgument = double.Parse(inputTextBox.Text);
                    operationTextBox.Text = $"{firstArgument.ToString()}\u00b2";
                    result = firstArgument * firstArgument;
                    inputTextBox.Text = result.ToString();
                }
                else if (currentOperation=="+/-")
                {
                    inputTextBox.Text = (double.Parse(inputTextBox.Text) * -1).ToString();
                }else if (currentOperation == "1/x")
                {
                    firstArgument = double.Parse(inputTextBox.Text);
                    operationTextBox.Text = $"1/({firstArgument.ToString()})";
                    result = 1 / firstArgument;
                    inputTextBox.Text = result.ToString();
                }else if (currentOperation=="\u232b")
                {
                    string inputText = inputTextBox.Text;
                    int inputTextLen = inputText.Length;
                    if (inputTextLen > 0)
                    {
                        inputTextBox.Text = inputText.Substring(0, inputTextLen-1);
                    }
                }
                else if (currentOperation == "C")
                {
                    inputTextBox.Text = "";
                    operationTextBox.Text = "";
                }else if (currentOperation == "CE")
                {
                    inputTextBox.Text = "";
                }else if (currentOperation == ",")
                {
                    if (!inputTextBox.Text.Contains(","))
                    {
                        inputTextBox.Text += clickedButton.Text;
                    }
                }
            }
        }
        private void MemoryButtonClicked(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            string clickedButtonName = clickedButton.Text;
            switch (clickedButtonName)
            {
                case "MC":
                    memory = 0;
                    break;
                case "MR":
                    inputTextBox.Text = memory.ToString();
                    break;
                case "M+":
                    memory += double.Parse(inputTextBox.Text);
                    break;
                case "M-":
                    memory -= double.Parse(inputTextBox.Text);
                    break;
                case "MS":
                    memory = double.Parse(inputTextBox.Text);
                    break;
            }
        }
    }
}
