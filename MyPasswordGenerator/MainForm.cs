namespace MyPasswordGenerator
{
    public partial class MyPasswordGenerator : Form
    {
        private PasswordClass passwordClass = new PasswordClass();
        private PasswordStrength passwordStrength = new PasswordStrength();

        private List<string> passwordHistory = new List<string>();

        public MyPasswordGenerator()
        {
            InitializeComponent();
        }

        private void GeneratePass_Btn_Click(object sender, EventArgs e)
        {
            // Get the password length and selected options from UI controls
            int length = GetPasswordLengthFromUI();
            bool includeUppercase = Uppercase_Chkbox.Checked;
            bool includeLowercase = Lowercase_Chkbox.Checked;
            bool includeDigits = Digits_Chkbox.Checked;
            bool includeSpecialCharacters = Special_Chkbox.Checked;
            bool includeBrackets = Brackets_Chkbox.Checked;

            // Generate the password based on selected options
            string password = passwordClass.GeneratePassword(length, includeUppercase, includeLowercase, includeDigits, includeSpecialCharacters, includeBrackets);

            DisplayGeneratedPassword(password);
            CalculateAndDisplayStrength(password);
            AddToPasswordHistory(password);
        }

        private int GetPasswordLengthFromUI()
        {
            // Assuming PassLength_NumUpDown is a NumericUpDown control for entering password length
            int length = (int)PassLength_NumUpDown.Value;

            return length;
        }

        private void DisplayGeneratedPassword(string password)
        {
            GeneratedPass_Txtbox.Text = password; // Update the text box with the generated password
        }

        private void CalculateAndDisplayStrength(string password)
        {
            int strength = passwordStrength.CalculateStrength(password); // Calculate the strength of the password
            lblStrength.Text = $"Password Strength: {strength}%"; // Update a label to display the strength
            PbarStrength.Value = strength; // Update a progress bar with the strength value
        }

        private void AddToPasswordHistory(string password)
        {
            PassListboxHistory.Items.Add(password); // Add the password to a list box for history
            passwordHistory.Add(password); // Add the password to a list or data structure for history tracking
        }

        private void CopyPass_Btn_Click(object sender, EventArgs e)
        {
            //Copy generated password to clipboard
            Clipboard.SetText(GeneratedPass_Txtbox.Text);
        }

        private void ToolBtnCloseApp_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }

        private void ToolBtnClearHistory_Click(object sender, EventArgs e)
        {
            //Clear the password history listbox
            PassListboxHistory.Items.Clear();
        }
    }
}
